using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
    public class Ve
    {
        public int ID { get; set; }
        public int SuKienID { get; set;  }
        public int GheID { get; set; }
        public int GiaVe { get; set; }
        public string TrangThai { get; set; } = "Trống";
        public string? HinhAnh { get; set; } // hình vé vip, vé thường
        public virtual SuKien SuKien { get; set; } = null!;
        public virtual Ghe Ghe { get; set; } = null!;
    }
}