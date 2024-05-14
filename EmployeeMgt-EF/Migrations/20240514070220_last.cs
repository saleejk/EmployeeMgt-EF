using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeMgt_EF.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    E_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    E_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_salary = table.Column<int>(type: "int", nullable: false),
                    E_role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.E_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
