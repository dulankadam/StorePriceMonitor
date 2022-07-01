using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StorePriceMonitor.Infastructure.Migrations
{
    public partial class Initialize_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pr");

            migrationBuilder.EnsureSchema(
                name: "msr");

            migrationBuilder.CreateTable(
                name: "PriceSource",
                schema: "msr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TickerList",
                schema: "msr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TickerList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceList",
                schema: "pr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceSourceId = table.Column<int>(type: "int", nullable: false),
                    TickerListId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceList_PriceSource_PriceSourceId",
                        column: x => x.PriceSourceId,
                        principalSchema: "msr",
                        principalTable: "PriceSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceList_TickerList_TickerListId",
                        column: x => x.TickerListId,
                        principalSchema: "msr",
                        principalTable: "TickerList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "msr",
                table: "PriceSource",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Description", "Status", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 1, 15, 35, 50, 846, DateTimeKind.Local).AddTicks(1770), "System Seed", "PRC 1", false, null, null },
                    { 2, new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5602), "System Seed", "PRC 2", false, null, null },
                    { 3, new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5623), "System Seed", "PRC 3", false, null, null },
                    { 4, new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5625), "System Seed", "PRC 4", false, null, null },
                    { 5, new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5627), "System Seed", "PRC 5", false, null, null }
                });

            migrationBuilder.InsertData(
                schema: "msr",
                table: "TickerList",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Description", "Status", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8812), "System Seed", "TICKER 1", false, null, null },
                    { 2, new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8823), "System Seed", "TICKER 2", false, null, null },
                    { 3, new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8825), "System Seed", "TICKER 3", false, null, null },
                    { 4, new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8827), "System Seed", "TICKER 4", false, null, null },
                    { 5, new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8828), "System Seed", "TICKER 5", false, null, null }
                });

            migrationBuilder.InsertData(
                schema: "pr",
                table: "PriceList",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Price", "PriceSourceId", "Status", "TickerListId", "Time", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, null, null, 110m, 1, true, 1, new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(5665), null, null },
                    { 16, null, null, 450m, 1, true, 3, new DateTime(2022, 7, 1, 19, 53, 50, 851, DateTimeKind.Local).AddTicks(7333), null, null },
                    { 17, null, null, 860m, 1, true, 3, new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7334), null, null },
                    { 18, null, null, 540m, 1, true, 3, new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7336), null, null },
                    { 37, null, null, 320m, 2, true, 3, new DateTime(2022, 7, 1, 19, 5, 50, 851, DateTimeKind.Local).AddTicks(7406), null, null },
                    { 41, null, null, 450m, 3, true, 3, new DateTime(2022, 7, 1, 19, 53, 50, 851, DateTimeKind.Local).AddTicks(7413), null, null },
                    { 42, null, null, 860m, 3, true, 3, new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7415), null, null },
                    { 43, null, null, 540m, 4, true, 3, new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7416), null, null },
                    { 47, null, null, 540m, 3, true, 3, new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7423), null, null },
                    { 19, null, null, 220m, 1, true, 4, new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7337), null, null },
                    { 20, null, null, 660m, 1, true, 4, new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7339), null, null },
                    { 21, null, null, 750m, 1, true, 4, new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7341), null, null },
                    { 22, null, null, 540m, 1, true, 4, new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7342), null, null },
                    { 23, null, null, 320m, 1, true, 4, new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7344), null, null },
                    { 24, null, null, 630m, 1, true, 4, new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7345), null, null },
                    { 25, null, null, 530m, 1, true, 4, new DateTime(2022, 7, 1, 19, 5, 50, 851, DateTimeKind.Local).AddTicks(7347), null, null },
                    { 35, null, null, 330m, 4, true, 4, new DateTime(2022, 7, 1, 18, 41, 50, 851, DateTimeKind.Local).AddTicks(7363), null, null },
                    { 44, null, null, 220m, 4, true, 4, new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7418), null, null },
                    { 45, null, null, 660m, 5, true, 4, new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7419), null, null },
                    { 46, null, null, 750m, 5, true, 4, new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7421), null, null },
                    { 48, null, null, 320m, 2, true, 4, new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7424), null, null },
                    { 49, null, null, 630m, 2, true, 4, new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7426), null, null },
                    { 15, null, null, 760m, 1, true, 3, new DateTime(2022, 7, 1, 19, 41, 50, 851, DateTimeKind.Local).AddTicks(7331), null, null },
                    { 34, null, null, 200m, 5, true, 5, new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7361), null, null },
                    { 14, null, null, 530m, 1, true, 3, new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7330), null, null },
                    { 40, null, null, 760m, 2, true, 2, new DateTime(2022, 7, 1, 19, 41, 50, 851, DateTimeKind.Local).AddTicks(7411), null, null },
                    { 2, null, null, 150m, 1, true, 1, new DateTime(2022, 7, 1, 16, 50, 50, 851, DateTimeKind.Local).AddTicks(7297), null, null },
                    { 3, null, null, 140m, 1, true, 1, new DateTime(2022, 7, 1, 17, 5, 50, 851, DateTimeKind.Local).AddTicks(7310), null, null },
                    { 4, null, null, 100m, 1, true, 1, new DateTime(2022, 7, 1, 17, 20, 50, 851, DateTimeKind.Local).AddTicks(7313), null, null },
                    { 5, null, null, 140m, 1, true, 1, new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7315), null, null },
                    { 26, null, null, 110m, 2, true, 1, new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7349), null, null },
                    { 27, null, null, 150m, 3, true, 1, new DateTime(2022, 7, 1, 16, 50, 50, 851, DateTimeKind.Local).AddTicks(7350), null, null },
                    { 28, null, null, 140m, 5, true, 1, new DateTime(2022, 7, 1, 17, 5, 50, 851, DateTimeKind.Local).AddTicks(7352), null, null },
                    { 29, null, null, 100m, 3, true, 1, new DateTime(2022, 7, 1, 17, 20, 50, 851, DateTimeKind.Local).AddTicks(7353), null, null },
                    { 30, null, null, 140m, 2, true, 1, new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7355), null, null },
                    { 6, null, null, 160m, 1, true, 2, new DateTime(2022, 7, 1, 17, 50, 50, 851, DateTimeKind.Local).AddTicks(7317), null, null },
                    { 7, null, null, 130m, 1, true, 2, new DateTime(2022, 7, 1, 18, 5, 50, 851, DateTimeKind.Local).AddTicks(7319), null, null },
                    { 8, null, null, 110m, 1, true, 2, new DateTime(2022, 7, 1, 18, 20, 50, 851, DateTimeKind.Local).AddTicks(7320), null, null },
                    { 9, null, null, 200m, 1, true, 2, new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7322), null, null },
                    { 10, null, null, 330m, 1, true, 2, new DateTime(2022, 7, 1, 18, 41, 50, 851, DateTimeKind.Local).AddTicks(7323), null, null },
                    { 11, null, null, 210m, 1, true, 2, new DateTime(2022, 7, 1, 18, 47, 50, 851, DateTimeKind.Local).AddTicks(7325), null, null },
                    { 12, null, null, 320m, 1, true, 2, new DateTime(2022, 7, 1, 19, 5, 50, 851, DateTimeKind.Local).AddTicks(7327), null, null }
                });

            migrationBuilder.InsertData(
                schema: "pr",
                table: "PriceList",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Price", "PriceSourceId", "Status", "TickerListId", "Time", "UpdatedDate", "UpdatedUser" },
                values: new object[,]
                {
                    { 31, null, null, 160m, 5, true, 2, new DateTime(2022, 7, 1, 17, 50, 50, 851, DateTimeKind.Local).AddTicks(7356), null, null },
                    { 32, null, null, 130m, 5, true, 2, new DateTime(2022, 7, 1, 18, 5, 50, 851, DateTimeKind.Local).AddTicks(7358), null, null },
                    { 33, null, null, 110m, 1, true, 2, new DateTime(2022, 7, 1, 18, 20, 50, 851, DateTimeKind.Local).AddTicks(7359), null, null },
                    { 36, null, null, 210m, 4, true, 2, new DateTime(2022, 7, 1, 18, 47, 50, 851, DateTimeKind.Local).AddTicks(7364), null, null },
                    { 39, null, null, 530m, 1, true, 2, new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7410), null, null },
                    { 13, null, null, 340m, 1, true, 3, new DateTime(2022, 7, 1, 19, 23, 50, 851, DateTimeKind.Local).AddTicks(7328), null, null },
                    { 38, null, null, 340m, 1, true, 5, new DateTime(2022, 7, 1, 19, 23, 50, 851, DateTimeKind.Local).AddTicks(7408), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_PriceSourceId",
                schema: "pr",
                table: "PriceList",
                column: "PriceSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_TickerListId",
                schema: "pr",
                table: "PriceList",
                column: "TickerListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceList",
                schema: "pr");

            migrationBuilder.DropTable(
                name: "PriceSource",
                schema: "msr");

            migrationBuilder.DropTable(
                name: "TickerList",
                schema: "msr");
        }
    }
}
