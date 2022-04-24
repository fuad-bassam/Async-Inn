using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomsAmenities",
                columns: table => new
                {
                    roomId = table.Column<int>(type: "int", nullable: false),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    amenitiesId = table.Column<int>(type: "int", nullable: false),
                    HotelBrancheshotelId = table.Column<int>(type: "int", nullable: true),
                    canRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsAmenities", x => new { x.hotelId, x.roomId, x.amenitiesId });
                    table.ForeignKey(
                        name: "FK_RoomsAmenities_Amenities_amenitiesId",
                        column: x => x.amenitiesId,
                        principalTable: "Amenities",
                        principalColumn: "amenitiesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomsAmenities_HotelBranches_HotelBrancheshotelId",
                        column: x => x.HotelBrancheshotelId,
                        principalTable: "HotelBranches",
                        principalColumn: "hotelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomsAmenities_amenitiesId",
                table: "RoomsAmenities",
                column: "amenitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsAmenities_HotelBrancheshotelId",
                table: "RoomsAmenities",
                column: "HotelBrancheshotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomsAmenities");
        }
    }
}
