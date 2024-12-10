using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Destinations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
