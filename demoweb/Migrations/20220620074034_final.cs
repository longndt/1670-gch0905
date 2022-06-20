using Microsoft.EntityFrameworkCore.Migrations;

namespace demoweb.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "41d9e542-81a3-4959-ac7c-2b30879dfa11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "82b9af6d-9efc-4ff1-9c27-4fcc9d07be45");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "8e7ddc5d-7fc0-4da3-993e-2a7ea8442157");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "4f6228e3-ad94-4928-8bfa-093e074548f6");
        }
    }
}
