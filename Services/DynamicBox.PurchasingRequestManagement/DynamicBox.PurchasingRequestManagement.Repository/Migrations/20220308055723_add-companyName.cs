using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicBox.PurchasingRequestManagement.Repository.Migrations
{
    public partial class addcompanyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "MaterialDemands",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "MaterialDemands");
        }
    }
}
