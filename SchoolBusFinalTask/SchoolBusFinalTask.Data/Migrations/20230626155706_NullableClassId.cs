using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolBusFinalTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class NullableClassId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Ride",
                nullable: true,
                oldNullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
