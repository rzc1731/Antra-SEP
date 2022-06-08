using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CRMApp.Infrastructure.Migrations
{
    public partial class ProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shipper",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shipper",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shipper",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shipper",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)");
        }
    }
}
