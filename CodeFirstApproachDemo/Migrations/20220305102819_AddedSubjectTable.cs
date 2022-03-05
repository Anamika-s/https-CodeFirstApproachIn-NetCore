using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproachDemo.Migrations
{
    public partial class AddedSubjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StartDAte",
                table: "Batches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SubjectRefId",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_SubjectRefId",
                table: "Batches",
                column: "SubjectRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Subject_SubjectRefId",
                table: "Batches",
                column: "SubjectRefId",
                principalTable: "Subject",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Subject_SubjectRefId",
                table: "Batches");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Batches_SubjectRefId",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "StartDAte",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "SubjectRefId",
                table: "Batches");
        }
    }
}
