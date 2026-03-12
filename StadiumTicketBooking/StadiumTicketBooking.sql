-- ========================================================
-- ĐỒ ÁN: QUẢN LÝ SÂN VẬN ĐỘNG - ĐẶT VÉ
-- Database: StadiumTicketBooking
-- ========================================================

CREATE DATABASE StadiumTicketBooking;
GO

USE StadiumTicketBooking;
GO

-----------------------------------------------------------
-- 1. NHÓM DANH MỤC (MASTER DATA)
-----------------------------------------------------------

CREATE TABLE VaiTro (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenVaiTro NVARCHAR(100) NOT NULL
);

CREATE TABLE NhanVien (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    VaiTroID INT NOT NULL,
    HoVaTen NVARCHAR(200) NOT NULL,
    TenDangNhap NVARCHAR(100) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL,
    DienThoai NVARCHAR(20),
    HinhAnh NVARCHAR(255),
    CONSTRAINT FK_NhanVien_VaiTro
        FOREIGN KEY (VaiTroID) REFERENCES VaiTro(ID)
);

CREATE TABLE KhachHang (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    HoVaTen NVARCHAR(200) NOT NULL,
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

CREATE TABLE SanVanDong (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenSan NVARCHAR(200) NOT NULL,
    DiaChi NVARCHAR(255),
    HinhAnh NVARCHAR(255)
);

CREATE TABLE SuKien (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    SanVanDongID INT NOT NULL,
    TenSuKien NVARCHAR(200) NOT NULL,
    ThoiGian DATETIME NOT NULL,
    GiaCoBan INT NOT NULL CHECK (GiaCoBan >= 0),
    CONSTRAINT FK_SuKien_SanVanDong
        FOREIGN KEY (SanVanDongID) REFERENCES SanVanDong(ID)
);

CREATE TABLE KhuVuc (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    SanVanDongID INT NOT NULL,
    TenKhuVuc NVARCHAR(100) NOT NULL,
    HeSoGia FLOAT NOT NULL CHECK (HeSoGia > 0),
    CONSTRAINT FK_KhuVuc_SanVanDong
        FOREIGN KEY (SanVanDongID) REFERENCES SanVanDong(ID)
);

CREATE TABLE Ghe (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    KhuVucID INT NOT NULL,
    SoGhe NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_Ghe_KhuVuc
        FOREIGN KEY (KhuVucID) REFERENCES KhuVuc(ID),
    CONSTRAINT UQ_Ghe_KhuVuc_SoGhe UNIQUE (KhuVucID, SoGhe)
);

CREATE TABLE Ve (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    SuKienID INT NOT NULL,
    GheID INT NOT NULL,
    GiaVe INT NOT NULL CHECK (GiaVe >= 0),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Trống'
        CHECK (TrangThai IN (N'Trống', N'Đã đặt', N'Đã bán')),
    HinhAnh NVARCHAR(255),
    CONSTRAINT FK_Ve_SuKien
        FOREIGN KEY (SuKienID) REFERENCES SuKien(ID),
    CONSTRAINT FK_Ve_Ghe
        FOREIGN KEY (GheID) REFERENCES Ghe(ID),
    CONSTRAINT UQ_Ve_SuKien_Ghe UNIQUE (SuKienID, GheID)
);

-----------------------------------------------------------
-- 2. NHÓM GIAO DỊCH (TRANSACTIONS)
-----------------------------------------------------------

CREATE TABLE HoaDon (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    NhanVienID INT NOT NULL,
    KhachHangID INT NOT NULL,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    GhiChu NVARCHAR(255),
    CONSTRAINT FK_HoaDon_NhanVien
        FOREIGN KEY (NhanVienID) REFERENCES NhanVien(ID),
    CONSTRAINT FK_HoaDon_KhachHang
        FOREIGN KEY (KhachHangID) REFERENCES KhachHang(ID)
);

CREATE TABLE HoaDon_ChiTiet (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    HoaDonID INT NOT NULL,
    VeID INT NOT NULL,
    DonGiaBan INT NOT NULL CHECK (DonGiaBan >= 0),
    CONSTRAINT FK_HoaDon_ChiTiet_HoaDon
        FOREIGN KEY (HoaDonID) REFERENCES HoaDon(ID) ON DELETE CASCADE,
    CONSTRAINT FK_HoaDon_ChiTiet_Ve
        FOREIGN KEY (VeID) REFERENCES Ve(ID)
);

-----------------------------------------------------------
-- 3. DỮ LIỆU MẪU (DEMO CHUYÊN NGHIỆP)
-----------------------------------------------------------

-- 3.1 Vai trò
INSERT INTO VaiTro (TenVaiTro) VALUES
(N'Admin'),
(N'Nhân viên bán vé'),
(N'Quản lý sân');
GO

-- 3.2 Nhân viên
INSERT INTO NhanVien (VaiTroID, HoVaTen, TenDangNhap, MatKhau, DienThoai, HinhAnh) VALUES
(1, N'Nguyễn Quản Trị', N'admin',     N'123', N'0909000001', N'anh1.jpg'),
(2, N'Trần Nhân Viên', N'nhanvien1', N'123', N'0909000002', N'anh1.jpg'),
(3, N'Lê Thu Ngân',    N'ngan',      N'123', N'0909000003', N'anh1.jpg');
GO

-- 3.3 Khách hàng
INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi) VALUES
(N'Phạm Văn An',      N'0911111111', N'Hà Nội'),
(N'Nguyễn Thị Bình',  N'0922222222', N'Hải Phòng'),
(N'Lê Văn Cường',     N'0933333333', N'Đà Nẵng'),
(N'Trần Thị Dung',    N'0944444444', N'TP.HCM'),
(N'Hoàng Minh Khoa',  N'0955555555', N'Cần Thơ');
GO

-- 3.4 Sân vận động
INSERT INTO SanVanDong (TenSan, DiaChi, HinhAnh) VALUES
(N'Mỹ Đình',    N'Hà Nội',  N'mydinh.jpg'),
(N'Thống Nhất', N'TP.HCM',  N'thongnhat.jpg');
GO

-- 3.5 Sự kiện
INSERT INTO SuKien (SanVanDongID, TenSuKien, ThoiGian, GiaCoBan) VALUES
(1, N'U23 Việt Nam vs U23 Thái Lan', '2026-03-20 19:30:00', 300000),
(1, N'CLB Hà Nội vs Hải Phòng',      '2026-03-25 18:00:00', 250000),
(2, N'Việt Nam vs Indonesia',        '2026-04-01 20:00:00', 400000),
(2, N'CLB TP.HCM vs Bình Dương',     '2026-04-10 18:30:00', 280000);
GO

-- 3.6 Khu vực
INSERT INTO KhuVuc (SanVanDongID, TenKhuVuc, HeSoGia) VALUES
(1, N'Khán Đài A', 1.2),
(1, N'Khán Đài B', 1.0),
(1, N'Khán Đài C', 0.8),
(2, N'Khán Đài A', 1.1),
(2, N'Khán Đài B', 1.0),
(2, N'Khán Đài C', 0.9);
GO

-- 3.7 Ghế
INSERT INTO Ghe (KhuVucID, SoGhe) VALUES
(1, N'A01'),
(1, N'A02'),
(1, N'A03'),
(2, N'B01'),
(2, N'B02'),
(2, N'B03'),
(3, N'C01'),
(3, N'C02'),
(4, N'A01'),
(4, N'A02'),
(5, N'B01'),
(5, N'B02'),
(6, N'C01'),
(6, N'C02');
GO

-- 3.8 Vé
-- Có cả vé Trống và Đã bán để test frmVe, frmDatVe, frmHoaDon
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh) VALUES
-- Sự kiện 1 - Mỹ Đình
(1, 1, 360000, N'Đã bán', N'anhvevip.jng'),
(1, 2, 360000, N'Trống',  N'anhvevip.jng'),
(1, 3, 360000, N'Đã bán', N'anhvevip.jng'),
(1, 4, 300000, N'Đã bán', N'anhvephothong.jng'),
(1, 5, 300000, N'Trống',  N'anhvephothong.jng'),
(1, 6, 300000, N'Đã bán', N'anhvephothong.jng'),
(1, 7, 240000, N'Trống',  N'anhvephothong.jng'),
(1, 8, 240000, N'Trống',  N'anhvephothong.jng'),

-- Sự kiện 2 - Mỹ Đình
(2, 1, 300000, N'Trống', N'anhvephothong.jng'),
(2, 2, 300000, N'Trống', N'anhvephothong.jng'),
(2, 4, 250000, N'Trống', N'anhvephothong.jng'),
(2, 5, 250000, N'Trống', N'anhvephothong.jng'),

-- Sự kiện 3 - Thống Nhất
(3, 9,  440000, N'Trống',  N'anhvevip.jng'),
(3, 10, 440000, N'Đã bán', N'anhvevip.jng'),
(3, 11, 400000, N'Trống',  N'anhvephothong.jng'),
(3, 12, 400000, N'Đã bán', N'anhvephothong.jng'),

-- Sự kiện 4 - Thống Nhất
(4, 9,  308000, N'Trống', N'anhvephothong.jng'),
(4, 10, 308000, N'Trống', N'anhvephothong.jng'),
(4, 13, 252000, N'Trống', N'anhvephothong.jng'),
(4, 14, 252000, N'Trống', N'anhvephothong.jng');
GO

-- 3.9 Hóa đơn
-- Có cả hóa đơn 1 vé và nhiều vé
INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap, GhiChu) VALUES
(2, 1, '2026-03-12 08:30:00', N'Hóa đơn 1 vé'),
(2, 2, '2026-03-12 09:15:00', N'Hóa đơn 2 vé'),
(3, 3, '2026-03-12 10:00:00', N'Hóa đơn 1 vé'),
(3, 4, '2026-03-12 10:45:00', N'Hóa đơn 2 vé');
GO

-- 3.10 Hóa đơn chi tiết
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan) VALUES
(1, 1, 360000),
(2, 3, 360000),
(2, 4, 300000),
(3, 6, 300000),
(4, 14, 440000),
(4, 16, 400000);
GO

-----------------------------------------------------------
-- 4. SELECT KIỂM TRA
-----------------------------------------------------------
SELECT * FROM VaiTro;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
SELECT * FROM SanVanDong;
SELECT * FROM SuKien;
SELECT * FROM KhuVuc;
SELECT * FROM Ghe;
SELECT * FROM Ve ORDER BY SuKienID, GheID;
SELECT * FROM HoaDon ORDER BY ID;
SELECT * FROM HoaDon_ChiTiet ORDER BY HoaDonID, ID;
GO
-------------------------------------------------
-- 5 XÓA DỮ LIỆU CŨ
-------------------------------------------------
DELETE FROM HoaDon_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM Ve;
DELETE FROM Ghe;
DELETE FROM KhuVuc;
DELETE FROM SuKien;
DELETE FROM KhachHang;
DELETE FROM NhanVien;
DELETE FROM VaiTro;
DELETE FROM SanVanDong;
GO

-------------------------------------------------
-- 6 RESET IDENTITY
-------------------------------------------------
DBCC CHECKIDENT ('HoaDon_ChiTiet', RESEED, 0);
DBCC CHECKIDENT ('HoaDon', RESEED, 0);
DBCC CHECKIDENT ('Ve', RESEED, 0);
DBCC CHECKIDENT ('Ghe', RESEED, 0);
DBCC CHECKIDENT ('KhuVuc', RESEED, 0);
DBCC CHECKIDENT ('SuKien', RESEED, 0);
DBCC CHECKIDENT ('KhachHang', RESEED, 0);
DBCC CHECKIDENT ('NhanVien', RESEED, 0);
DBCC CHECKIDENT ('VaiTro', RESEED, 0);
DBCC CHECKIDENT ('SanVanDong', RESEED, 0);
GO
