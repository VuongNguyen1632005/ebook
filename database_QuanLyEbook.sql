USE master;
GO

-- 1. Làm sạch môi trường cũ (Nếu có)
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_ebook')
BEGIN
    PRINT N'Đang xóa database cũ để tạo mới...'
    ALTER DATABASE QL_ebook SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QL_ebook;
END
GO

-- 2. Tạo Database mới
CREATE DATABASE QL_ebook;
GO

USE QL_ebook;
GO

-- =============================================
-- PHẦN 1: TẠO CÁC BẢNG (TABLES)
-- =============================================

-- Bảng Người Dùng (Đã XÓA ràng buộc check mật khẩu phức tạp để tránh lỗi logic)
CREATE TABLE NguoiDung (
    MaNguoiDung INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhauHash NVARCHAR(255) NOT NULL, -- Chỉ lưu chuỗi, việc kiểm tra độ mạnh sẽ làm ở C#
    Email NVARCHAR(100) UNIQUE,
    TenHienThi NVARCHAR(100),
    Theme NVARCHAR(20) DEFAULT 'Light', 
    NgayTao DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE NhaXuatBan (
    MaNhaXuatBan INT IDENTITY(1,1) PRIMARY KEY,
    TenNXB NVARCHAR(100) NOT NULL
);

CREATE TABLE TheLoai (
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE TacGia (
    MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL
);

CREATE TABLE Plugin (
    MaPlugin INT IDENTITY(1,1) PRIMARY KEY,
    TenHienThi NVARCHAR(100) NOT NULL,
    LoaiPlugin NVARCHAR(50),
    BieuTuong NVARCHAR(MAX),
    PhienBan NVARCHAR(20),
    CauHinh NVARCHAR(MAX),
    KichHoat BIT NOT NULL DEFAULT 0
);

CREATE TABLE KeSach (
    MaKeSach INT IDENTITY(1,1) PRIMARY KEY,
    MaNguoiDung INT NOT NULL,
    TenKeSach NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255),
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_KeSach_NguoiDung FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);

CREATE TABLE Sach (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    MaNguoiDung INT NOT NULL,
    MaNhaXuatBan INT NULL,
    TieuDe NVARCHAR(255) NOT NULL,
    MoTa NVARCHAR(MAX),
    MaMD5 VARCHAR(32),
    DuongDanAnhBia NVARCHAR(MAX),
    DinhDang VARCHAR(10),
    KichThuocKB INT,
    TongSoTrang INT,
    DuongDanFile NVARCHAR(MAX) NOT NULL,
    NgayThem DATETIME NOT NULL DEFAULT GETDATE(),
    TrangHienTai INT NOT NULL DEFAULT 0,
    XepHang TINYINT,
    YeuThich BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Sach_NguoiDung FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    CONSTRAINT FK_Sach_NhaXuatBan FOREIGN KEY (MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan)
);

CREATE TABLE ThungRac (
    MaRac INT IDENTITY(1,1) PRIMARY KEY,
    MaSach INT NOT NULL UNIQUE,
    CONSTRAINT FK_ThungRac_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE
);

-- CÁC BẢNG LIÊN KẾT (MANY-TO-MANY)
CREATE TABLE Sach_TacGia (
    MaSach INT NOT NULL,
    MaTacGia INT NOT NULL,
    PRIMARY KEY (MaSach, MaTacGia),
    CONSTRAINT FK_SachTacGia_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE,
    CONSTRAINT FK_SachTacGia_TacGia FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia) ON DELETE CASCADE
);

CREATE TABLE Sach_TheLoai (
    MaSach INT NOT NULL,
    MaTheLoai INT NOT NULL,
    PRIMARY KEY (MaSach, MaTheLoai),
    CONSTRAINT FK_SachTheLoai_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE,
    CONSTRAINT FK_SachTheLoai_TheLoai FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai) ON DELETE CASCADE
);

CREATE TABLE KeSach_Sach (
    MaKeSach INT NOT NULL,
    MaSach INT NOT NULL,
    NgayThemVaoKe DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (MaKeSach, MaSach),
    CONSTRAINT FK_KeSachSach_KeSach FOREIGN KEY (MaKeSach) REFERENCES KeSach(MaKeSach) ON DELETE CASCADE,
    CONSTRAINT FK_KeSachSach_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE
);

-- CÁC BẢNG CHỨC NĂNG ĐỌC SÁCH
CREATE TABLE GhiChu (
    MaGhiChu INT IDENTITY(1,1) PRIMARY KEY,
    MaSach INT NOT NULL,
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
    TenChuong NVARCHAR(255),
    NoiDungTrichDan NVARCHAR(MAX),
    GhiChuCuaNguoiDung NVARCHAR(MAX),
    ViTriCFI NVARCHAR(255),
    PhanTramDoc FLOAT,
    MauSac VARCHAR(7),
    TheTag NVARCHAR(100),
    CONSTRAINT FK_GhiChu_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE
);

CREATE TABLE DanhDauTrang (
    MaDanhDau INT IDENTITY(1,1) PRIMARY KEY,
    MaSach INT NOT NULL,
    NhanDan NVARCHAR(255),
    ViTriCFI NVARCHAR(255),
    PhanTramDoc FLOAT,
    TenChuong NVARCHAR(255),
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_DanhDauTrang_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE
);

CREATE TABLE VT_DocSach (
    MaVTDoc INT IDENTITY(1,1) PRIMARY KEY,
    MaSach INT NOT NULL,
    MaNguoiDung INT NOT NULL,
    SoChap INT NOT NULL DEFAULT 0,
    ViTriTrongChap INT NOT NULL DEFAULT 0,
    NgayCapNhat DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_VTDoc_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE,
    CONSTRAINT FK_VTDoc_NguoiDung FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE,
    CONSTRAINT UK_VTDoc UNIQUE (MaSach, MaNguoiDung)
);

-- CÁC BẢNG THỐNG KÊ & MỤC TIÊU
CREATE TABLE MucTieuDocSach (
    MaMucTieu INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    LoaiMucTieu NVARCHAR(50) NOT NULL,
    GiaTriMucTieu INT NOT NULL,
    NgayBatDau DATE NOT NULL DEFAULT GETDATE(),
    DangHoatDong BIT NOT NULL DEFAULT 1,
    NgayHoanThanh DATE NULL,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);

CREATE TABLE PhienDocSach (
    MaPhien INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    MaSach INT NOT NULL,
    ThoiGianBatDau DATETIME NOT NULL DEFAULT GETDATE(),
    ThoiGianKetThuc DATETIME NULL,
    SoPhutDoc INT NOT NULL DEFAULT 0,
    NgayDoc DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE,
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE
);

CREATE TABLE ChuoiNgayDocSach (
    MaNguoiDung INT PRIMARY KEY,
    SoNgayHienTai INT NOT NULL DEFAULT 0,
    SoNgayDaiNhat INT NOT NULL DEFAULT 0,
    NgayDocGanNhat DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);

CREATE TABLE LichSuNhacNho (
    MaNhacNho INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    ThoiGianNhacNho DATETIME NOT NULL DEFAULT GETDATE(),
    NoiDungNhacNho NVARCHAR(500) NOT NULL,
    DaXem BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);
GO

-- =============================================
-- PHẦN 2: INDEX & TRIGGER
-- =============================================

CREATE INDEX IX_PhienDocSach_NgayDoc ON PhienDocSach(MaNguoiDung, NgayDoc);
CREATE INDEX IX_MucTieuDocSach_Active ON MucTieuDocSach(MaNguoiDung, DangHoatDong);
CREATE INDEX IX_VTDoc_MaSach ON VT_DocSach(MaSach);
CREATE INDEX IX_VTDoc_MaNguoiDung ON VT_DocSach(MaNguoiDung);
GO
