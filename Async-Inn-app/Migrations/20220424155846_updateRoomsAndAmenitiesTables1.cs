using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class updateRoomsAndAmenitiesTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "visitorId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "visitorId",
                table: "Rooms");
        }
    }
}
