using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieFlix_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "tb_movie");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "tb_movie",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tb_movie",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Synopsis",
                table: "tb_movie",
                newName: "synopsis");

            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "tb_movie",
                newName: "subTitle");

            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "tb_movie",
                newName: "imgUrl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_movie",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "tb_movie",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subTitle",
                table: "tb_movie",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_movie",
                table: "tb_movie",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_movie",
                table: "tb_movie");

            migrationBuilder.RenameTable(
                name: "tb_movie",
                newName: "Movies");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "Movies",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "synopsis",
                table: "Movies",
                newName: "Synopsis");

            migrationBuilder.RenameColumn(
                name: "subTitle",
                table: "Movies",
                newName: "SubTitle");

            migrationBuilder.RenameColumn(
                name: "imgUrl",
                table: "Movies",
                newName: "ImgUrl");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Movies",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SubTitle",
                table: "Movies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
