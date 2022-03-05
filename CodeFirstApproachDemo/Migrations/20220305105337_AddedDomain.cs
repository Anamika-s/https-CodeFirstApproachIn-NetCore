using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproachDemo.Migrations
{
    public partial class AddedDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Domain",
                columns: table => new
                {
                    DomainCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TechnologiesCount = table.Column<int>(type: "int", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Domain", x => x.DomainCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Domain");
        }
    }
}
