using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicBox.PurchasingRequestManagement.Repository.Migrations
{
    public partial class virtualadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalCount",
                table: "MaterialLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCount",
                table: "MaterialDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCount",
                table: "MaterialDemandHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCount",
                table: "MaterialDemandDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCount",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCount",
                table: "MaterialLists");

            migrationBuilder.DropColumn(
                name: "TotalCount",
                table: "MaterialDemands");

            migrationBuilder.DropColumn(
                name: "TotalCount",
                table: "MaterialDemandHistory");

            migrationBuilder.DropColumn(
                name: "TotalCount",
                table: "MaterialDemandDetails");

            migrationBuilder.DropColumn(
                name: "TotalCount",
                table: "Companies");
        }
    }
}
