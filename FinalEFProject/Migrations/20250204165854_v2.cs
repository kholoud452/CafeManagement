using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalEFProject.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Stock = table.Column<int>(type: "int", nullable: true),
                    Prod_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Prod_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Insert = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Update = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Delete = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
