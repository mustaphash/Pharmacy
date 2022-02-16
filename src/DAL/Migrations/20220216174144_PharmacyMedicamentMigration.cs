using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class PharmacyMedicamentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentPharmacy");

            migrationBuilder.CreateTable(
                name: "PharmacyMedicament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PharmacyId = table.Column<int>(type: "int", nullable: false),
                    MedicamentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyMedicament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PharmacyMedicament_Medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PharmacyMedicament_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyMedicament_MedicamentId",
                table: "PharmacyMedicament",
                column: "MedicamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyMedicament_PharmacyId",
                table: "PharmacyMedicament",
                column: "PharmacyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PharmacyMedicament");

            migrationBuilder.CreateTable(
                name: "MedicamentPharmacy",
                columns: table => new
                {
                    MedicamentIdId = table.Column<int>(type: "int", nullable: false),
                    PharmacyIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentPharmacy", x => new { x.MedicamentIdId, x.PharmacyIdId });
                    table.ForeignKey(
                        name: "FK_MedicamentPharmacy_Medicaments_MedicamentIdId",
                        column: x => x.MedicamentIdId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentPharmacy_Pharmacies_PharmacyIdId",
                        column: x => x.PharmacyIdId,
                        principalTable: "Pharmacies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPharmacy_PharmacyIdId",
                table: "MedicamentPharmacy",
                column: "PharmacyIdId");
        }
    }
}
