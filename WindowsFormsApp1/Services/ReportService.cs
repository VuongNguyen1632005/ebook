using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    /// <summary>
    /// Service for creating reports (PDF, Excel, etc.)
    /// </summary>
    public class ReportService
    {
        public void CreateBookListReport(List<Book> books, string displayName)
        {
            try
            {
                // T?o n?i dung báo cáo HTML/CSV
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "HTML Files (*.html)|*.html|CSV Files (*.csv)|*.csv",
                    FileName = $"BaoCaoSach_{DateTime.Now:yyyyMMdd_HHmmss}",
                    Title = "Lýu báo cáo"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveDialog.FileName;
                    bool isHtml = fileName.EndsWith(".html", StringComparison.OrdinalIgnoreCase);

                    if (isHtml)
                    {
                        CreateHtmlReport(books, displayName, fileName);
                    }
                    else
                    {
                        CreateCsvReport(books, displayName, fileName);
                    }

                    var result = MessageBox.Show(
                        $"Báo cáo ð? ðý?c lýu thành công!\n\nB?n có mu?n m? file báo cáo không?",
                        "Thành công",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i khi t?o báo cáo: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateHtmlReport(List<Book> books, string displayName, string fileName)
        {
            StringBuilder html = new StringBuilder();
            
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html lang='vi'>");
            html.AppendLine("<head>");
            html.AppendLine("    <meta charset='UTF-8'>");
            html.AppendLine("    <meta name='viewport' content='width=device-width, initial-scale=1.0'>");
            html.AppendLine("    <title>Báo cáo Danh sách Sách</title>");
            html.AppendLine("    <style>");
            html.AppendLine("        * { margin: 0; padding: 0; box-sizing: border-box; }");
            html.AppendLine("        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background: #f5f5f5; padding: 20px; }");
            html.AppendLine("        .container { max-width: 1200px; margin: 0 auto; background: white; padding: 30px; border-radius: 10px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }");
            html.AppendLine("        h1 { color: #2c3e50; border-bottom: 3px solid #3498db; padding-bottom: 10px; margin-bottom: 20px; }");
            html.AppendLine("        .info { background: #ecf0f1; padding: 15px; border-radius: 5px; margin-bottom: 20px; }");
            html.AppendLine("        table { width: 100%; border-collapse: collapse; margin-top: 20px; }");
            html.AppendLine("        th { background: #3498db; color: white; padding: 12px; text-align: left; font-weight: bold; }");
            html.AppendLine("        td { padding: 10px; border-bottom: 1px solid #ddd; }");
            html.AppendLine("        tr:hover { background: #f8f9fa; }");
            html.AppendLine("        .progress { background: #e0e0e0; height: 20px; border-radius: 10px; overflow: hidden; }");
            html.AppendLine("        .progress-bar { height: 100%; background: linear-gradient(90deg, #4CAF50, #8BC34A); text-align: center; line-height: 20px; color: white; font-size: 12px; }");
            html.AppendLine("        .favorite { color: #e74c3c; }");
            html.AppendLine("        .footer { margin-top: 30px; text-align: center; color: #7f8c8d; font-size: 14px; }");
            html.AppendLine("    </style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");
            html.AppendLine("    <div class='container'>");
            html.AppendLine($"        <h1>?? BÁO CÁO DANH SÁCH SÁCH</h1>");
            html.AppendLine("        <div class='info'>");
            html.AppendLine($"            <p><strong>?? Ngý?i dùng:</strong> {displayName}</p>");
            html.AppendLine($"            <p><strong>?? Ngày t?o báo cáo:</strong> {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>");
            html.AppendLine($"            <p><strong>?? T?ng s? sách:</strong> {books.Count} cu?n</p>");
            html.AppendLine("        </div>");
            
            html.AppendLine("        <table>");
            html.AppendLine("            <thead>");
            html.AppendLine("                <tr>");
            html.AppendLine("                    <th>STT</th>");
            html.AppendLine("                    <th>Tên sách</th>");
            html.AppendLine("                    <th>Tác gi?</th>");
            html.AppendLine("                    <th>Ð?nh d?ng</th>");
            html.AppendLine("                    <th>Ti?n ð? ð?c</th>");
            html.AppendLine("                    <th>Ngày thêm</th>");
            html.AppendLine("                    <th>Yêu thích</th>");
            html.AppendLine("                </tr>");
            html.AppendLine("            </thead>");
            html.AppendLine("            <tbody>");

            int index = 1;
            foreach (var book in books)
            {
                html.AppendLine("                <tr>");
                html.AppendLine($"                    <td>{index++}</td>");
                html.AppendLine($"                    <td><strong>{System.Security.SecurityElement.Escape(book.Title)}</strong></td>");
                html.AppendLine($"                    <td>{System.Security.SecurityElement.Escape(book.Author)}</td>");
                html.AppendLine($"                    <td>{book.FileType.ToUpper()}</td>");
                html.AppendLine($"                    <td>");
                html.AppendLine($"                        <div class='progress'>");
                html.AppendLine($"                            <div class='progress-bar' style='width: {book.Progress}%'>{book.Progress:F1}%</div>");
                html.AppendLine($"                        </div>");
                html.AppendLine($"                    </td>");
                html.AppendLine($"                    <td>{book.DateAdded:dd/MM/yyyy}</td>");
                html.AppendLine($"                    <td class='favorite'>{(book.IsFavorite ? "??" : "")}</td>");
                html.AppendLine("                </tr>");
            }

            html.AppendLine("            </tbody>");
            html.AppendLine("        </table>");
            html.AppendLine("        <div class='footer'>");
            html.AppendLine("            <p>?? Báo cáo ðý?c t?o b?i Koodo Reader</p>");
            html.AppendLine("        </div>");
            html.AppendLine("    </div>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            File.WriteAllText(fileName, html.ToString(), Encoding.UTF8);
        }

        private void CreateCsvReport(List<Book> books, string displayName, string fileName)
        {
            StringBuilder csv = new StringBuilder();
            
            // Header
            csv.AppendLine($"# BÁO CÁO DANH SÁCH SÁCH");
            csv.AppendLine($"# Ngý?i dùng: {displayName}");
            csv.AppendLine($"# Ngày t?o: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            csv.AppendLine($"# T?ng s? sách: {books.Count}");
            csv.AppendLine();
            
            // Column headers
            csv.AppendLine("STT,Tên sách,Tác gi?,Ð?nh d?ng,Ti?n ð? ð?c (%),Ngày thêm,Yêu thích");

            // Data rows
            int index = 1;
            foreach (var book in books)
            {
                string title = EscapeCsvField(book.Title);
                string author = EscapeCsvField(book.Author);
                string progress = book.Progress.ToString("F1");
                string dateAdded = book.DateAdded.ToString("dd/MM/yyyy");
                string favorite = book.IsFavorite ? "Có" : "Không";

                csv.AppendLine($"{index++},{title},{author},{book.FileType},{progress},{dateAdded},{favorite}");
            }

            File.WriteAllText(fileName, csv.ToString(), Encoding.UTF8);
        }

        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
                return "\"\"";

            // N?u có d?u ph?y, d?u ngo?c kép ho?c xu?ng d?ng th? b?c trong d?u ngo?c kép
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            }

            return field;
        }

        public void CreateNotesReport(Book book, List<Highlight> highlights)
        {
            MessageBox.Show("Ch?c nãng xu?t ghi chú chýa ðý?c tri?n khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // [M?I] Báo cáo t?ng h?p ghi chú và ðánh d?u
        public void CreateHighlightsNotesReport(List<Highlight> highlights, List<Highlight> notes, string displayName)
        {
            // TODO: Implement PDF/Excel export
            string message = $"Báo cáo cho {displayName}\n\n";
            message += $"?? T?ng s? ðánh d?u: {highlights.Count}\n";
            message += $"?? T?ng s? ghi chú: {notes.Count}\n\n";
            message += "Ch?c nãng xu?t file PDF/Excel ðang ðý?c phát tri?n.";
            
            MessageBox.Show(message, "Báo cáo Ghi chú & Ðánh d?u", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CreateGoalsReport(int userId, ReadingStreak streak, int todayMinutes, int monthlyBooks, int yearlyBooks, object weeklyStats, object goals)
        {
            MessageBox.Show("Ch?c nãng báo cáo m?c tiêu chýa ðý?c tri?n khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
