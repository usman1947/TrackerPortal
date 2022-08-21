using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddingWorkoutProgramUserMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutProgramUserMapping",
                columns: table => new
                {
                    WorkoutProgramId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutProgramUserMapping", x => new { x.UserId, x.WorkoutProgramId });
                    table.ForeignKey(
                        name: "FK_WorkoutProgramUserMapping_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutProgramUserMapping_WorkoutProgram_WorkoutProgramId",
                        column: x => x.WorkoutProgramId,
                        principalTable: "WorkoutProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutProgramUserMapping_WorkoutProgramId",
                table: "WorkoutProgramUserMapping",
                column: "WorkoutProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutProgramUserMapping");
        }
    }
}
