using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAproject.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fiyat",
                table: "Products",
                newName: "fiyat");

            migrationBuilder.AlterColumn<decimal>(
                name: "fiyat",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fiyat",
                table: "Products",
                newName: "Fiyat");

            migrationBuilder.AlterColumn<double>(
                name: "Fiyat",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
