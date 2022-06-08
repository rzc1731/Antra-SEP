using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CRMApp.Infrastructure.Migrations
{
    public partial class EmployeeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TitleOfCourtesy = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(24)", nullable: false),
                    ReportsTo = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
