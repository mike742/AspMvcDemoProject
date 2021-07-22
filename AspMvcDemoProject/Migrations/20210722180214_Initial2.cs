using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspMvcDemoProject.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Code = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducs_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducs_Products_P_Code",
                        column: x => x.P_Code,
                        principalTable: "Products",
                        principalColumn: "P_Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[] { 101, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark's order" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[] { 102, new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy's order" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducs_OrderId",
                table: "OrderProducs",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducs_P_Code",
                table: "OrderProducs",
                column: "P_Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducs");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
