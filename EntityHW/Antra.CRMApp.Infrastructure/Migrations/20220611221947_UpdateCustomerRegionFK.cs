using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CRMApp.Infrastructure.Migrations
{
    public partial class UpdateCustomerRegionFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_RegionId",
                table: "Customer",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Region_RegionId",
                table: "Customer",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Region_RegionId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_RegionId",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "RegionId",
                table: "Customer",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
