using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace robodoc.backend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patienten",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EintrittDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AustrittDatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Anamnese = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patienten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoboActivities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoboOrts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboOrts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Therapien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verabreichungsprozesse",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verabreichungsprozesse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoboActivityStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RoboOrtId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActivityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoboActivityStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoboActivityStatus_RoboActivities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "RoboActivities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoboActivityStatus_RoboOrts_RoboOrtId",
                        column: x => x.RoboOrtId,
                        principalTable: "RoboOrts",
                        principalColumn: "Id");
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "RoboActivityStatusHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "Therapieverfahren",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Intervall = table.Column<TimeSpan>(type: "time", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PersonalId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TherapieId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapieverfahren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_AspNetUsers_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Patienten_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patienten",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Therapien_TherapieId",
                        column: x => x.TherapieId,
                        principalTable: "Therapien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Medikamente",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Einheit = table.Column<int>(type: "int", nullable: false),
                    VerabreichungsprozessId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medikamente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medikamente_Verabreichungsprozesse_VerabreichungsprozessId",
                        column: x => x.VerabreichungsprozessId,
                        principalTable: "Verabreichungsprozesse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Durchfuehrungen",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Zeitpunkt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TherapieverfahrenId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durchfuehrungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Durchfuehrungen_AspNetUsers_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Durchfuehrungen_Therapieverfahren_TherapieverfahrenId",
                        column: x => x.TherapieverfahrenId,
                        principalTable: "Therapieverfahren",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedikamentTherapien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Menge = table.Column<int>(type: "int", nullable: false),
                    MedikamentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TherapieId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedikamentTherapien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedikamentTherapien_Medikamente_MedikamentId",
                        column: x => x.MedikamentId,
                        principalTable: "Medikamente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedikamentTherapien_Therapien_TherapieId",
                        column: x => x.TherapieId,
                        principalTable: "Therapien",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "RoboActivities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "84401193-026f-45f2-a5c8-bcf586ab7c5e", "einfahren" },
                    { "93539ed5-f6c4-4b13-b40c-49c91caebbe3", "warten" },
                    { "b3c32518-99b1-4722-9e75-490135db9044", "Medikament aufnehmen" },
                    { "c118ec0b-9187-40a4-a6bb-f1ed082ccd5f", "Medikament abgeben" },
                    { "d19ad3b1-d9e6-41b6-b8a6-24ac8f0e65e0", "verlassen" }
                });

            migrationBuilder.InsertData(
                table: "RoboOrts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1976d038-368c-49f1-bae4-b02e5caa1b7a", "Zimmer 1" },
                    { "198166c3-eedf-4a9c-b447-548436b43a4f", "Apotheke" },
                    { "74d6e802-0a02-47c1-a2bd-b90ece8c2bcb", "Zimmer 4" },
                    { "7e0465a3-8c51-425a-927b-ee03ac862cb5", "Zimmer 2" },
                    { "d20a75e6-3d65-47f4-a182-f75e6ee66308", "Parkposition" },
                    { "e59bcccd-9d18-4afc-b427-a31f6de6372e", "Zimmer 3" }
                });

            migrationBuilder.InsertData(
                table: "Verabreichungsprozesse",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "11bf5ad6-eb7d-4161-b25b-1a5f97be5ff6", "lingual" },
                    { "1b2e6a04-7f8e-4208-b08a-aadd4e0d29b1", "subkutan" },
                    { "26bded86-950b-4a23-bbea-eda68c3b6eb1", "nasal" },
                    { "48b58177-79db-425b-a433-7b2de7848d31", "konjunktival" },
                    { "60f9217a-0e33-40ef-b18a-22210347418e", "intrakutan" },
                    { "6b006eb3-3ef0-48c1-913a-c13ac2d03e98", "rektal" },
                    { "6d9933d2-e814-4f2a-933e-c103d752ae3c", "kutan" },
                    { "84808a60-051d-4f9a-93d1-b214cb566e85", "sublingual" },
                    { "943f757d-3398-48ec-a468-585a2f9e1f69", "intraarteriell" },
                    { "a0bed6f9-adc1-44f8-be16-a295ca184e8a", "vaginal" },
                    { "b116abff-67a2-4b1c-b5c8-62ca71e82d4c", "intramuskulär" },
                    { "b25948e6-e42c-4229-b425-68f94a2af2c4", "oral" },
                    { "cae8839c-d8ca-432a-af73-5b1993c486e3", "intravenös" },
                    { "f7ee6ef7-f24f-42e2-baaa-6d21302142c0", "perkutan" }
                });

            migrationBuilder.InsertData(
                table: "Medikamente",
                columns: new[] { "Id", "Einheit", "Name", "VerabreichungsprozessId" },
                values: new object[] { "29966e01-4ef5-4f79-92ad-d7f94142ba36", 0, "Pantoloc", "11bf5ad6-eb7d-4161-b25b-1a5f97be5ff6" });

            migrationBuilder.InsertData(
                table: "Medikamente",
                columns: new[] { "Id", "Einheit", "Name", "VerabreichungsprozessId" },
                values: new object[] { "dca7fc1e-360a-46aa-846c-3257ead5fed6", 0, "Daflon", "11bf5ad6-eb7d-4161-b25b-1a5f97be5ff6" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Durchfuehrungen_PersonalId",
                table: "Durchfuehrungen",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Durchfuehrungen_TherapieverfahrenId",
                table: "Durchfuehrungen",
                column: "TherapieverfahrenId");

            migrationBuilder.CreateIndex(
                name: "IX_Medikamente_VerabreichungsprozessId",
                table: "Medikamente",
                column: "VerabreichungsprozessId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Durchfuehrungen");

            migrationBuilder.DropTable(
                name: "MedikamentTherapien");

            migrationBuilder.DropTable(
                name: "RoboActivityStatus")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "RoboActivityStatusHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Therapieverfahren");

            migrationBuilder.DropTable(
                name: "Medikamente");

            migrationBuilder.DropTable(
                name: "RoboActivities");

            migrationBuilder.DropTable(
                name: "RoboOrts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Patienten");

            migrationBuilder.DropTable(
                name: "Therapien");

            migrationBuilder.DropTable(
                name: "Verabreichungsprozesse");
        }
    }
}
