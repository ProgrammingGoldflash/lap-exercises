using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.DoctorsOffice.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Birth = table.Column<DateTime>(type: "Date", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Visit = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDiagnoses_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnoses_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Allergy" },
                    { 2, "cardiac cycle" },
                    { 3, "Cold" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Birth", "FirstName", "LastName", "SSN" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klara", "Schmidt", 1234 },
                    { 2, new DateTime(2001, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hans", "Haubner", 4567 },
                    { 3, new DateTime(1990, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ilse", "Puck", 7896 }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "DiseaseId", "Title" },
                values: new object[] { 1, 1, "rash hands" });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "DiseaseId", "Title" },
                values: new object[] { 2, 2, "breathlessness" });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "DiseaseId", "Title" },
                values: new object[] { 3, 3, "rhinitis" });

            migrationBuilder.InsertData(
                table: "PatientDiagnoses",
                columns: new[] { "Id", "DiagnosisId", "PatientId", "Visit" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 11, 19, 9, 3, 40, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, new DateTime(2020, 1, 28, 8, 3, 10, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 3, new DateTime(2019, 8, 14, 15, 3, 21, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 2, new DateTime(2021, 1, 17, 11, 15, 26, 0, DateTimeKind.Unspecified) },
                    { 5, 3, 1, new DateTime(2020, 12, 12, 20, 3, 50, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_DiseaseId",
                table: "Diagnoses",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnoses_DiagnosisId",
                table: "PatientDiagnoses",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnoses_PatientId",
                table: "PatientDiagnoses",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientDiagnoses");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Diseases");
        }
    }
}
