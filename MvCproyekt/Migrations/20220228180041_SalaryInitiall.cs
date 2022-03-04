using Microsoft.EntityFrameworkCore.Migrations;

namespace MvCproyekt.Migrations
{
    public partial class SalaryInitiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "Salariys");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Salariys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Salariys",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Salariys",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
