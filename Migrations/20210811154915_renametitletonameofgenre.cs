using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class renametitletonameofgenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Genres",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "Title");
        }
    }
}
