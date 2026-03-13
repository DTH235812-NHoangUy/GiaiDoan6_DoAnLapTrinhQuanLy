USE StadiumTicketBooking;
GO

-------------------------------------------------
-- 0) XÓA RÀNG BUỘC UNIQUE CŨ NẾU ĐÃ TẠO
-------------------------------------------------
IF EXISTS (
    SELECT 1
    FROM sys.key_constraints
    WHERE name = 'UQ_Ve_SuKien_Ghe'
)
BEGIN
    ALTER TABLE Ve DROP CONSTRAINT UQ_Ve_SuKien_Ghe;
END
GO

IF EXISTS (
    SELECT 1
    FROM sys.key_constraints
    WHERE name = 'UQ_HoaDonChiTiet_Ve'
)
BEGIN
    ALTER TABLE HoaDon_ChiTiet DROP CONSTRAINT UQ_HoaDonChiTiet_Ve;
END
GO

-------------------------------------------------
-- 1) XÓA DỮ LIỆU CŨ
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
-- 2) RESET IDENTITY
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

-------------------------------------------------
-- 3) VAI TRÒ
-------------------------------------------------
INSERT INTO VaiTro (TenVaiTro)
VALUES
(N'Admin'),
(N'NhanVien');
GO

-------------------------------------------------
-- 4) NHÂN VIÊN
-------------------------------------------------
INSERT INTO NhanVien (VaiTroID, HoVaTen, TenDangNhap, MatKhau, DienThoai, HinhAnh)
VALUES
(1, N'Quản trị hệ thống', N'admin',     N'123', N'0909000001', N'anh1.jpg'),
(2, N'Nhân viên bán vé 1', N'nhanvien1', N'123', N'0909000002', N'anh1.jpg'),
(2, N'Nhân viên bán vé 2', N'nhanvien2', N'123', N'0909000003', N'anh1.jpg');
GO

-------------------------------------------------
-- 5) KHÁCH HÀNG
-------------------------------------------------
INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi)
VALUES
(N'Khách hàng 1', N'0911111111', N'Hà Nội'),
(N'Khách hàng 2', N'0922222222', N'Hải Phòng'),
(N'Khách hàng 3', N'0933333333', N'Đà Nẵng'),
(N'Khách hàng 4', N'0944444444', N'TP.HCM'),
(N'Khách hàng 5', N'0955555555', N'Cần Thơ');
GO

-------------------------------------------------
-- 6) SÂN VẬN ĐỘNG
-------------------------------------------------
INSERT INTO SanVanDong (TenSan, DiaChi, HinhAnh)
VALUES
(N'Mỹ Đình', N'Hà Nội', N'mydinh.jpg'),
(N'Thống Nhất', N'TP.HCM', N'thongnhat.jpg');
GO

-------------------------------------------------
-- 7) SỰ KIỆN
-------------------------------------------------
INSERT INTO SuKien (SanVanDongID, TenSuKien, ThoiGian, GiaCoBan)
VALUES
(1, N'Việt Nam vs Thái Lan',    '2026-03-20 19:30:00', 300000),
(1, N'Hà Nội FC vs Hải Phòng',  '2026-03-25 18:00:00', 250000),
(2, N'Việt Nam vs Indonesia',   '2026-04-01 20:00:00', 400000),
(1, N'Hà Nội FC vs Sài Gòn FC', '2026-03-26 19:00:00', 280000);
GO

-------------------------------------------------
-- 8) KHU VỰC
-------------------------------------------------
INSERT INTO KhuVuc (SanVanDongID, TenKhuVuc, HeSoGia)
VALUES
(1, N'Khu A', 1.20),
(1, N'Khu B', 1.00),
(1, N'Khu C', 0.80),
(2, N'Khu A', 1.10),
(2, N'Khu B', 1.00);
GO

-------------------------------------------------
-- 9) GHẾ
-------------------------------------------------
INSERT INTO Ghe (KhuVucID, SoGhe)
VALUES
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
(5, N'B02');
GO

-------------------------------------------------
-- 10) VÉ
-------------------------------------------------
INSERT INTO Ve (SuKienID, GheID, GiaVe, TrangThai, HinhAnh)
VALUES
-- Sự kiện 1
(1, 1, 360000, N'Trống', N'anhvephothong.jpg'),
(1, 2, 360000, N'Trống', N'anhvephothong.jpg'),
(1, 3, 360000, N'Trống', N'anhvephothong.jpg'),
(1, 4, 300000, N'Trống', N'anhvephothong.jpg'),
(1, 5, 300000, N'Trống', N'anhvephothong.jpg'),
(1, 6, 300000, N'Trống', N'anhvephothong.jpg'),
(1, 7, 240000, N'Trống', N'anhvephothong.jpg'),
(1, 8, 240000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 2
(2, 1, 300000, N'Trống', N'anhvephothong.jpg'),
(2, 2, 300000, N'Trống', N'anhvephothong.jpg'),
(2, 4, 250000, N'Trống', N'anhvephothong.jpg'),
(2, 5, 250000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 3
(3, 9, 440000, N'Trống', N'anhvephothong.jpg'),
(3, 10, 440000, N'Trống', N'anhvephothong.jpg'),
(3, 11, 400000, N'Trống', N'anhvephothong.jpg'),
(3, 12, 400000, N'Trống', N'anhvephothong.jpg'),

-- Sự kiện 4
(4, 1, 336000, N'Trống', N'anhvephothong.jpg'),
(4, 2, 336000, N'Trống', N'anhvephothong.jpg'),
(4, 4, 280000, N'Trống', N'anhvephothong.jpg'),
(4, 5, 280000, N'Trống', N'anhvephothong.jpg');
GO

-------------------------------------------------
-- 11) HÓA ĐƠN MẪU
-------------------------------------------------
INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap, GhiChu)
VALUES
(2, 1, '2026-03-12 08:30:00', N'Hóa đơn 1 vé'),
(2, 2, '2026-03-12 09:15:00', N'Hóa đơn 2 vé'),
(3, 3, '2026-03-12 10:00:00', N'Hóa đơn 1 vé'),
(3, 4, '2026-03-12 10:45:00', N'Hóa đơn 2 vé');
GO

-------------------------------------------------
-- 12) HÓA ĐƠN CHI TIẾT MẪU
-------------------------------------------------
INSERT INTO HoaDon_ChiTiet (HoaDonID, VeID, DonGiaBan)
VALUES
(1, 1, 360000),
(2, 3, 360000),
(2, 4, 300000),
(3, 6, 300000),
(4, 14, 440000),
(4, 16, 400000);
GO

-------------------------------------------------
-- 13) ĐỒNG BỘ TRẠNG THÁI VÉ
-------------------------------------------------
UPDATE Ve
SET TrangThai = N'Trống';

UPDATE Ve
SET TrangThai = N'Đã bán'
WHERE ID IN (SELECT VeID FROM HoaDon_ChiTiet);
GO

-------------------------------------------------
-- 14) THÊM RÀNG BUỘC CHỐNG TRÙNG
-------------------------------------------------
ALTER TABLE Ve
ADD CONSTRAINT UQ_Ve_SuKien_Ghe UNIQUE (SuKienID, GheID);
GO

ALTER TABLE HoaDon_ChiTiet
ADD CONSTRAINT UQ_HoaDonChiTiet_Ve UNIQUE (VeID);
GO

-------------------------------------------------
-- 15) KIỂM TRA DỮ LIỆU
-------------------------------------------------
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