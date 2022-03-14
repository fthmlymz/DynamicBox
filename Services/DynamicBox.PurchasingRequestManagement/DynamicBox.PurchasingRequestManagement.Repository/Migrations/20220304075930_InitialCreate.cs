using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicBox.PurchasingRequestManagement.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BusinessDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDemands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LdapId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sAMAAccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ObjectGuid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrefferedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkflowId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WorkflowDefinitionId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WorkflowName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    WorkflowVersion = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    StockNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
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
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "MaterialDemandDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalDemand = table.Column<long>(type: "bigint", nullable: false),
                    StockName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaterialDemandId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_MaterialDemandDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemandDetails_MaterialDemandId",
                table: "MaterialDemandDetails",
                column: "MaterialDemandId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemandDetails_ProductId",
                table: "MaterialDemandDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemandHistory_MaterialDemandId",
                table: "MaterialDemandHistory",
                column: "MaterialDemandId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDemands_CompanyId",
                table: "MaterialDemands",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialDemandDetails");

            migrationBuilder.DropTable(
                name: "MaterialDemandHistory");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MaterialDemands");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
