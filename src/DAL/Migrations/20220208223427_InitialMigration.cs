using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.Id);
                });

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
                name: "IX_ClientMedicament_MedicamentIdId",
                table: "ClientMedicament",
                column: "MedicamentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPharmacy_PharmacyIdId",
                table: "ClientPharmacy",
                column: "PharmacyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPharmacy_PharmacyIdId",
                table: "MedicamentPharmacy",
                column: "PharmacyIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientMedicament");

            migrationBuilder.DropTable(
                name: "ClientPharmacy");

            migrationBuilder.DropTable(
                name: "MedicamentPharmacy");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.DropTable(
                name: "Pharmacies");
        }
    }
}
