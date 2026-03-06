using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
    public class NhanVien
    {
        public int ID { get; set; }
        public int VaiTroID { get; set; }
        public string HoVaTen { get; set; } = null! ;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? HinhAnh { get; set; } // Lưu tên file ảnh

        public virtual VaiTro VaiTro { get; set; } = null!;
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
