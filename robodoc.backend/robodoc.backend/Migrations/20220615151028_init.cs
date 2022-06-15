using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace robodoc.backend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medikamente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Einheit = table.Column<int>(type: "int", nullable: false),
                    Verabreichungsprozess = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medikamente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Patienten",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vorname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Zimmer = table.Column<int>(type: "int", nullable: false),
                    EintrittDatum = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AustrittDatum = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Anamnese = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patienten", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsArzt = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoboActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboActivity", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoboOrt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboOrt", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Therapien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapien", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoboActivityStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RoboOrtId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ActivityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboActivityStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoboActivityStatus_RoboActivity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "RoboActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoboActivityStatus_RoboOrt_RoboOrtId",
                        column: x => x.RoboOrtId,
                        principalTable: "RoboOrt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedikamentTherapien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Menge = table.Column<int>(type: "int", nullable: false),
                    MedikamentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TherapieId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedikamentTherapien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedikamentTherapien_Medikamente_MedikamentId",
                        column: x => x.MedikamentId,
                        principalTable: "Medikamente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedikamentTherapien_Therapien_TherapieId",
                        column: x => x.TherapieId,
                        principalTable: "Therapien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Therapieverfahren",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Intervall = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    PatientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PersonalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ArztId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TherapieId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapieverfahren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Patienten_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patienten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Personal_ArztId",
                        column: x => x.ArztId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Therapien_TherapieId",
                        column: x => x.TherapieId,
                        principalTable: "Therapien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TherapieverfahrenDurchfuehrung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Zeitpunkt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TherapieverfahrenId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapieverfahrenDurchfuehrung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TherapieverfahrenDurchfuehrung_Therapieverfahren_Therapiever~",
                        column: x => x.TherapieverfahrenId,
                        principalTable: "Therapieverfahren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Medikamente",
                columns: new[] { "Id", "Einheit", "Name", "Verabreichungsprozess" },
                values: new object[,]
                {
                    { new Guid("9a2af162-ff10-425c-a118-c9ee5847a19e"), 0, "Pantoloc", 1 },
                    { new Guid("a2a14aea-beb8-4fa2-80bf-ed6aab87920a"), 0, "Daflon", 6 },
                    { new Guid("dd9c72f8-4813-44f2-a044-d019a02c7126"), 1, "Vivotif", 1 },
                    { new Guid("f495af6d-028c-4f87-8389-3a1daf5d32ad"), 6, "Hepatec", 3 }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "Anamnese", "AustrittDatum", "EintrittDatum", "Name", "Vorname", "Zimmer" },
                values: new object[] { new Guid("a11ab567-7901-4b26-ab24-1abec539655a"), "isch en gaile siech", null, new DateTime(2022, 6, 15, 17, 10, 27, 816, DateTimeKind.Local).AddTicks(3326), "Zingg", "Joel", 0 });

            migrationBuilder.InsertData(
                table: "Personal",
                columns: new[] { "Id", "IsArzt", "Password", "Username" },
                values: new object[] { new Guid("5958e5f5-c8a8-4751-ab89-7104ff4d0ea1"), true, "marco", "Marco" });

            migrationBuilder.InsertData(
                table: "RoboActivity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("111d27c5-d72f-4fc6-8415-1b4a6870c81f"), "einfahren" },
                    { new Guid("ce205808-d69c-4e0d-a160-abfc28ed3a5f"), "Medikament aufnehmen" },
                    { new Guid("ee226288-0e07-4ee1-b5c2-b1d119c4eb02"), "Medikament abgeben" },
                    { new Guid("fc51587d-4270-47fe-b751-f994dbfd673a"), "warten" },
                    { new Guid("ff900d5d-54ba-4aea-895d-c2fa176e6c70"), "verlassen" }
                });

            migrationBuilder.InsertData(
                table: "RoboOrt",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("38de3dea-05cc-434f-a80c-b2bab69d3b1f"), "Zimmer 3" },
                    { new Guid("4ff91abb-aa89-438a-b372-08cea1aa2d1c"), "Parkposition" },
                    { new Guid("b3e990e7-750d-4b93-acab-b827b4949caa"), "Apotheke" },
                    { new Guid("e300980c-e256-4a95-bd57-e8c25ef03fe8"), "Zimmer 1" },
                    { new Guid("ebe91e3b-4cd2-4606-85d5-94ce6bcba347"), "Zimmer 4" },
                    { new Guid("fe21a516-21a8-49fc-be21-52501e68995f"), "Zimmer 2" }
                });

            migrationBuilder.InsertData(
                table: "Therapien",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e0012f3-3e5e-489a-a574-c02e6b5e948c"), "Atlaslogie" },
                    { new Guid("5621ef19-b226-46e1-80bc-d10d91f15141"), "Elektrotherapie" },
                    { new Guid("83760435-0110-4dac-89f6-d659c2f18881"), "Diät" },
                    { new Guid("ded82ea3-620b-462a-87bc-bb7a821cd38b"), "Hydrotherapie" }
                });

            migrationBuilder.InsertData(
                table: "MedikamentTherapien",
                columns: new[] { "Id", "MedikamentId", "Menge", "TherapieId" },
                values: new object[,]
                {
                    { new Guid("0ce18834-8b5d-4d6d-9f24-711270b728eb"), new Guid("a2a14aea-beb8-4fa2-80bf-ed6aab87920a"), 2, new Guid("5621ef19-b226-46e1-80bc-d10d91f15141") },
                    { new Guid("2ae41840-6d92-40de-9aa5-0a7761f8174c"), new Guid("f495af6d-028c-4f87-8389-3a1daf5d32ad"), 2, new Guid("1e0012f3-3e5e-489a-a574-c02e6b5e948c") },
                    { new Guid("3f56568d-6db2-418a-9098-b4cf9d703cd2"), new Guid("dd9c72f8-4813-44f2-a044-d019a02c7126"), 5, new Guid("ded82ea3-620b-462a-87bc-bb7a821cd38b") },
                    { new Guid("42edb2fa-fd3a-413e-9018-e1e0ee9531de"), new Guid("9a2af162-ff10-425c-a118-c9ee5847a19e"), 5, new Guid("83760435-0110-4dac-89f6-d659c2f18881") },
                    { new Guid("433cdf53-3f12-46e0-b5d5-3154b2a787b5"), new Guid("dd9c72f8-4813-44f2-a044-d019a02c7126"), 1, new Guid("5621ef19-b226-46e1-80bc-d10d91f15141") },
                    { new Guid("d7679f96-1c92-4a8d-b367-226a78d4b9c6"), new Guid("a2a14aea-beb8-4fa2-80bf-ed6aab87920a"), 3, new Guid("83760435-0110-4dac-89f6-d659c2f18881") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedikamentTherapien_MedikamentId",
                table: "MedikamentTherapien",
                column: "MedikamentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedikamentTherapien_TherapieId",
                table: "MedikamentTherapien",
                column: "TherapieId");

            migrationBuilder.CreateIndex(
                name: "IX_RoboActivityStatus_ActivityId",
                table: "RoboActivityStatus",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoboActivityStatus_RoboOrtId",
                table: "RoboActivityStatus",
                column: "RoboOrtId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapieverfahren_ArztId",
                table: "Therapieverfahren",
                column: "ArztId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapieverfahren_PatientId",
                table: "Therapieverfahren",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapieverfahren_PersonalId",
                table: "Therapieverfahren",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapieverfahren_TherapieId",
                table: "Therapieverfahren",
                column: "TherapieId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapieverfahrenDurchfuehrung_TherapieverfahrenId",
                table: "TherapieverfahrenDurchfuehrung",
                column: "TherapieverfahrenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedikamentTherapien");

            migrationBuilder.DropTable(
                name: "RoboActivityStatus");

            migrationBuilder.DropTable(
                name: "TherapieverfahrenDurchfuehrung");

            migrationBuilder.DropTable(
                name: "Medikamente");

            migrationBuilder.DropTable(
                name: "RoboActivity");

            migrationBuilder.DropTable(
                name: "RoboOrt");

            migrationBuilder.DropTable(
                name: "Therapieverfahren");

            migrationBuilder.DropTable(
                name: "Patienten");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Therapien");
        }
    }
}
