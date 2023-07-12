using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemoAspWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Decimal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cines",
                type: "decimal(9,3)",
                precision: 9,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cines",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,3)",
                oldPrecision: 9,
                oldScale: 3);
        }
    }
}
