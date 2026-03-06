using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumTicketBooking.Data.Entity
{
    public class Ghe
    {
        public int ID { get; set; }
        public int KhuVucID { get; set; }
        public string SoGhe { get; set; } = null!;
        public virtual KhuVuc KhuVuc { get; set; } =null!;
    }
}