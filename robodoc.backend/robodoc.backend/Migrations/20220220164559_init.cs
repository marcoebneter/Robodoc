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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RoboOrtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoboActivityStatus_RoboOrts_RoboOrtId",
                        column: x => x.RoboOrtId,
                        principalTable: "RoboOrts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Intervall = table.Column<TimeSpan>(type: "time", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonalId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TherapieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Therapieverfahren_Therapien_TherapieId",
                        column: x => x.TherapieId,
                        principalTable: "Therapien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medikamente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Einheit = table.Column<int>(type: "int", nullable: false),
                    VerabreichungsprozessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medikamente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medikamente_Verabreichungsprozesse_VerabreichungsprozessId",
                        column: x => x.VerabreichungsprozessId,
                        principalTable: "Verabreichungsprozesse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Durchfuehrungen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Zeitpunkt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TherapieverfahrenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Menge = table.Column<int>(type: "int", nullable: false),
                    MedikamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TherapieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "RoboActivities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("18f5805c-e7e1-4cf4-b636-8f7064eaa71b"), "verlassen" },
                    { new Guid("4c69883f-b091-4f55-9cfc-751cee65b479"), "einfahren" },
                    { new Guid("90221e71-2e2e-4f0c-a562-ab937abcef93"), "Medikament abgeben" },
                    { new Guid("b606809c-f077-402b-9915-e2c26ad33194"), "warten" },
                    { new Guid("b6e1bee6-6460-4628-b350-039e837c8f3b"), "Medikament aufnehmen" }
                });

            migrationBuilder.InsertData(
                table: "RoboOrts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00486833-7481-492a-a3fc-72b9f6cc7861"), "Parkposition" },
                    { new Guid("10ac718a-9358-46c9-91cd-652c9afdcd13"), "Zimmer 3" },
                    { new Guid("211cb552-3e74-4d33-ba4f-4a70ea687a77"), "Zimmer 2" },
                    { new Guid("451a1c87-26ed-4d2a-afc5-6e6422f94a66"), "Zimmer 4" },
                    { new Guid("5ef804d7-9692-4575-8dad-12488984c5f5"), "Zimmer 1" },
                    { new Guid("b7c1c927-42a4-46a2-abff-dd470caf6fa0"), "Apotheke" }
                });

            migrationBuilder.InsertData(
                table: "Verabreichungsprozesse",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("34df44a7-e8bf-47d3-a8f0-92bdc6fd6137"), "lingual" },
                    { new Guid("40b3f75d-0194-4323-8aa2-de72cfe25ddb"), "intramuskulär" },
                    { new Guid("5054a585-2cd2-48e5-8a61-89835d8083c4"), "oral" },
                    { new Guid("7d3ba77e-d798-4323-b0c9-1d5e770f80bd"), "intrakutan" },
                    { new Guid("89f16c03-07b0-4f4a-b249-703d72ede2fd"), "nasal" },
                    { new Guid("934cf485-f45d-4619-8ae1-0b1f74c08737"), "intravenös" },
                    { new Guid("979f9cf3-f7fd-4a21-899a-67c662de1dd3"), "intraarteriell" },
                    { new Guid("ab5de655-7b7d-4356-bbb5-726a18c1a8dc"), "konjunktival" },
                    { new Guid("cff7b8a4-559a-4318-ba59-a6c1e9072ffc"), "sublingual" },
                    { new Guid("ee84777f-3c06-4c21-80ca-2a90c7bcb242"), "perkutan" },
                    { new Guid("f39f9f22-7fdd-45c2-89ab-c4027510bff3"), "subkutan" },
                    { new Guid("f50496be-1247-472d-abd5-a4126474fc3a"), "rektal" },
                    { new Guid("fd0ef685-7cc5-485d-930a-eb8b403ab22a"), "kutan" },
                    { new Guid("fe57b2fb-a3a4-4cdc-8fe0-9a50d7a7b98d"), "vaginal" }
                });

            migrationBuilder.InsertData(
                table: "Medikamente",
                columns: new[] { "Id", "Einheit", "Name", "VerabreichungsprozessId" },
                values: new object[] { new Guid("180a195b-9f6c-46ca-9c00-3cfe20cd886f"), 0, "Daflon", new Guid("34df44a7-e8bf-47d3-a8f0-92bdc6fd6137") });

            migrationBuilder.InsertData(
                table: "Medikamente",
                columns: new[] { "Id", "Einheit", "Name", "VerabreichungsprozessId" },
                values: new object[] { new Guid("89007190-d27d-42b8-8f90-655c2c512634"), 0, "Pantoloc", new Guid("34df44a7-e8bf-47d3-a8f0-92bdc6fd6137") });

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
