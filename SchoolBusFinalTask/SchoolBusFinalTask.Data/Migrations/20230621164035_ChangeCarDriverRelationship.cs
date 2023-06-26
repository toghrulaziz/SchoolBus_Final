using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBusFinalTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCarDriverRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Car_CarId",
                table: "Driver");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Car_CarId",
                table: "Driver",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Car_CarId",
                table: "Driver");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Car_CarId",
                table: "Driver",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
