using Microsoft.EntityFrameworkCore.Migrations;

namespace MvCproyekt.Migrations
{
    public partial class ii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salariys_SalaryId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "SalaryId",
                table: "Employees",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salariys_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salariys",
                principalColumn: "SalaryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salariys_SalaryId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "SalaryId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salariys_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salariys",
                principalColumn: "SalaryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
