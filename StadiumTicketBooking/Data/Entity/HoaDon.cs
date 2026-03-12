using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
        public class HoaDon
        {
            public int ID { get; set; }
            public int NhanVienID { get; set;}
            public int KhachHangID { get; set; }
            public DateTime NgayLap { get; set; }
            public string? GhiChu { get; set; }
            public virtual KhachHang KhachHang { get; set; } = null!;
            public virtual NhanVien NhanVien { get; set; } = null!;
            public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        }

        [NotMapped] // Dùng để hiển thị lên GridView
        public class DanhSachHoaDon
        {
            public int ID { get; set; }
            public string HoVaTenNhanVien { get; set; } = null!;
            public string HoVaTenKhachHang { get; set; } = null!;
            public DateTime NgayLap { get; set; }
            public string? GhiChu { get; set; }
            public double TongTienHoaDon { get; set; }
            public string XemChiTiet { get; set; } = "Xem chi tiết";
    }
    }
