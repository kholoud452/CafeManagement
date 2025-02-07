using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalEFProject.Migrations
{
    /// <inheritdoc />
    public partial class alterCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Customer_UserName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_UserName",
                table: "Customers");
        }
    }
}
