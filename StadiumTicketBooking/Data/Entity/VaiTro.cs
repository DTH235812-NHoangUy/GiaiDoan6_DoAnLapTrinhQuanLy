using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
    public class VaiTro
    {
        public int ID { get; set; }
        public string TenVaiTro { get; set; } = null! ; // Admin, Nhân viên
        public virtual ObservableCollectionListSource<NhanVien> NhanVien { get; } = new();
    }
}