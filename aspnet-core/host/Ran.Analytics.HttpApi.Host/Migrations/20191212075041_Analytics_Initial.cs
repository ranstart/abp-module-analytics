using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ran.Analytics.Migrations
{
    public partial class Analytics_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalyticsVisitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClientIpAddress = table.Column<string>(type: "varchar(15)", nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    OnTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Referrer = table.Column<string>(maxLength: 256, nullable: true),
                    ProviderKey = table.Column<Guid>(nullable: false),
                    ProviderName = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyticsVisitors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalyticsVisitors_ProviderName_ProviderKey_OnTime",
                table: "AnalyticsVisitors",
                columns: new[] { "ProviderName", "ProviderKey", "OnTime" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalyticsVisitors");
        }
    }
}
