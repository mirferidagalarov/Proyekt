using Microsoft.EntityFrameworkCore.Migrations;

namespace MvCproyekt.Migrations
{
    public partial class SalaryInitiall1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salariys_Years_YearsId",
                table: "Salariys");

            migrationBuilder.RenameColumn(
                name: "YearsId",
                table: "Salariys",
                newName: "YearId");

            migrationBuilder.RenameIndex(
                name: "IX_Salariys_YearsId",
                table: "Salariys",
                newName: "IX_Salariys_YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salariys_Years_YearId",
                table: "Salariys",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "YearId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salariys_Years_YearId",
                table: "Salariys");

            migrationBuilder.RenameColumn(
                name: "YearId",
                table: "Salariys",
                newName: "YearsId");

            migrationBuilder.RenameIndex(
                name: "IX_Salariys_YearId",
                table: "Salariys",
                newName: "IX_Salariys_YearsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salariys_Years_YearsId",
                table: "Salariys",
                column: "YearsId",
                principalTable: "Years",
                principalColumn: "YearId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
