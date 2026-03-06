using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace StadiumTicketBooking.Data.Entity
{
    public class StadiumDbContext : DbContext
    {
        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<SanVanDong> SanVanDong { get; set;  }
        public DbSet<KhuVuc> KhuVuc { get; set; }
        public DbSet<Ghe> Ghe { get; set; }
        public DbSet<SuKien> SuKien { get; set; }
        public DbSet<Ve> Ve { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = ConfigurationManager.ConnectionStrings["StadiumConnection"]?.ConnectionString;

                if (string.IsNullOrEmpty(connString))
                {
                    optionsBuilder.UseSqlServer(@"Server=NGUYEN-HOANG-UY\SQLEXPRESS;Database=StadiumTicketBooking;Integrated Security=True;TrustServerCertificate=True");
                }
                else
                {
                    optionsBuilder.UseSqlServer(connString);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Cấu hình bảng Ve: Chặn xóa dây chuyền gây lỗi vòng lặp
            modelBuilder.Entity<Ve>()
                .HasOne(v => v.SuKien)
                .WithMany(sk => sk.Ve)
                .HasForeignKey(v => v.SuKienID)
                .OnDelete(DeleteBehavior.Restrict); // Đổi Cascade thành Restrict

            modelBuilder.Entity<Ve>()
                .HasOne(v => v.Ghe)
                .WithMany()
                .HasForeignKey(v => v.GheID)
                .OnDelete(DeleteBehavior.Restrict);

            // 2. Cấu hình bảng HoaDon_ChiTiet: Chặn xóa khi đã có dữ liệu giao dịch
            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasOne(ct => ct.Ve)
                .WithMany()
                .HasForeignKey(ct => ct.VeID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.HoaDon_ChiTiet)
                .HasForeignKey(ct => ct.HoaDonID)
                .OnDelete(DeleteBehavior.Cascade); // Xóa hóa đơn thì xóa chi tiết hóa đơn là hợp lý

            base.OnModelCreating(modelBuilder);
        }
    }
}