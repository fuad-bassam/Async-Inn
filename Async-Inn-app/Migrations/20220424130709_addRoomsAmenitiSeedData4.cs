using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class addRoomsAmenitiSeedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomsAmenities",
                columns: new[] { "amenitiesId", "hotelId", "roomId", "RoomshotelId", "RoomsroomId", "canRemove" },
                values: new object[] { 11, 1, 101, null, null, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomsAmenities",
                keyColumns: new[] { "amenitiesId", "hotelId", "roomId" },
                keyValues: new object[] { 11, 1, 101 });
        }
    }
}
