using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class Addrooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    amenitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.amenitiesId);
                });

            migrationBuilder.CreateTable(
                name: "HotelBranches",
                columns: table => new
                {
                    hotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roomsNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelBranches", x => x.hotelId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    workTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    HotelBrancheshotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.empId);
                    table.ForeignKey(
                        name: "FK_Employees_HotelBranches_HotelBrancheshotelId",
                        column: x => x.HotelBrancheshotelId,
                        principalTable: "HotelBranches",
                        principalColumn: "hotelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    roomId = table.Column<int>(type: "int", nullable: false),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    nickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    space = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HotelBrancheshotelId = table.Column<int>(type: "int", nullable: true),
                    visitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => new { x.hotelId, x.roomId });
                    table.ForeignKey(
                        name: "FK_Rooms_HotelBranches_HotelBrancheshotelId",
                        column: x => x.HotelBrancheshotelId,
                        principalTable: "HotelBranches",
                        principalColumn: "hotelId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_HotelBrancheshotelId",
                table: "Employees",
                column: "HotelBrancheshotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelBrancheshotelId",
                table: "Rooms",
                column: "HotelBrancheshotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "HotelBranches");
        }
    }
}
