using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Solution.Migrations
{
    public partial class OK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_USERID",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "USERID",
                table: "Posts",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_USERID",
                table: "Posts",
                newName: "IX_Posts_userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_userID",
                table: "Posts",
                column: "userID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_userID",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Posts",
                newName: "USERID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_userID",
                table: "Posts",
                newName: "IX_Posts_USERID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_USERID",
                table: "Posts",
                column: "USERID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
