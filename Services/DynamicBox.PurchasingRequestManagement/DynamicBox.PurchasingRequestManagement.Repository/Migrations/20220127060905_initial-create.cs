using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicBox.PurchasingRequestManagement.Repository.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialLists",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialStockNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDemands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDemands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialDemands_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDemandDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialDemandId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDemandDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialDemandDetails_MaterialDemands_MaterialDemandId",
                        column: x => x.MaterialDemandId,
                        principalTable: "MaterialDemands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDemandHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefinationId = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    WorkflowStatus = table.Column<int>(type: "int", nullable: false),
                    CorrelationId = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    ContextType = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    ContextId = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    LastExecutedAt = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    CancelledAt = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    FaultedAt = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", precision: 450, nullable: false),
                    LastExecutedActivityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefinationVersionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDemandId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDemandHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialDemandHistory_MaterialDemands_MaterialDemandId",
                        column: x => x.MaterialDemandId,
                        principalTable: "MaterialDemands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemandDetails_MaterialDemandId",
                table: "MaterialDemandDetails",
                column: "MaterialDemandId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemandHistory_MaterialDemandId",
                table: "MaterialDemandHistory",
                column: "MaterialDemandId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemands_CompanyId",
                table: "MaterialDemands",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialDemandDetails");

            migrationBuilder.DropTable(
                name: "MaterialDemandHistory");

            migrationBuilder.DropTable(
                name: "MaterialLists");

            migrationBuilder.DropTable(
                name: "MaterialDemands");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
