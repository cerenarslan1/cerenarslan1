using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAproject.Migrations
{
    public partial class mgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModelAd",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelAd",
                table: "Products");
        }
    }
}
