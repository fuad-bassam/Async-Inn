using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class addPetFriendlyToRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PetFriendly",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetFriendly",
                table: "Rooms");
        }
    }
}
