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
                name: "Personals",
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
                    table.PrimaryKey("PK_Personals", x => x.Id);
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
                        name: "FK_Therapieverfahren_Personals_ArztId",
                        column: x => x.ArztId,
                        principalTable: "Personals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Personals_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personals",
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
                name: "Durchfuehrungen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Zeitpunkt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TherapieverfahrenId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durchfuehrungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Durchfuehrungen_Therapieverfahren_TherapieverfahrenId",
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
                    { new Guid("57983716-ee82-4492-986f-707fcfec90f1"), 0, "Daflon", 6 },
                    { new Guid("6fae7988-0b53-42a7-9afa-67a05cf03514"), 6, "Hepatec", 3 },
                    { new Guid("de033ef6-fdc9-4036-a2ec-fdee4950bb70"), 1, "Vivotif", 1 },
                    { new Guid("e73fc593-f083-4773-b03b-6813b4055a1a"), 0, "Pantoloc", 1 }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "Anamnese", "AustrittDatum", "EintrittDatum", "Name", "Vorname", "Zimmer" },
                values: new object[] { new Guid("68a6d1da-7f81-408b-b62c-53b3d2920c66"), "isch en gaile siech", null, new DateTime(2022, 6, 14, 10, 32, 44, 965, DateTimeKind.Local).AddTicks(1628), "Zingg", "Joel", 0 });

            migrationBuilder.InsertData(
                table: "Personals",
                columns: new[] { "Id", "IsArzt", "Password", "Username" },
                values: new object[] { new Guid("e38cc348-b847-4753-8aaf-ac4380ff6e5d"), true, "marco", "Marco" });

            migrationBuilder.InsertData(
                table: "RoboActivity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11bec420-4616-4c26-9910-523557ae6503"), "Medikament aufnehmen" },
                    { new Guid("2b81e33b-17a4-493e-938a-8e33b3041a42"), "warten" },
                    { new Guid("476b3a0e-f1ed-4405-ad2e-4fc659a76970"), "einfahren" },
                    { new Guid("7e4de35a-66ab-4e49-a147-5c56823e3aa1"), "Medikament abgeben" },
                    { new Guid("bc35d9ba-91e3-4e7e-ae77-6cfd07c8a86e"), "verlassen" }
                });

            migrationBuilder.InsertData(
                table: "RoboOrt",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("282f0ccf-d16b-40d4-91aa-d9163045b13f"), "Zimmer 3" },
                    { new Guid("6c0a9ebc-793b-42ab-95f9-2ca676269228"), "Zimmer 2" },
                    { new Guid("8beb8967-df40-4741-8d9f-b0dac6f1e7ac"), "Zimmer 4" },
                    { new Guid("9b2799c1-b0bb-4a40-87ed-7b5cdad3ec8d"), "Zimmer 1" },
                    { new Guid("ab6111b4-6b6f-427d-9edb-b1bbeb9e2af4"), "Apotheke" },
                    { new Guid("cb32f71a-d688-4bb0-8937-bfb7ade1bf88"), "Parkposition" }
                });

            migrationBuilder.InsertData(
                table: "Therapien",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12b986f0-4c2f-4cf3-a9ef-f7b085a15546"), "Atlaslogie" },
                    { new Guid("47c7407e-eff5-4b4f-88e1-003009a0cd8d"), "Diät" },
                    { new Guid("8c33d707-ab85-4210-bd1f-8da6df53710b"), "Hydrotherapie" },
                    { new Guid("ee859e92-0278-4d33-8ae7-2ce3f4b96899"), "Elektrotherapie" }
                });

            migrationBuilder.InsertData(
                table: "MedikamentTherapien",
                columns: new[] { "Id", "MedikamentId", "Menge", "TherapieId" },
                values: new object[,]
                {
                    { new Guid("24838c3b-b3b8-4319-9029-186e6c0a9309"), new Guid("57983716-ee82-4492-986f-707fcfec90f1"), 2, new Guid("ee859e92-0278-4d33-8ae7-2ce3f4b96899") },
                    { new Guid("2874d8de-ae55-4f7c-b513-b7d35702aaf4"), new Guid("57983716-ee82-4492-986f-707fcfec90f1"), 3, new Guid("47c7407e-eff5-4b4f-88e1-003009a0cd8d") },
                    { new Guid("46cb64a3-a265-42c9-8b5d-f139301df543"), new Guid("de033ef6-fdc9-4036-a2ec-fdee4950bb70"), 1, new Guid("ee859e92-0278-4d33-8ae7-2ce3f4b96899") },
                    { new Guid("8eeaba4e-fb19-40d9-b0c9-232af9b8bc78"), new Guid("e73fc593-f083-4773-b03b-6813b4055a1a"), 5, new Guid("47c7407e-eff5-4b4f-88e1-003009a0cd8d") },
                    { new Guid("cc167b7f-0cf1-48c2-af4f-4f37653b6c88"), new Guid("6fae7988-0b53-42a7-9afa-67a05cf03514"), 2, new Guid("12b986f0-4c2f-4cf3-a9ef-f7b085a15546") },
                    { new Guid("f2d956b0-aef2-42a0-9074-1476a759a219"), new Guid("de033ef6-fdc9-4036-a2ec-fdee4950bb70"), 5, new Guid("8c33d707-ab85-4210-bd1f-8da6df53710b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Durchfuehrungen_TherapieverfahrenId",
                table: "Durchfuehrungen",
                column: "TherapieverfahrenId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Durchfuehrungen");

            migrationBuilder.DropTable(
                name: "MedikamentTherapien");

            migrationBuilder.DropTable(
                name: "RoboActivityStatus");

            migrationBuilder.DropTable(
                name: "Therapieverfahren");

            migrationBuilder.DropTable(
                name: "Medikamente");

            migrationBuilder.DropTable(
                name: "RoboActivity");

            migrationBuilder.DropTable(
                name: "RoboOrt");

            migrationBuilder.DropTable(
                name: "Patienten");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Therapien");
        }
    }
}
