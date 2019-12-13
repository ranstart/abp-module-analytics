using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ran.Analytics.Migrations
{
    public partial class modified_visitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "AnalyticsVisitors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AnalyticsVisitors");
        }
    }
}
