using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn_app.Migrations
{
    public partial class addRoomsAmenities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HotelBranches_HotelBrancheshotelId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomsAmenities_HotelBranches_HotelBrancheshotelId",
                table: "RoomsAmenities");

            migrationBuilder.DropIndex(
                name: "IX_RoomsAmenities_HotelBrancheshotelId",
                table: "RoomsAmenities");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HotelBrancheshotelId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HotelBrancheshotelId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HotelBrancheshotelId",
                table: "RoomsAmenities",
                newName: "RoomsroomId");

            migrationBuilder.AddColumn<int>(
                name: "RoomshotelId",
                table: "RoomsAmenities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomsAmenities_RoomshotelId_RoomsroomId",
                table: "RoomsAmenities",
                columns: new[] { "RoomshotelId", "RoomsroomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_HotelBranches_hotelId",
                table: "Rooms",
                column: "hotelId",
                principalTable: "HotelBranches",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomsAmenities_Rooms_RoomshotelId_RoomsroomId",
                table: "RoomsAmenities",
                columns: new[] { "RoomshotelId", "RoomsroomId" },
                principalTable: "Rooms",
                principalColumns: new[] { "hotelId", "roomId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HotelBranches_hotelId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomsAmenities_Rooms_RoomshotelId_RoomsroomId",
                table: "RoomsAmenities");

            migrationBuilder.DropIndex(
                name: "IX_RoomsAmenities_RoomshotelId_RoomsroomId",
                table: "RoomsAmenities");

            migrationBuilder.DropColumn(
                name: "RoomshotelId",
                table: "RoomsAmenities");

            migrationBuilder.RenameColumn(
                name: "RoomsroomId",
                table: "RoomsAmenities",
                newName: "HotelBrancheshotelId");

            migrationBuilder.AddColumn<int>(
                name: "HotelBrancheshotelId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomsAmenities_HotelBrancheshotelId",
                table: "RoomsAmenities",
                column: "HotelBrancheshotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelBrancheshotelId",
                table: "Rooms",
                column: "HotelBrancheshotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_HotelBranches_HotelBrancheshotelId",
                table: "Rooms",
                column: "HotelBrancheshotelId",
                principalTable: "HotelBranches",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomsAmenities_HotelBranches_HotelBrancheshotelId",
                table: "RoomsAmenities",
                column: "HotelBrancheshotelId",
                principalTable: "HotelBranches",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
