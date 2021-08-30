using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDAL.Migrations
{
    public partial class EmpLocDept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Lid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Lid);
                });

            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Did = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationLid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Did);
                    table.ForeignKey(
                        name: "FK_Depts_Locations_LocationLid",
                        column: x => x.LocationLid,
                        principalTable: "Locations",
                        principalColumn: "Lid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Esal = table.Column<int>(type: "int", nullable: false),
                    Did = table.Column<int>(type: "int", nullable: false),
                    DeptDid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employees_Depts_DeptDid",
                        column: x => x.DeptDid,
                        principalTable: "Depts",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depts_LocationLid",
                table: "Depts",
                column: "LocationLid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptDid",
                table: "Employees",
                column: "DeptDid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Depts");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
