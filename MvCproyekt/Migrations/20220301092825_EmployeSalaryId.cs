using Microsoft.EntityFrameworkCore.Migrations;

namespace MvCproyekt.Migrations
{
    public partial class EmployeSalaryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salariys_Employees_EmployeeId",
                table: "Salariys");

            migrationBuilder.DropIndex(
                name: "IX_Salariys_EmployeeId",
                table: "Salariys");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Salariys");

            migrationBuilder.AddColumn<int>(
                name: "SalaryId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalaryId",
                table: "Employees",
                column: "SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Salariys_SalaryId",
                table: "Employees",
                column: "SalaryId",
                principalTable: "Salariys",
                principalColumn: "SalaryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Salariys_SalaryId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SalaryId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Salariys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salariys_EmployeeId",
                table: "Salariys",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salariys_Employees_EmployeeId",
                table: "Salariys",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
