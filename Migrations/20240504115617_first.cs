using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cascadind_dropdown.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "designation",
                columns: table => new
                {
                    Desig_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation_Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designation", x => x.Desig_Id);
                });

            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    Grade_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desig_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.Grade_Id);
                    table.ForeignKey(
                        name: "FK_grades_designation_Desig_Id",
                        column: x => x.Desig_Id,
                        principalTable: "designation",
                        principalColumn: "Desig_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmpoyeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesigId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmpoyeeId);
                    table.ForeignKey(
                        name: "FK_employees_designation_DesigId",
                        column: x => x.DesigId,
                        principalTable: "designation",
                        principalColumn: "Desig_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employees_grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "grades",
                        principalColumn: "Grade_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DesigId",
                table: "employees",
                column: "DesigId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_GradeId",
                table: "employees",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_grades_Desig_Id",
                table: "grades",
                column: "Desig_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "grades");

            migrationBuilder.DropTable(
                name: "designation");
        }
    }
}
