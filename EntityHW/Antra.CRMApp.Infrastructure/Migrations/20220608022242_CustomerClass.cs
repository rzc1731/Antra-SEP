using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CRMApp.Infrastructure.Migrations
{
    public partial class CustomerClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(24)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
