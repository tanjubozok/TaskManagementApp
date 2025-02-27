using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementApp.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class EditingAppTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTasks_AppUsers_AppUserId",
                table: "AppTasks");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "AppTasks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTasks_AppUsers_AppUserId",
                table: "AppTasks",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTasks_AppUsers_AppUserId",
                table: "AppTasks");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "AppTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTasks_AppUsers_AppUserId",
                table: "AppTasks",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
