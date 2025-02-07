using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalEFProject.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_Phone",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Customer_UserName",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Customer_Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_Phone",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Customer_Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Customer_UserName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
