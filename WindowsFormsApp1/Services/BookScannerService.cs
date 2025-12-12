using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using VersOne.Epub;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class BookScannerService
    {
        private readonly DataManager _dataManager;
        private readonly string _coverImageFolder;

        public BookScannerService(DataManager dataManager)
        {
            _dataManager = dataManager;
            _coverImageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CoverImages");
            if (!Directory.Exists(_coverImageFolder)) Directory.CreateDirectory(_coverImageFolder);
        }

        public string CalculateMD5(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return null;
                using (var md5 = MD5.Create())
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
            catch { return null; }
        }

        public int GetFileSizeKB(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return 0;
                return (int)(new FileInfo(filePath).Length / 1024);
            }
            catch { return 0; }
        }

        private string SaveCoverImage(byte[] coverBytes, string fileNameWithoutExt)
        {
            if (coverBytes == null || coverBytes.Length == 0) return null;
            try
            {
                string fileName = $"{fileNameWithoutExt}_{Guid.NewGuid().ToString().Substring(0, 8)}.jpg";
                string destPath = Path.Combine(_coverImageFolder, fileName);
                File.WriteAllBytes(destPath, coverBytes);
                return destPath;
            }
            catch { return null; }
        }

        private byte[] ConvertPdfImageToBytes(IPdfImage pdfImage)
        {
            try
            {
                if (pdfImage.TryGetPng(out byte[] pngBytes)) return pngBytes;
                return pdfImage.RawBytes.ToArray();
            }
            catch { return null; }
        }

        public Book CreateBookFromFile(string filePath, bool readMetadata = true)
        {
            try
            {
                if (!File.Exists(filePath)) return null;

                var fileInfo = new FileInfo(filePath);
                string ext = fileInfo.Extension.ToLower();
                string rawExt = ext.Replace(".", "").ToUpper();

                var book = new Book
                {
                    FilePath = filePath,
                    FileType = rawExt,
                    Title = Path.GetFileNameWithoutExtension(filePath),
                    Author = "Unknown Author",
                    FileSizeKB = GetFileSizeKB(filePath),
                    MD5 = CalculateMD5(filePath),
                    DateAdded = DateTime.Now,
                    IsFavorite = false,
                    IsDeleted = false,
                    Progress = 0,
                    TotalPages = 0,
                    CurrentPage = 0
                };

                if (!readMetadata) return book;

                if (ext == ".epub")
                {
                    try
                    {
                        EpubBook epub = EpubReader.ReadBook(filePath);
                        if (!string.IsNullOrWhiteSpace(epub.Title)) book.Title = epub.Title;
                        if (epub.AuthorList != null && epub.AuthorList.Count > 0) book.Author = string.Join(", ", epub.AuthorList);
                        else if (!string.IsNullOrWhiteSpace(epub.Author)) book.Author = epub.Author;
                        book.Description = epub.Description;

                        if (epub.CoverImage != null && epub.CoverImage.Length > 0)
                            book.CoverImagePath = SaveCoverImage(epub.CoverImage, Path.GetFileNameWithoutExtension(filePath));
                    }
                    catch (Exception ex) { Console.WriteLine($"L?i Metadata EPUB: {ex.Message}"); }
                }
                else if (ext == ".pdf")
                {
                    try
                    {
                        using (var pdf = PdfDocument.Open(filePath))
                        {
                            if (pdf.Information.Title != null) book.Title = pdf.Information.Title;
                            if (pdf.Information.Author != null) book.Author = pdf.Information.Author;

                            book.TotalPages = pdf.NumberOfPages;

                            try
                            {
                                var page1 = pdf.GetPage(1);
                                var images = page1.GetImages();
                                foreach (var img in images)
                                {
                                    byte[] imgBytes = ConvertPdfImageToBytes(img);
                                    if (imgBytes != null && imgBytes.Length > 0)
                                    {
                                        book.CoverImagePath = SaveCoverImage(imgBytes, Path.GetFileNameWithoutExtension(filePath));
                                        break;
                                    }
                                }
                            }
                            catch { }
                        }
                    }
                    catch (Exception ex) { Console.WriteLine($"L?i Metadata PDF: {ex.Message}"); }
                }

                if (ext != ".pdf")
                {
                    try
                    {
                        var readerService = new BookReaderService(_dataManager);
                        book.TotalPages = readerService.EstimateTotalPages(filePath);
                    }
                    catch { book.TotalPages = 0; }
                }

                return book;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i file {Path.GetFileName(filePath)}: {ex.Message}");
                return null;
            }
        }

        public void ScanFolderAndImport(string folderPath, int userId, Action<string> onProgress)
        {
            if (!Directory.Exists(folderPath)) return;

            string[] extensions = { "*.epub", "*.pdf", "*.txt", "*.mobi" };
            List<string> files = new List<string>();

            foreach (var ext in extensions)
            {
                try { files.AddRange(Directory.GetFiles(folderPath, ext, SearchOption.AllDirectories)); }
                catch { }
            }

            int total = files.Count;
            int current = 0;
            int imported = 0;
            int skipped = 0;

            foreach (string file in files)
            {
                current++;
                string fileName = Path.GetFileName(file);
                onProgress?.Invoke($"[{current}/{total}] {fileName}");

                try
                {
                    if (_dataManager.IsBookExists(file))
                    {
                        skipped++;
                        continue;
                    }

                    var book = CreateBookFromFile(file, readMetadata: true);
                    if (book != null)
                    {
                        _dataManager.AddBook(book);
                        imported++;
                    }
                }
                catch (Exception ex)
                {
                    onProgress?.Invoke($"L?i: {ex.Message}");
                }
            }
            onProgress?.Invoke($"HOÀN T?T! Thêm: {imported}, B? qua: {skipped}.");
        }
    }
}
