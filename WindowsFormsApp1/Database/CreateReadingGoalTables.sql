-- T?o b?ng M?c tiêu ð?c sách (Goals)
CREATE TABLE MucTieuDocSach (
    MaMucTieu INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    LoaiMucTieu NVARCHAR(50) NOT NULL, -- 'DAILY_MINUTES' ho?c 'YEARLY_BOOKS'
    GiaTriMucTieu INT NOT NULL, -- 30 phút ho?c 12 cu?n
    NgayBatDau DATE NOT NULL DEFAULT GETDATE(),
    DangHoatDong BIT NOT NULL DEFAULT 1,
    NgayHoanThanh DATE NULL,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);

-- T?o b?ng Phiên ð?c sách (Reading Sessions)
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

-- T?o b?ng Streak (Chu?i ngày ð?c liên t?c)
CREATE TABLE ChuoiNgayDocSach (
    MaNguoiDung INT PRIMARY KEY,
    SoNgayHienTai INT NOT NULL DEFAULT 0,
    SoNgayDaiNhat INT NOT NULL DEFAULT 0,
    NgayDocGanNhat DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);

-- T?o b?ng L?ch s? nh?c nh?
CREATE TABLE LichSuNhacNho (
    MaNhacNho INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    ThoiGianNhacNho DATETIME NOT NULL DEFAULT GETDATE(),
    NoiDungNhacNho NVARCHAR(500) NOT NULL,
    DaXem BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung) ON DELETE CASCADE
);

-- Index ð? t?i ýu truy v?n
CREATE INDEX IX_PhienDocSach_NgayDoc ON PhienDocSach(MaNguoiDung, NgayDoc);
CREATE INDEX IX_MucTieuDocSach_Active ON MucTieuDocSach(MaNguoiDung, DangHoatDong);
