using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ClientMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientMedicament");

            migrationBuilder.DropTable(
                name: "ClientPharmacy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientMedicament",
                columns: table => new
                {
                    ClientIdId = table.Column<int>(type: "int", nullable: false),
                    MedicamentIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMedicament", x => new { x.ClientIdId, x.MedicamentIdId });
                    table.ForeignKey(
                        name: "FK_ClientMedicament_Clients_ClientIdId",
                        column: x => x.ClientIdId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientMedicament_Medicaments_MedicamentIdId",
                        column: x => x.MedicamentIdId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientPharmacy",
                columns: table => new
                {
                    ClientIdId = table.Column<int>(type: "int", nullable: false),
                    PharmacyIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPharmacy", x => new { x.ClientIdId, x.PharmacyIdId });
                    table.ForeignKey(
                        name: "FK_ClientPharmacy_Clients_ClientIdId",
                        column: x => x.ClientIdId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientPharmacy_Pharmacies_PharmacyIdId",
                        column: x => x.PharmacyIdId,
                        principalTable: "Pharmacies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientMedicament_MedicamentIdId",
                table: "ClientMedicament",
                column: "MedicamentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPharmacy_PharmacyIdId",
                table: "ClientPharmacy",
                column: "PharmacyIdId");
        }
    }
}
