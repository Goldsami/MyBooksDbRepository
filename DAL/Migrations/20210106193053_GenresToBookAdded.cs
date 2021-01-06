using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class GenresToBookAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BookId",
                table: "Genres",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Books_BookId",
                table: "Genres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Books_BookId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_BookId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Genres");
        }
    }
}
