using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
        public class HoaDon_ChiTiet
        {
            public int ID { get; set; }
            public int HoaDonID { get; set;}
            public int VeID { get; set; }
            public int DonGiaBan { get; set; }
            public virtual HoaDon HoaDon { get; set; } = null!;
            public virtual Ve Ve { get; set; } = null!;
        }

        [NotMapped] // Dùng để hiển thị lên GridView
        public class DanhSachHoaDon_ChiTiet
        {
            public int ID { get; set; }
            public string TenSuKien { get; set; } = null!;
            public string TenSan { get; set; } = null!;
            public string ViTriGhe { get; set; } = null!;
            public int DonGiaBan { get; set; }
            public int ThanhTien { get; set; }
        }
    }
