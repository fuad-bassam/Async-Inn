using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class addRoomsAmenitiSeedData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomsAmenities",
                columns: new[] { "amenitiesId", "hotelId", "roomId", "RoomshotelId", "RoomsroomId", "canRemove" },
                values: new object[] { 11, 2, 101, null, null, false });

            migrationBuilder.InsertData(
                table: "RoomsAmenities",
                columns: new[] { "amenitiesId", "hotelId", "roomId", "RoomshotelId", "RoomsroomId", "canRemove" },
                values: new object[] { 21, 1, 101, null, null, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomsAmenities",
                keyColumns: new[] { "amenitiesId", "hotelId", "roomId" },
                keyValues: new object[] { 21, 1, 101 });

            migrationBuilder.DeleteData(
                table: "RoomsAmenities",
                keyColumns: new[] { "amenitiesId", "hotelId", "roomId" },
                keyValues: new object[] { 11, 2, 101 });
        }
    }
}
