using Microsoft.EntityFrameworkCore.Migrations;

namespace ExerciseA.Migrations
{
    public partial class BugfixNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Options");

            migrationBuilder.AddColumn<string>(
                name: "OptName",
                table: "Options",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                column: "OptName",
                value: "Optimal");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                column: "OptName",
                value: "Extra");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                column: "OptName",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                column: "OptName",
                value: "Standard");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptName",
                table: "Options");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Optimal");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Extra");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Standard");
        }
    }
}
