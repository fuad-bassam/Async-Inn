using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class UpdateMigrationSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "amenitiesId", "description", "name", "price" },
                values: new object[,]
                {
                    { 11, "have a coffee maker with unlimited drink amounts from machine choices.", "coffee maker", 25m },
                    { 21, "have a view from the window on the ocean.", "ocean view", 35m },
                    { 31, "Have a mini bar in your rome with a discount of 25% on drinks from it.", "mini bar", 40m }
                });

            migrationBuilder.InsertData(
                table: "HotelBranches",
                columns: new[] { "hotelId", "address", "city", "name", "phoneNum", "roomsNum", "state" },
                values: new object[,]
                {
                    { 1, "Downtoun-ALsame street ", "jordan", "Downtown Branch", "00963323423212", 30, "amman" },
                    { 2, " ali street", "jordan", "Zarqa Branch", "00962790941468", 40, "Zarqa" },
                    { 13, "AL-waseh street", "jordan", "Karak Branch", "00962301520123", 90, "Karak" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "hotelIdRoomId", "HotelBrancheshotelId", "hotelId", "nickName", "price", "roomId", "space", "visitorId" },
                values: new object[,]
                {
                    { 1101, null, 0, "Restful Rainier", 29.9m, 101, 2, 0 },
                    { 1102, null, 0, "Seahawks Snooze", 45m, 102, 2, 0 },
                    { 2101, null, 0, "Golden hat", 75m, 101, 3, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "amenitiesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "amenitiesId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "amenitiesId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HotelBranches",
                keyColumn: "hotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelBranches",
                keyColumn: "hotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelBranches",
                keyColumn: "hotelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "hotelIdRoomId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "hotelIdRoomId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "hotelIdRoomId",
                keyValue: 2101);
        }
    }
}
