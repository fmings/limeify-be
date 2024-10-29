using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace limeify_be.Migrations
{
    /// <inheritdoc />
    public partial class PlaylistCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Playlists_CategoryId",
                table: "Playlists",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Categories_CategoryId",
                table: "Playlists",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Categories_CategoryId",
                table: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_CategoryId",
                table: "Playlists");
        }
    }
}
