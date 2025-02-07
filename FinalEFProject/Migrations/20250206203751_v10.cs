using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalEFProject.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "usersId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_usersId",
                table: "Orders",
                column: "usersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_usersId",
                table: "Orders",
                column: "usersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_usersId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_usersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "Orders");
        }
    }
}
