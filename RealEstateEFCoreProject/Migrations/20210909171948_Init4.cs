using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateEFCoreProject.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BrokerFullName",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Apartments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrokerId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrokerFullName",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Apartments",
                type: "nvarchar(max)",
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
    }
}
