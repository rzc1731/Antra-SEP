using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CRMApp.Infrastructure.Migrations
{
    public partial class updateSupplierRegionFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Supplier",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_RegionId",
                table: "Supplier",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Region_RegionId",
                table: "Supplier",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Region_RegionId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_RegionId",
                table: "Supplier");

            migrationBuilder.AlterColumn<string>(
                name: "RegionId",
                table: "Supplier",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
