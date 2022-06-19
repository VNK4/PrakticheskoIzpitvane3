using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class GameWikiTestDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ammo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<double>(type: "float", nullable: false),
                    DamageType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enemies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Health = table.Column<double>(type: "float", nullable: false),
                    Armor = table.Column<double>(type: "float", nullable: false),
                    IsBoss = table.Column<bool>(type: "bit", nullable: false),
                    Behaviour = table.Column<int>(type: "int", nullable: false),
                    WeakAgainst = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enemies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageMultiplier = table.Column<float>(type: "real", nullable: false),
                    AmmoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_Ammo_AmmoID",
                        column: x => x.AmmoID,
                        principalTable: "Ammo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnemyWeapon",
                columns: table => new
                {
                    EnemiesID = table.Column<int>(type: "int", nullable: false),
                    WeaponsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnemyWeapon", x => new { x.EnemiesID, x.WeaponsID });
                    table.ForeignKey(
                        name: "FK_EnemyWeapon_Enemies_EnemiesID",
                        column: x => x.EnemiesID,
                        principalTable: "Enemies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnemyWeapon_Weapons_WeaponsID",
                        column: x => x.WeaponsID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnemyWeapon_WeaponsID",
                table: "EnemyWeapon",
                column: "WeaponsID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_AmmoID",
                table: "Weapons",
                column: "AmmoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnemyWeapon");

            migrationBuilder.DropTable(
                name: "Enemies");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Ammo");
        }
    }
}
