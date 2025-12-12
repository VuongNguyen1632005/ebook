using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models; // Thêm using cho Models

namespace WindowsFormsApp1.Data
{
    public class DataManager
    {
        private static DataManager instance;

        // Mặc định là 0 (Chưa đăng nhập/Guest)
        private int currentUserId = 0;

        public static DataManager Instance
        {
            get
            {
                if (instance == null) instance = new DataManager();
                return instance;
            }
        }

        private DataManager() { }

        // --- QUẢN LÝ USER ID ---
        public void SetCurrentUser(int userId)
        {
            currentUserId = userId;
        }

        public int GetCurrentUser()
        {
            return currentUserId;
        }

        // --- LOGIC ĐĂNG NHẬP / ĐĂNG KÝ ---
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public User Login(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            string query = "SELECT MaNguoiDung, TenDangNhap, TenHienThi, Email FROM NguoiDung WHERE (TenDangNhap = @User OR Email = @User) AND MatKhauHash = @Pass";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", username);
                        cmd.Parameters.AddWithValue("@Pass", hashedPassword);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var user = new User
                                {
                                    Id = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    DisplayName = reader.IsDBNull(2) ? reader.GetString(1) : reader.GetString(2),
                                    Email = reader.IsDBNull(3) ? "" : reader.GetString(3)
                                };

                                SetCurrentUser(user.Id);
                                return user;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
            return null;
        }

        // [MỚI] Lấy thông tin user theo ID
        public User GetUserById(int userId)
        {
            string query = "SELECT MaNguoiDung, TenDangNhap, TenHienThi, Email FROM NguoiDung WHERE MaNguoiDung = @UserId";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    Id = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    DisplayName = reader.IsDBNull(2) ? reader.GetString(1) : reader.GetString(2),
                                    Email = reader.IsDBNull(3) ? "" : reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy thông tin user: " + ex.Message);
            }
            return null;
        }

        public User Register(string username, string password, string displayName, string email)
        {
            if (IsUserExists(username))
            {
                throw new Exception("Tên đăng nhập đã tồn tại!");
            }

            string hashedPassword = HashPassword(password);
            string query = @"
                INSERT INTO NguoiDung (TenDangNhap, MatKhauHash, TenHienThi, Email, NgayTao) 
                VALUES (@User, @Pass, @Name, @Email, GETDATE());
                SELECT CAST(SCOPE_IDENTITY() as int);";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", username);
                        cmd.Parameters.AddWithValue("@Pass", hashedPassword);
                        cmd.Parameters.AddWithValue("@Name", displayName);
                        cmd.Parameters.AddWithValue("@Email", email ?? "");

                        int newId = (int)cmd.ExecuteScalar();
                        SetCurrentUser(newId);

                        return new User
                        {
                            Id = newId,
                            Username = username,
                            DisplayName = displayName,
                            Email = email
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đăng ký: " + ex.Message);
            }
        }

        public bool IsUserExists(string username)
        {
            string query = "SELECT COUNT(1) FROM NguoiDung WHERE TenDangNhap = @User";
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User", username);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // --- CÁC HÀM QUẢN LÝ SÁCH ---

        public List<Book> GetAllBooks()
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid 
                AND s.MaSach NOT IN (SELECT MaSach FROM ThungRac)
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, 
                         s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, 
                         s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, 
                         s.XepHang, s.YeuThich
                ORDER BY s.NgayThem DESC";

            return ExecuteBookQuery(query);
        }

        public List<Book> GetDeletedBooks()
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                INNER JOIN ThungRac tr ON s.MaSach = tr.MaSach
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid 
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, 
                         s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, 
                         s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, 
                         s.XepHang, s.YeuThich";

            var books = ExecuteBookQuery(query);
            books.ForEach(b => b.IsDeleted = true);
            return books;
        }

        public List<Book> GetFavoriteBooks()
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid AND s.YeuThich = 1
                AND s.MaSach NOT IN (SELECT MaSach FROM ThungRac)
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, s.XepHang, s.YeuThich";

            return ExecuteBookQuery(query);
        }

        public Book GetBookById(int bookId)
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid 
                AND s.MaSach = @Bid
                AND s.MaSach NOT IN (SELECT MaSach FROM ThungRac)
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, 
                         s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, 
                         s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, 
                         s.XepHang, s.YeuThich";

            var list = ExecuteBookQuery(query, cmd => cmd.Parameters.AddWithValue("@Bid", bookId));
            return list.FirstOrDefault();
        }

        // Helper thực thi query lấy danh sách sách, hỗ trợ thêm tham số động
        private List<Book> ExecuteBookQuery(string query, Action<SqlCommand> addParameters = null)
        {
            var list = new List<Book>();
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Uid", currentUserId);
                        addParameters?.Invoke(cmd); // Thêm tham số nếu có (ví dụ @Bid)

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var book = new Book
                                {
                                    Id = Convert.ToInt32(reader["MaSach"]),
                                    Title = reader["TieuDe"].ToString(),
                                    Author = reader["DanhSachTacGia"] != DBNull.Value ? reader["DanhSachTacGia"].ToString() : "Unknown",
                                    Description = reader["MoTa"] != DBNull.Value ? reader["MoTa"].ToString() : "",
                                    MD5 = reader["MaMD5"] != DBNull.Value ? reader["MaMD5"].ToString() : "",
                                    CoverImagePath = reader["DuongDanAnhBia"] != DBNull.Value ? reader["DuongDanAnhBia"].ToString() : null,
                                    FilePath = reader["DuongDanFile"].ToString(),
                                    FileType = reader["DinhDang"].ToString(),
                                    TotalPages = reader["TongSoTrang"] != DBNull.Value ? Convert.ToInt32(reader["TongSoTrang"]) : 0,
                                    CurrentPage = Convert.ToInt32(reader["TrangHienTai"]),
                                    FileSizeKB = reader["KichThuocKB"] != DBNull.Value ? Convert.ToInt32(reader["KichThuocKB"]) : 0,
                                    IsFavorite = Convert.ToBoolean(reader["YeuThich"]),
                                    DateAdded = Convert.ToDateTime(reader["NgayThem"]),
                                    Rating = reader["XepHang"] != DBNull.Value ? Convert.ToByte(reader["XepHang"]) : (byte)0
                                };

                                if (book.TotalPages > 0)
                                    book.Progress = (double)book.CurrentPage / book.TotalPages * 100;

                                list.Add(book);
                            }
                        }
                    }
                }
            }
            catch { }
            return list;
        }

        public void AddBook(Book book)
        {
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string insertSach = @"
                            INSERT INTO Sach (MaNguoiDung, TieuDe, MoTa, MaMD5, DuongDanAnhBia, DinhDang, KichThuocKB, TongSoTrang, DuongDanFile, NgayThem, YeuThich) 
                            VALUES (@Uid, @Title, @Desc, @MD5, @Cover, @Fmt, @Size, @Pages, @Path, @Date, @Fav);
                            SELECT CAST(SCOPE_IDENTITY() as int);";

                        int newBookId;
                        using (var cmd = new SqlCommand(insertSach, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@Uid", currentUserId);
                            cmd.Parameters.AddWithValue("@Title", book.Title);
                            cmd.Parameters.AddWithValue("@Desc", (object)book.Description ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@MD5", (object)book.MD5 ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Cover", (object)book.CoverImagePath ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Fmt", book.FileType);
                            cmd.Parameters.AddWithValue("@Size", book.FileSizeKB);
                            cmd.Parameters.AddWithValue("@Pages", book.TotalPages);
                            cmd.Parameters.AddWithValue("@Path", book.FilePath);
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Fav", book.IsFavorite);

                            newBookId = (int)cmd.ExecuteScalar();
                        }

                        if (!string.IsNullOrEmpty(book.Author))
                        {
                            var authors = book.Author.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var authName in authors)
                            {
                                string nameTrim = authName.Trim();
                                int authorId = 0;

                                using (var cmdCheck = new SqlCommand("SELECT MaTacGia FROM TacGia WHERE TenTacGia = @Name", conn, trans))
                                {
                                    cmdCheck.Parameters.AddWithValue("@Name", nameTrim);
                                    var res = cmdCheck.ExecuteScalar();
                                    if (res != null) authorId = (int)res;
                                }

                                if (authorId == 0)
                                {
                                    using (var cmdInsAuth = new SqlCommand("INSERT INTO TacGia (TenTacGia) VALUES (@Name); SELECT CAST(SCOPE_IDENTITY() as int);", conn, trans))
                                    {
                                        cmdInsAuth.Parameters.AddWithValue("@Name", nameTrim);
                                        authorId = (int)cmdInsAuth.ExecuteScalar();
                                    }
                                }

                                using (var cmdLink = new SqlCommand("INSERT INTO Sach_TacGia (MaSach, MaTacGia) VALUES (@Bid, @Aid)", conn, trans))
                                {
                                    cmdLink.Parameters.AddWithValue("@Bid", newBookId);
                                    cmdLink.Parameters.AddWithValue("@Aid", authorId);
                                    cmdLink.ExecuteNonQuery();
                                }
                            }
                        }
                        trans.Commit();
                        book.Id = newBookId;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Lỗi thêm sách: " + ex.Message);
                    }
                }
            }
        }

        public void DeleteBook(int bookId)
        {
            string query = "IF NOT EXISTS (SELECT 1 FROM ThungRac WHERE MaSach = @Id) INSERT INTO ThungRac (MaSach) VALUES (@Id)";
            ExecuteSimpleNonQuery(query, "@Id", bookId);
        }

        public void RestoreBook(int bookId)
        {
            string query = "DELETE FROM ThungRac WHERE MaSach = @Id";
            ExecuteSimpleNonQuery(query, "@Id", bookId);
        }

        public void PermanentlyDeleteBook(int bookId)
        {
            string query = "DELETE FROM Sach WHERE MaSach = @Id";
            ExecuteSimpleNonQuery(query, "@Id", bookId);
        }

        public void PermanentDeleteBook(int bookId)
        {
            // Alias method for consistency
            PermanentlyDeleteBook(bookId);
        }

        public void ToggleFavorite(int bookId)
        {
            string query = "UPDATE Sach SET YeuThich = CASE WHEN YeuThich = 1 THEN 0 ELSE 1 END WHERE MaSach = @Id";
            ExecuteSimpleNonQuery(query, "@Id", bookId);
        }

        public bool IsBookExists(string filePath)
        {
            string query = @"
                SELECT COUNT(1) 
                FROM Sach 
                WHERE DuongDanFile = @Path 
                AND MaNguoiDung = @Uid 
                AND MaSach NOT IN (SELECT MaSach FROM ThungRac)";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Path", filePath);
                        cmd.Parameters.AddWithValue("@Uid", currentUserId);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra sách: " + ex.Message);
                return false;
            }
        }

        private void ExecuteSimpleNonQuery(string query, string pName, object pVal)
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(pName, pVal);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thao tác: " + ex.Message);
            }
        }

        // --- QUẢN LÝ KỆ SÁCH (SHELF) ---

        public int AddShelf(string shelfName, string description = "")
        {
            string query = @"
                INSERT INTO KeSach (MaNguoiDung, TenKeSach, MoTa, NgayTao) 
                VALUES (@Uid, @Name, @Desc, GETDATE());
                SELECT CAST(SCOPE_IDENTITY() as int);";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Uid", currentUserId);
                        cmd.Parameters.AddWithValue("@Name", shelfName);
                        cmd.Parameters.AddWithValue("@Desc", (object)description ?? DBNull.Value);

                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tạo kệ sách: " + ex.Message);
            }
        }

        public void AddBookToShelf(int bookId, int shelfId)
        {
            string checkQuery = "SELECT COUNT(1) FROM KeSach_Sach WHERE MaKeSach = @Sid AND MaSach = @Bid";
            string insertQuery = @"
                INSERT INTO KeSach_Sach (MaKeSach, MaSach, NgayThemVaoKe) 
                VALUES (@Sid, @Bid, GETDATE())";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();

                    using (var cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Sid", shelfId);
                        cmdCheck.Parameters.AddWithValue("@Bid", bookId);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0) return;
                    }

                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Sid", shelfId);
                        cmd.Parameters.AddWithValue("@Bid", bookId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm sách vào kệ: " + ex.Message);
            }
        }

        public List<Shelf> GetShelvesList()
        {
            var list = new List<Shelf>();
            string query = "SELECT MaKeSach, TenKeSach, MoTa FROM KeSach WHERE MaNguoiDung = @Uid";
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Uid", currentUserId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Shelf
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    UserId = currentUserId
                                });
                            }
                        }
                    }
                }
            }
            catch { }
            return list;
        }

        public void RenameShelf(int shelfId, string newName)
        {
            string query = "UPDATE KeSach SET TenKeSach = @Name WHERE MaKeSach = @Id AND MaNguoiDung = @Uid";
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", newName);
                        cmd.Parameters.AddWithValue("@Id", shelfId);
                        cmd.Parameters.AddWithValue("@Uid", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đổi tên kệ: " + ex.Message);
            }
        }

        public void DeleteShelf(int shelfId)
        {
            string query = "DELETE FROM KeSach WHERE MaKeSach = @Id AND MaNguoiDung = @Uid";
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", shelfId);
                        cmd.Parameters.AddWithValue("@Uid", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa kệ: " + ex.Message);
            }
        }

        public List<string> GetShelves()
        {
            return GetShelvesList().Select(s => s.Name).ToList();
        }

        public List<Book> GetBooksByShelf(int shelfId)
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                INNER JOIN KeSach_Sach kss ON s.MaSach = kss.MaSach
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid 
                AND kss.MaKeSach = @Sid
                AND s.MaSach NOT IN (SELECT MaSach FROM ThungRac)
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, 
                         s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, 
                         s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, 
                         s.XepHang, s.YeuThich
                ORDER BY s.NgayThem DESC";

            return ExecuteBookQuery(query, cmd => cmd.Parameters.AddWithValue("@Sid", shelfId));
        }

        // --- PHẦN QUẢN LÝ HIGHLIGHT & NOTE ---

        public void AddHighlight(Highlight hl)
        {
            string query = @"
                INSERT INTO GhiChu (MaSach, NoiDungTrichDan, GhiChuCuaNguoiDung, MauSac, ViTriCFI, NgayTao) 
                VALUES (@Bid, @Text, @Note, @Color, @Pos, GETDATE())";

            string positionData = $"{hl.ChapterIndex}|{hl.StartIndex}|{hl.Length}";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Bid", hl.BookId);
                    cmd.Parameters.AddWithValue("@Text", hl.SelectedText);
                    cmd.Parameters.AddWithValue("@Note", (object)hl.Note ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Color", hl.ColorHex);
                    cmd.Parameters.AddWithValue("@Pos", positionData);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Highlight> GetOnlyHighlights(int userId)
        {
            string query = @"
                SELECT g.*, s.TieuDe, s.DuongDanFile 
                FROM GhiChu g 
                JOIN Sach s ON g.MaSach = s.MaSach 
                WHERE s.MaNguoiDung = @Uid 
                AND (g.GhiChuCuaNguoiDung IS NULL OR g.GhiChuCuaNguoiDung = '')
                ORDER BY g.NgayTao DESC";
            return ExecuteHighlightQuery(query, userId);
        }

        public List<Highlight> GetOnlyNotes(int userId)
        {
            string query = @"
                SELECT g.*, s.TieuDe, s.DuongDanFile 
                FROM GhiChu g 
                JOIN Sach s ON g.MaSach = s.MaSach 
                WHERE s.MaNguoiDung = @Uid 
                AND g.GhiChuCuaNguoiDung <> '' 
                ORDER BY g.NgayTao DESC";
            return ExecuteHighlightQuery(query, userId);
        }

        public List<Highlight> GetHighlightsForBook(int bookId)
        {
            string query = "SELECT * FROM GhiChu WHERE MaSach = @Bid";
            return ExecuteHighlightQuery(query, 0, bookId);
        }

        private List<Highlight> ExecuteHighlightQuery(string query, int userId = 0, int bookId = 0)
        {
            var list = new List<Highlight>();
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        if (userId > 0) cmd.Parameters.AddWithValue("@Uid", userId);
                        if (bookId > 0) cmd.Parameters.AddWithValue("@Bid", bookId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var hl = new Highlight
                                {
                                    Id = Convert.ToInt32(reader["MaGhiChu"]),
                                    BookId = Convert.ToInt32(reader["MaSach"]),
                                    SelectedText = reader["NoiDungTrichDan"].ToString(),
                                    Note = reader["GhiChuCuaNguoiDung"] != DBNull.Value ? reader["GhiChuCuaNguoiDung"].ToString() : "",
                                    ColorHex = reader["MauSac"].ToString(),
                                    DateCreated = Convert.ToDateTime(reader["NgayTao"]),
                                    BookTitle = ColumnExists(reader, "TieuDe") && reader["TieuDe"] != DBNull.Value ? reader["TieuDe"].ToString() : ""
                                };

                                string posData = reader["ViTriCFI"].ToString();
                                if (!string.IsNullOrEmpty(posData))
                                {
                                    var parts = posData.Split('|');
                                    if (parts.Length == 3)
                                    {
                                        if (int.TryParse(parts[0], out int ch)) hl.ChapterIndex = ch;
                                        if (int.TryParse(parts[1], out int st)) hl.StartIndex = st;
                                        if (int.TryParse(parts[2], out int len)) hl.Length = len;
                                    }
                                }
                                list.Add(hl);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching highlights: " + ex.Message);
            }
            return list;
        }

        private bool ColumnExists(SqlDataReader reader, string columnName)
        {
            try
            {
                return reader.GetOrdinal(columnName) >= 0;
            }
            catch
            {
                return false;
            }
        }

        // --- [MỚI] CÁC HÀM LẤY SÁCH THEO ĐIỀU KIỆN (HIGHLIGHT/NOTE) ---

        // 1. Lấy danh sách sách CÓ Highlight
        public List<Book> GetBooksWithHighlights()
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                -- INNER JOIN: Chỉ lấy sách có tồn tại trong bảng GhiChu
                INNER JOIN GhiChu g ON s.MaSach = g.MaSach
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid 
                AND (g.GhiChuCuaNguoiDung IS NULL OR g.GhiChuCuaNguoiDung = '') -- Điều kiện là Highlight
                AND s.MaSach NOT IN (SELECT MaSach FROM ThungRac)
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, 
                         s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, 
                         s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, 
                         s.XepHang, s.YeuThich
                ORDER BY s.TieuDe";

            return ExecuteBookQuery(query);
        }

        // 2. Lấy danh sách sách CÓ Ghi chú (Note)
        public List<Book> GetBooksWithNotes()
        {
            string query = @"
                SELECT s.*, STRING_AGG(tg.TenTacGia, ', ') AS DanhSachTacGia 
                FROM Sach s 
                -- INNER JOIN: Chỉ lấy sách có tồn tại trong bảng GhiChu
                INNER JOIN GhiChu g ON s.MaSach = g.MaSach
                LEFT JOIN Sach_TacGia stg ON s.MaSach = stg.MaSach 
                LEFT JOIN TacGia tg ON stg.MaTacGia = tg.MaTacGia 
                WHERE s.MaNguoiDung = @Uid 
                AND (g.GhiChuCuaNguoiDung IS NOT NULL AND g.GhiChuCuaNguoiDung <> '') -- Điều kiện là Note
                AND s.MaSach NOT IN (SELECT MaSach FROM ThungRac)
                GROUP BY s.MaSach, s.MaNguoiDung, s.MaNhaXuatBan, s.TieuDe, s.MoTa, 
                         s.MaMD5, s.DuongDanAnhBia, s.DinhDang, s.KichThuocKB, 
                         s.TongSoTrang, s.DuongDanFile, s.NgayThem, s.TrangHienTai, 
                         s.XepHang, s.YeuThich
                ORDER BY s.TieuDe";

            return ExecuteBookQuery(query);
        }

        // --- Thêm vào DataManager.cs ---

        public void DeleteHighlight(int id)
        {
            // MaGhiChu là khóa chính của bảng GhiChu
            string query = "DELETE FROM GhiChu WHERE MaGhiChu = @Id";
            ExecuteSimpleNonQuery(query, "@Id", id);
        }

        // Xóa tất cả ghi chú của user
        public int DeleteAllNotes(int userId)
        {
            string countQuery = @"
                SELECT COUNT(*) 
                FROM GhiChu g
                INNER JOIN Sach s ON g.MaSach = s.MaSach
                WHERE s.MaNguoiDung = @Uid
                AND g.GhiChuCuaNguoiDung IS NOT NULL 
                AND g.GhiChuCuaNguoiDung <> ''";

            string deleteQuery = @"
                DELETE g
                FROM GhiChu g
                INNER JOIN Sach s ON g.MaSach = s.MaSach
                WHERE s.MaNguoiDung = @Uid
                AND g.GhiChuCuaNguoiDung IS NOT NULL 
                AND g.GhiChuCuaNguoiDung <> ''";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    
                    // Đếm số lượng trước khi xóa
                    int count = 0;
                    using (var cmdCount = new SqlCommand(countQuery, conn))
                    {
                        cmdCount.Parameters.AddWithValue("@Uid", userId);
                        count = (int)cmdCount.ExecuteScalar();
                    }

                    // Thực hiện xóa
                    if (count > 0)
                    {
                        using (var cmdDelete = new SqlCommand(deleteQuery, conn))
                        {
                            cmdDelete.Parameters.AddWithValue("@Uid", userId);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }

                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa ghi chú: " + ex.Message);
            }
        }

        // Xóa tất cả đánh dấu của user
        public int DeleteAllHighlights(int userId)
        {
            string countQuery = @"
                SELECT COUNT(*) 
                FROM GhiChu g
                INNER JOIN Sach s ON g.MaSach = s.MaSach
                WHERE s.MaNguoiDung = @Uid
                AND (g.GhiChuCuaNguoiDung IS NULL OR g.GhiChuCuaNguoiDung = '')";

            string deleteQuery = @"
                DELETE g
                FROM GhiChu g
                INNER JOIN Sach s ON g.MaSach = s.MaSach
                WHERE s.MaNguoiDung = @Uid
                AND (g.GhiChuCuaNguoiDung IS NULL OR g.GhiChuCuaNguoiDung = '')";

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    
                    // Đếm số lượng trước khi xóa
                    int count = 0;
                    using (var cmdCount = new SqlCommand(countQuery, conn))
                    {
                        cmdCount.Parameters.AddWithValue("@Uid", userId);
                        count = (int)cmdCount.ExecuteScalar();
                    }

                    // Thực hiện xóa
                    if (count > 0)
                    {
                        using (var cmdDelete = new SqlCommand(deleteQuery, conn))
                        {
                            cmdDelete.Parameters.AddWithValue("@Uid", userId);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }

                    return count;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa đánh dấu: " + ex.Message);
            }
        }

        // --- THÊM V ÀO DataManager.cs ---

        // 1. Xác thực mật khẩu hiện tại (Dùng cho bước yêu cầu nhập lại pass)
        public bool VerifyCurrentPassword(int userId, string password)
        {
            string hashedPassword = HashPassword(password); // Tận dụng hàm Hash có sẵn
            string query = "SELECT COUNT(1) FROM NguoiDung WHERE MaNguoiDung = @Id AND MatKhauHash = @Pass";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.Parameters.AddWithValue("@Pass", hashedPassword);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // 2. Cập nhật thông tin người dùng
        public void UpdateUserProfile(int userId, string displayName, string email, string newPassword = null)
        {
            // Nếu newPassword có giá trị thì update cả mật khẩu, nếu null/rỗng thì giữ nguyên
            string query;
            if (!string.IsNullOrEmpty(newPassword))
            {
                query = "UPDATE NguoiDung SET TenHienThi = @Name, Email = @Email, MatKhauHash = @Pass WHERE MaNguoiDung = @Id";
            }
            else
            {
                query = "UPDATE NguoiDung SET TenHienThi = @Name, Email = @Email WHERE MaNguoiDung = @Id";
            }

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.Parameters.AddWithValue("@Name", displayName);
                    cmd.Parameters.AddWithValue("@Email", email ?? "");

                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        cmd.Parameters.AddWithValue("@Pass", HashPassword(newPassword));
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBookInfo(int bookId, string newTitle, string newAuthor, string newDescription)
        {
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Cập nhật thông tin cơ bản trong bảng Sach
                        string updateSach = "UPDATE Sach SET TieuDe = @Title, MoTa = @Desc WHERE MaSach = @Id";
                        using (var cmd = new SqlCommand(updateSach, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@Title", newTitle);
                            cmd.Parameters.AddWithValue("@Desc", newDescription ?? "");
                            cmd.Parameters.AddWithValue("@Id", bookId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Cập nhật Tác giả (Xóa cũ -> Thêm mới)
                        // Bước này quan trọng để đảm bảo tính nhất quán
                        string deleteAuthors = "DELETE FROM Sach_TacGia WHERE MaSach = @Id";
                        using (var cmdDel = new SqlCommand(deleteAuthors, conn, trans))
                        {
                            cmdDel.Parameters.AddWithValue("@Id", bookId);
                            cmdDel.ExecuteNonQuery();
                        }

                        // Thêm lại tác giả mới
                        if (!string.IsNullOrEmpty(newAuthor))
                        {
                            var authors = newAuthor.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var authName in authors)
                            {
                                string nameTrim = authName.Trim();
                                int authorId = 0;

                                // Kiểm tra tác giả đã tồn tại chưa
                                using (var cmdCheck = new SqlCommand("SELECT MaTacGia FROM TacGia WHERE TenTacGia = @Name", conn, trans))
                                {
                                    cmdCheck.Parameters.AddWithValue("@Name", nameTrim);
                                    var res = cmdCheck.ExecuteScalar();
                                    if (res != null) authorId = (int)res;
                                }

                                // Nếu chưa có thì tạo mới
                                if (authorId == 0)
                                {
                                    using (var cmdInsAuth = new SqlCommand("INSERT INTO TacGia (TenTacGia) VALUES (@Name); SELECT CAST(SCOPE_IDENTITY() as int);", conn, trans))
                                    {
                                        cmdInsAuth.Parameters.AddWithValue("@Name", nameTrim);
                                        authorId = (int)cmdInsAuth.ExecuteScalar();
                                    }
                                }

                                // Liên kết sách với tác giả
                                using (var cmdLink = new SqlCommand("INSERT INTO Sach_TacGia (MaSach, MaTacGia) VALUES (@Bid, @Aid)", conn, trans))
                                {
                                    cmdLink.Parameters.AddWithValue("@Bid", bookId);
                                    cmdLink.Parameters.AddWithValue("@Aid", authorId);
                                    cmdLink.ExecuteNonQuery();
                                }
                            }
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Lỗi cập nhật sách: " + ex.Message);
                    }
                }
            }
        }

        // --- Thêm vào class DataManager ---

        public void UpdateUserTheme(int userId, string theme)
        {
            string query = "UPDATE NguoiDung SET Theme = @Theme WHERE MaNguoiDung = @Id";
            ExecuteSimpleNonQuery(query, new[] {
        new SqlParameter("@Theme", theme),
        new SqlParameter("@Id", userId)
    });
        }

        public string GetUserTheme(int userId)
        {
            string query = "SELECT Theme FROM NguoiDung WHERE MaNguoiDung = @Id";
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? result.ToString() : "Light";
                }
            }
        }

        // Helper để chạy query nhanh (nếu chưa có thì thêm vào)
        private void ExecuteSimpleNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Lỗi SQL: " + ex.Message); }
        }

        // ================= QUẢN LÝ MỤC TIÊU ĐỌC SÁCH =================

        // Tạo mục tiêu mới
        public int CreateReadingGoal(int userId, string goalType, int targetValue)
        {
            string query = @"
                INSERT INTO MucTieuDocSach (MaNguoiDung, LoaiMucTieu, GiaTriMucTieu, NgayBatDau, DangHoatDong)
                VALUES (@UserId, @Type, @Value, GETDATE(), 1);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Type", goalType);
                    cmd.Parameters.AddWithValue("@Value", targetValue);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Lấy tất cả mục tiêu đang hoạt động
        public List<ReadingGoal> GetActiveGoals(int userId)
        {
            string query = @"
                SELECT * FROM MucTieuDocSach 
                WHERE MaNguoiDung = @UserId AND DangHoatDong = 1
                ORDER BY NgayBatDau DESC";

            var list = new List<ReadingGoal>();
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ReadingGoal
                            {
                                Id = reader.GetInt32(0),
                                UserId = reader.GetInt32(1),
                                GoalType = reader.GetString(2),
                                TargetValue = reader.GetInt32(3),
                                StartDate = reader.GetDateTime(4),
                                IsActive = reader.GetBoolean(5),
                                CompletedDate = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6)
                            });
                        }
                    }
                }
            }
            return list;
        }

        // Cập nhật hoặc tắt mục tiêu
        public void UpdateGoal(int goalId, bool isActive)
        {
            string query = "UPDATE MucTieuDocSach SET DangHoatDong = @Active WHERE MaMucTieu = @Id";
            ExecuteSimpleNonQuery(query, new[]
            {
                new SqlParameter("@Active", isActive),
                new SqlParameter("@Id", goalId)
            });
        }

        // ================= QUẢN LÝ PHIÊN ĐỌC SÁCH =================

        // Bắt đầu phiên đọc mới
        public int StartReadingSession(int userId, int bookId)
        {
            string query = @"
                INSERT INTO PhienDocSach (MaNguoiDung, MaSach, ThoiGianBatDau, NgayDoc)
                VALUES (@UserId, @BookId, GETDATE(), CAST(GETDATE() AS DATE));
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Kết thúc phiên đọc và tính số phút
        public void EndReadingSession(int sessionId)
        {
            string query = @"
                UPDATE PhienDocSach 
                SET ThoiGianKetThuc = GETDATE(),
                    SoPhutDoc = DATEDIFF(MINUTE, ThoiGianBatDau, GETDATE())
                WHERE MaPhien = @SessionId";

            ExecuteSimpleNonQuery(query, new[] { new SqlParameter("@SessionId", sessionId) });
        }

        // Lấy tổng số phút đọc trong ngày
        public int GetTodayReadingMinutes(int userId)
        {
            string query = @"
                SELECT ISNULL(SUM(SoPhutDoc), 0)
                FROM PhienDocSach
                WHERE MaNguoiDung = @UserId 
                AND NgayDoc = CAST(GETDATE() AS DATE)";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Lấy số cuốn đã đọc trong năm
        public int GetYearlyBooksRead(int userId)
        {
            string query = @"
                SELECT COUNT(DISTINCT MaSach)
                FROM PhienDocSach
                WHERE MaNguoiDung = @UserId 
                AND YEAR(NgayDoc) = YEAR(GETDATE())
                AND SoPhutDoc >= 10"; // Chỉ tính sách đọc ít nhất 10 phút

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // [MỚI] Lấy số cuốn đã đọc trong tháng
        public int GetMonthlyBooksRead(int userId)
        {
            string query = @"
                SELECT COUNT(DISTINCT MaSach)
                FROM PhienDocSach
                WHERE MaNguoiDung = @UserId 
                AND YEAR(NgayDoc) = YEAR(GETDATE())
                AND MONTH(NgayDoc) = MONTH(GETDATE())
                AND SoPhutDoc >= 10"; // Chỉ tính sách đọc ít nhất 10 phút

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Lấy thống kê đọc sách 7 ngày gần nhất
        public List<DailyReadingStats> GetWeeklyStats(int userId)
        {
            string query = @"
                SELECT 
                    NgayDoc,
                    SUM(SoPhutDoc) AS TotalMinutes,
                    COUNT(DISTINCT MaSach) AS BooksRead
                FROM PhienDocSach
                WHERE MaNguoiDung = @UserId
                AND NgayDoc >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE))
                GROUP BY NgayDoc
                ORDER BY NgayDoc DESC";

            var list = new List<DailyReadingStats>();
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new DailyReadingStats
                            {
                                Date = reader.GetDateTime(0),
                                TotalMinutes = reader.GetInt32(1),
                                BooksRead = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            return list;
        }

        // ================= QUẢN LÝ STREAK (CHUỖI NGÀY ĐỌC) =================

        // Cập nhật streak sau mỗi phiên đọc
        public void UpdateReadingStreak(int userId)
        {
            string checkQuery = "SELECT * FROM ChuoiNgayDocSach WHERE MaNguoiDung = @UserId";
            string insertQuery = @"
                INSERT INTO ChuoiNgayDocSach (MaNguoiDung, SoNgayHienTai, SoNgayDaiNhat, NgayDocGanNhat)
                VALUES (@UserId, 1, 1, CAST(GETDATE() AS DATE))";
            
            string updateQuery = @"
                UPDATE ChuoiNgayDocSach
                SET SoNgayHienTai = CASE 
                        WHEN DATEDIFF(DAY, NgayDocGanNhat, CAST(GETDATE() AS DATE)) = 1 THEN SoNgayHienTai + 1
                        WHEN DATEDIFF(DAY, NgayDocGanNhat, CAST(GETDATE() AS DATE)) = 0 THEN SoNgayHienTai
                        ELSE 1
                    END,
                    SoNgayDaiNhat = CASE
                        WHEN DATEDIFF(DAY, NgayDocGanNhat, CAST(GETDATE() AS DATE)) = 1 AND (SoNgayHienTai + 1) > SoNgayDaiNhat THEN SoNgayHienTai + 1
                        ELSE SoNgayDaiNhat
                    END,
                    NgayDocGanNhat = CAST(GETDATE() AS DATE)
                WHERE MaNguoiDung = @UserId";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    bool exists = cmd.ExecuteScalar() != null;

                    if (!exists)
                    {
                        cmd.CommandText = insertQuery;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = updateQuery;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Lấy thông tin streak
        public ReadingStreak GetReadingStreak(int userId)
        {
            string query = "SELECT * FROM ChuoiNgayDocSach WHERE MaNguoiDung = @UserId";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ReadingStreak
                            {
                                UserId = reader.GetInt32(0),
                                CurrentStreak = reader.GetInt32(1),
                                LongestStreak = reader.GetInt32(2),
                                LastReadDate = reader.GetDateTime(3)
                            };
                        }
                    }
                }
            }

            return new ReadingStreak { UserId = userId, CurrentStreak = 0, LongestStreak = 0, LastReadDate = DateTime.Today };
        }

        // ================= QUẢN LÝ NHẮC NHỞ (NOTIFICATIONS) =================

        // Tạo nhắc nhở mới
        public void CreateNotification(int userId, string message)
        {
            string query = @"
                INSERT INTO LichSuNhacNho (MaNguoiDung, ThoiGianNhacNho, NoiDungNhacNho, DaXem)
                VALUES (@UserId, GETDATE(), @Message, 0)";

            ExecuteSimpleNonQuery(query, new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Message", message)
            });
        }

        // Lấy các nhắc nhở chưa đọc
        public List<string> GetUnreadNotifications(int userId)
        {
            string query = @"
                SELECT NoiDungNhacNho 
                FROM LichSuNhacNho 
                WHERE MaNguoiDung = @UserId AND DaXem = 0
                ORDER BY ThoiGianNhacNho DESC";

            var list = new List<string>();
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return list;
        }

        // Đánh dấu tất cả nhắc nhở đã đọc
        public void MarkNotificationsAsRead(int userId)
        {
            string query = "UPDATE LichSuNhacNho SET DaXem = 1 WHERE MaNguoiDung = @UserId";
            ExecuteSimpleNonQuery(query, new[] { new SqlParameter("@UserId", userId) });
        }

        // Kiểm tra xem hôm nay đã đọc chưa (để gửi nhắc nhở)
        public bool HasReadToday(int userId)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM PhienDocSach 
                WHERE MaNguoiDung = @UserId 
                AND NgayDoc = CAST(GETDATE() AS DATE)";

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }
}