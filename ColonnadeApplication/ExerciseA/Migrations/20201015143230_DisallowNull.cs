using Microsoft.EntityFrameworkCore.Migrations;

namespace ExerciseA.Migrations
{
    public partial class DisallowNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OptionId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OptionId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
