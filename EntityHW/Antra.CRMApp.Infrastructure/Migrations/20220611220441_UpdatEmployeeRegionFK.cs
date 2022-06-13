using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CRMApp.Infrastructure.Migrations
{
    public partial class UpdatEmployeeRegionFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RegionId",
                table: "Employee",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Region_RegionId",
                table: "Employee",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Region_RegionId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_RegionId",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "RegionId",
                table: "Employee",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
