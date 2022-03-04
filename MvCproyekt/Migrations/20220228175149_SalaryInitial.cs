using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MvCproyekt.Migrations
{
    public partial class SalaryInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    MonthId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MonthName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.MonthId);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    YearId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.YearId);
                });

            migrationBuilder.CreateTable(
                name: "Salariys",
                columns: table => new
                {
                    SalaryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Month = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Salary = table.Column<double>(type: "double precision", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    MonthId = table.Column<int>(type: "integer", nullable: false),
                    YearsId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salariys", x => x.SalaryId);
                    table.ForeignKey(
                        name: "FK_Salariys_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salariys_Months_MonthId",
                        column: x => x.MonthId,
                        principalTable: "Months",
                        principalColumn: "MonthId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salariys_Years_YearsId",
                        column: x => x.YearsId,
                        principalTable: "Years",
                        principalColumn: "YearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Months",
                columns: new[] { "MonthId", "MonthName" },
                values: new object[,]
                {
                    { 1, "Yanvar" },
                    { 12, "Dekabr" },
                    { 11, "Noyabr" },
                    { 10, "Oktyabr" },
                    { 8, "Avqust" },
                    { 7, "Iyul" },
                    { 9, "Sentaybr" },
                    { 5, "May" },
                    { 4, "Aprel" },
                    { 3, "Mart" },
                    { 2, "Fevral" },
                    { 6, "Iyun" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "YearId", "Year" },
                values: new object[,]
                {
                    { 4, 2023 },
                    { 1, 2020 },
                    { 2, 2021 },
                    { 3, 2022 },
                    { 5, 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salariys_EmployeeId",
                table: "Salariys",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salariys_MonthId",
                table: "Salariys",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Salariys_YearsId",
                table: "Salariys",
                column: "YearsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salariys");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "Years");
        }
    }
}
