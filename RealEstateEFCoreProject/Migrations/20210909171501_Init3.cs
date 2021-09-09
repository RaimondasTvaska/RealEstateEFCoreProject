using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateEFCoreProject.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Brokers");

            migrationBuilder.AddColumn<int>(
                name: "BrokerId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BrokerId",
                table: "Companies",
                column: "BrokerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Brokers_BrokerId",
                table: "Companies",
                column: "BrokerId",
                principalTable: "Brokers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Brokers_BrokerId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_BrokerId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "BrokerId",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Brokers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
