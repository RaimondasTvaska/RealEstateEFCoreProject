using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateEFCoreProject.Migrations
{
    public partial class CompanyApartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company_Id",
                table: "Apartments",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Broker_Id",
                table: "Apartments",
                newName: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_CompanyId",
                table: "Apartments",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Companies_CompanyId",
                table: "Apartments",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Companies_CompanyId",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_CompanyId",
                table: "Apartments");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Apartments",
                newName: "Company_Id");

            migrationBuilder.RenameColumn(
                name: "BrokerId",
                table: "Apartments",
                newName: "Broker_Id");
        }
    }
}
