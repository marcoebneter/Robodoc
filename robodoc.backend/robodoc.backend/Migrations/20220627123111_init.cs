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
                    { new Guid("337ebc27-e1f2-490a-8b6a-1eb407305da5"), 1, "Vivotif", 1 },
                    { new Guid("66ccb405-8ede-48e5-a935-294fcfaa9cba"), 6, "Hepatec", 3 },
                    { new Guid("a0eae707-b4fa-4b08-8293-d4d3f0b37e43"), 0, "Pantoloc", 1 },
                    { new Guid("ca60f396-61b2-4ab5-b45a-3c83cef54e03"), 0, "Daflon", 6 }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "Anamnese", "AustrittDatum", "EintrittDatum", "Name", "Vorname", "Zimmer" },
                values: new object[] { new Guid("f2dbbaa6-8dd7-4793-9931-7ffab903b7ad"), "Velounfall", null, new DateTime(2022, 6, 27, 14, 31, 11, 657, DateTimeKind.Local).AddTicks(1596), "Zingg", "Joel", 0 });

            migrationBuilder.InsertData(
                table: "Personal",
                columns: new[] { "Id", "IsArzt", "Password", "Username" },
                values: new object[] { new Guid("f9a51945-5573-454c-9299-86f0fe8390c0"), true, "marco", "Marco" });

            migrationBuilder.InsertData(
                table: "RoboActivity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03a26a66-a9a4-430d-bf44-513ab1a8d993"), "verlassen" },
                    { new Guid("14d98aeb-006c-439c-9198-f2188f23ca00"), "Medikament aufnehmen" },
                    { new Guid("3e59fd46-4ce0-479c-b985-a3c03dec7b3c"), "einfahren" },
                    { new Guid("56915204-6c19-48dd-9c2c-de146f9a1191"), "Medikament abgeben" },
                    { new Guid("6f404617-cc32-42e5-8849-a7d1a38fe09a"), "warten" }
                });

            migrationBuilder.InsertData(
                table: "RoboOrt",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39a6e97a-6e86-432d-8137-00804ff8385d"), "Parkposition" },
                    { new Guid("7c47db25-0fd5-497a-a435-42e47a001452"), "Zimmer 4" },
                    { new Guid("b29cfbba-afd1-405c-977c-4ef56a7f8275"), "Zimmer 3" },
                    { new Guid("c86c0b75-7bde-4126-9dea-f2fc3808edc3"), "Zimmer 2" },
                    { new Guid("d76d3fc8-5ec1-485c-8b88-00970ec44352"), "Zimmer 1" },
                    { new Guid("fa53884e-ca3c-422d-a78b-f3eda204252b"), "Apotheke" }
                });

            migrationBuilder.InsertData(
                table: "Therapien",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("68dc1fb9-eea1-4169-b327-dde17ea8c8e3"), "Elektrotherapie" },
                    { new Guid("9c32eaed-c031-4167-9158-ba096b9ce6b0"), "Hydrotherapie" },
                    { new Guid("a523fef0-2b70-4bb7-b8cf-3d0c4e9b5355"), "Atlaslogie" },
                    { new Guid("c002c1c6-2e2c-4dfb-b6cc-f27a9fcd1f1f"), "Diät" }
                });

            migrationBuilder.InsertData(
                table: "MedikamentTherapien",
                columns: new[] { "Id", "MedikamentId", "Menge", "TherapieId" },
                values: new object[,]
                {
                    { new Guid("05715788-51e5-4708-8d56-ee6a101796a9"), new Guid("ca60f396-61b2-4ab5-b45a-3c83cef54e03"), 2, new Guid("68dc1fb9-eea1-4169-b327-dde17ea8c8e3") },
                    { new Guid("af3b5dec-d5e0-43b0-96a2-7a3a1f608cd3"), new Guid("337ebc27-e1f2-490a-8b6a-1eb407305da5"), 5, new Guid("9c32eaed-c031-4167-9158-ba096b9ce6b0") },
                    { new Guid("c70c921f-accb-4dec-9a39-a9f4a1fc993d"), new Guid("66ccb405-8ede-48e5-a935-294fcfaa9cba"), 2, new Guid("a523fef0-2b70-4bb7-b8cf-3d0c4e9b5355") },
                    { new Guid("ca78533f-a6d3-4c7a-8dd5-060287292e13"), new Guid("ca60f396-61b2-4ab5-b45a-3c83cef54e03"), 3, new Guid("c002c1c6-2e2c-4dfb-b6cc-f27a9fcd1f1f") },
                    { new Guid("e8f0b558-a670-42b2-b4ae-865bb87df185"), new Guid("a0eae707-b4fa-4b08-8293-d4d3f0b37e43"), 5, new Guid("c002c1c6-2e2c-4dfb-b6cc-f27a9fcd1f1f") },
                    { new Guid("efc06bb2-a941-4f75-89a2-2649a27eba1c"), new Guid("337ebc27-e1f2-490a-8b6a-1eb407305da5"), 1, new Guid("68dc1fb9-eea1-4169-b327-dde17ea8c8e3") }
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
