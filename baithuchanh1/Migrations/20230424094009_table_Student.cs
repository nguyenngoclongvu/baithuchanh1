using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baithuchanh1.Migrations
{
    /// <inheritdoc />
    public partial class tableStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IDStudent = table.Column<string>(type: "TEXT", nullable: false),
                    NameStudent = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneStudent = table.Column<string>(type: "TEXT", nullable: false),
                    AddStudent = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IDStudent);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
