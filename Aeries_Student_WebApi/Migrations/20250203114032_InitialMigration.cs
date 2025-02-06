using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeries_Student_WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalData",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: true),
                    medicalRecordId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalBU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalBillC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalData");
        }
    }
}
