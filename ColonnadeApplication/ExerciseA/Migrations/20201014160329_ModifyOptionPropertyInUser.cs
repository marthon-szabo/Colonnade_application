using Microsoft.EntityFrameworkCore.Migrations;

namespace ExerciseA.Migrations
{
    public partial class ModifyOptionPropertyInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Options_OptionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OptionId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_OptionId",
                table: "Users",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Options_OptionId",
                table: "Users",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
