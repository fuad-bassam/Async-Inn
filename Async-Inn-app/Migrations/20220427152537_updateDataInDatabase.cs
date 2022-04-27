using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class updateDataInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "amenitiesId", "description", "name", "price" },
                values: new object[,]
                {
                    { 22, "haveing a romantic mode with flour for couples", "Romantic mode", 70m },
                    { 23, "have fancy library with more than 100 book", "fancy library", 20m }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 1, 101 },
                column: "PetFriendly",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 2, 101 },
                column: "PetFriendly",
                value: true);

            migrationBuilder.InsertData(
                table: "RoomsAmenities",
                columns: new[] { "amenitiesId", "hotelId", "roomId", "canRemove" },
                values: new object[] { 22, 1, 102, true });

            migrationBuilder.InsertData(
                table: "RoomsAmenities",
                columns: new[] { "amenitiesId", "hotelId", "roomId", "canRemove" },
                values: new object[] { 23, 1, 102, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomsAmenities",
                keyColumns: new[] { "amenitiesId", "hotelId", "roomId" },
                keyValues: new object[] { 22, 1, 102 });

            migrationBuilder.DeleteData(
                table: "RoomsAmenities",
                keyColumns: new[] { "amenitiesId", "hotelId", "roomId" },
                keyValues: new object[] { 23, 1, 102 });

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "amenitiesId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "amenitiesId",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 1, 101 },
                column: "PetFriendly",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 2, 101 },
                column: "PetFriendly",
                value: false);
        }
    }
}
