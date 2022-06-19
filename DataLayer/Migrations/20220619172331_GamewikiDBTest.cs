using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class GamewikiDBTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Ammo_AmmoID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_AmmoID",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "AmmoID",
                table: "Weapons");

            migrationBuilder.CreateTable(
                name: "AmmoWeapon",
                columns: table => new
                {
                    AmmoID = table.Column<int>(type: "int", nullable: false),
                    WeaponsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmoWeapon", x => new { x.AmmoID, x.WeaponsID });
                    table.ForeignKey(
                        name: "FK_AmmoWeapon_Ammo_AmmoID",
                        column: x => x.AmmoID,
                        principalTable: "Ammo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmmoWeapon_Weapons_WeaponsID",
                        column: x => x.WeaponsID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmmoWeapon_WeaponsID",
                table: "AmmoWeapon",
                column: "WeaponsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmmoWeapon");

            migrationBuilder.AddColumn<int>(
                name: "AmmoID",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_AmmoID",
                table: "Weapons",
                column: "AmmoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Ammo_AmmoID",
                table: "Weapons",
                column: "AmmoID",
                principalTable: "Ammo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
