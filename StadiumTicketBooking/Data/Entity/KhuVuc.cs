using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
    public class KhuVuc
    {
        public int ID { get; set; }
        public int SanVanDongID { get; set; }
        public string TenKhuVuc { get; set; } = null! ;
        public double HeSoGia { get; set; }
        public virtual SanVanDong SanVanDong { get; set; } = null!;
        public virtual ObservableCollectionListSource<Ghe> Ghe { get; } = new();
    }
}