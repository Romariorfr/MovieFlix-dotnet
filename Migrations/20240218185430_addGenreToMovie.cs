using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieFlix_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class addGenreToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_movie_Genre_GenreId",
                table: "tb_movie");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_movie_Genre_GenreId",
                table: "tb_movie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_movie_Genre_GenreId",
                table: "tb_movie");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_movie_Genre_GenreId",
                table: "tb_movie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id");
        }
    }
}
