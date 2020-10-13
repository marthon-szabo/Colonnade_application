using Microsoft.EntityFrameworkCore.Migrations;

namespace ExerciseA.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccidentInsuranceLimit = table.Column<int>(nullable: false),
                    Cash = table.Column<int>(nullable: false),
                    Luggage = table.Column<int>(nullable: false),
                    LuggageLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    OptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "AccidentInsuranceLimit", "Cash", "Luggage", "LuggageLimit" },
                values: new object[,]
                {
                    { 4, 50000000, 0, 0, 200000000 },
                    { 1, 200000000, 100000, 200000, 200000000 },
                    { 3, 100000000, 0, 50000, 200000000 },
                    { 2, 150000000, 100000, 100000, 200000000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OptionId",
                table: "Users",
                column: "OptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Options");
        }
    }
}
