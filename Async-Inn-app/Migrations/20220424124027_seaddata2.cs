using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class seaddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "hotelId", "roomId", "HotelBrancheshotelId", "nickName", "price", "space", "visitorId" },
                values: new object[] { 1, 101, null, "Restful Rainier", 29.9m, 2, 0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "hotelId", "roomId", "HotelBrancheshotelId", "nickName", "price", "space", "visitorId" },
                values: new object[] { 1, 102, null, "Seahawks Snooze", 45m, 2, 0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "hotelId", "roomId", "HotelBrancheshotelId", "nickName", "price", "space", "visitorId" },
                values: new object[] { 2, 101, null, "Golden hat", 75m, 3, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 1, 102 });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumns: new[] { "hotelId", "roomId" },
                keyValues: new object[] { 2, 101 });
        }
    }
}
