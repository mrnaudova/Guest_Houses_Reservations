using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guest_Houses_Reservations.Data.Migrations
{
    public partial class ReservationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Guest_UserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_House_HouseId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservation");

            migrationBuilder.AlterColumn<int>(
                name: "HouseId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_GuestId",
                table: "Reservation",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Guest_GuestId",
                table: "Reservation",
                column: "GuestId",
                principalTable: "Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_House_HouseId",
                table: "Reservation",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Guest_GuestId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_House_HouseId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_GuestId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Reservation");

            migrationBuilder.AlterColumn<int>(
                name: "HouseId",
                table: "Reservation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Guest_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "Guest",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_House_HouseId",
                table: "Reservation",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id");
        }
    }
}
