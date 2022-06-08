using Microsoft.EntityFrameworkCore.Migrations;

namespace web3.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Laptop");

            migrationBuilder.AddColumn<string>(
                name: "Categoryid",
                table: "Mobile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Laptop",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_Categoryid",
                table: "Mobile",
                column: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobile_Category_Categoryid",
                table: "Mobile",
                column: "Categoryid",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mobile_Category_Categoryid",
                table: "Mobile");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Mobile_Categoryid",
                table: "Mobile");

            migrationBuilder.DropColumn(
                name: "Categoryid",
                table: "Mobile");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Laptop");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Laptop",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
