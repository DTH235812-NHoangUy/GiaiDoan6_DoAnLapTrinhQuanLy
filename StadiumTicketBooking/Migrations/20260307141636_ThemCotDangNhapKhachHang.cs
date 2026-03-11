using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StadiumTicketBooking.Migrations
{
    /// <inheritdoc />
    public partial class ThemCotDangNhapKhachHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MatKhau",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenDangNhap",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "TenDangNhap",
                table: "KhachHang");
        }
    }
}
