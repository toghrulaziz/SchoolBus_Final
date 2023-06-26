using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBusFinalTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeRideIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Ride_RideId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "RideId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Ride_RideId",
                table: "Student",
                column: "RideId",
                principalTable: "Ride",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Ride_RideId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "RideId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Ride_RideId",
                table: "Student",
                column: "RideId",
                principalTable: "Ride",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
