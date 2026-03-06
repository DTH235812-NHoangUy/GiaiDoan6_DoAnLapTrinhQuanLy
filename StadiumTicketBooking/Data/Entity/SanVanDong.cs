using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
    public class SanVanDong
    {
        public int ID { get; set; }
        public string TenSan { get; set; } = null! ;
        public string? DiaChi { get; set; }
        public string? HinhAnh { get; set; }
        public virtual ObservableCollectionListSource<KhuVuc> KhuVuc { get; } = new();
        public virtual ObservableCollectionListSource<SuKien> SuKien { get; } = new();
    }
}
