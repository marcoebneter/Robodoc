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
                name: "Medikamente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Einheit = table.Column<int>(type: "int", nullable: false),
                    Verabreichungsprozess = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medikamente", x => x.Id);
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
                name: "Durchfuehrungen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Zeitpunkt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TherapieverfahrenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durchfuehrungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Durchfuehrungen_Therapieverfahren_TherapieverfahrenId",
                        column: x => x.TherapieverfahrenId,
                        principalTable: "Therapieverfahren",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Medikamente",
                columns: new[] { "Id", "Einheit", "Name", "Verabreichungsprozess" },
                values: new object[,]
                {
                    { new Guid("84fc6b28-7c1d-46eb-a364-203632751225"), 0, "Pantoloc", 1 },
                    { new Guid("a6c2cce1-c492-48c9-876c-c400c75e09ed"), 0, "Daflon", 6 }
                });

            migrationBuilder.InsertData(
                table: "Patienten",
                columns: new[] { "Id", "Anamnese", "AustrittDatum", "EintrittDatum", "Name", "Vorname" },
                values: new object[] { new Guid("daaf542c-973a-4370-97ba-71db90f2ea5a"), "isch en gaile siech", null, new DateTime(2022, 4, 20, 8, 6, 25, 620, DateTimeKind.Local).AddTicks(4576), "Zingg", "Joel" });

            migrationBuilder.InsertData(
                table: "RoboActivities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12d9f03d-0814-48f0-9aa2-df2e16bdda1a"), "Medikament aufnehmen" },
                    { new Guid("6f24ab55-c547-497b-9313-d2e31cb09515"), "einfahren" },
                    { new Guid("abb1a1ea-f914-4846-886d-3a7485b55dee"), "verlassen" },
                    { new Guid("b7d365bc-43a3-4cac-8ab0-9b748f0120df"), "warten" },
                    { new Guid("d0ee298d-c44d-4c64-89c3-0b4ffcabd874"), "Medikament abgeben" }
                });

            migrationBuilder.InsertData(
                table: "RoboOrts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("26fac76a-d0d1-4e5d-b835-472f662594b7"), "Apotheke" },
                    { new Guid("5b400e36-dc5b-4886-b59c-22dae0ba0b54"), "Zimmer 1" },
                    { new Guid("8f4a9fe6-0c06-415e-89be-52724f7e01cb"), "Zimmer 4" },
                    { new Guid("bc9bb5c5-13c6-49d1-8c5b-4e49884da9b8"), "Zimmer 2" },
                    { new Guid("e910bac0-d3ea-4462-9f95-5a1dd6ca3572"), "Zimmer 3" },
                    { new Guid("f057aae6-b938-4e98-9275-6cbeedbd5cb4"), "Parkposition" }
                });

            migrationBuilder.InsertData(
                table: "Therapien",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("661a0576-157b-4c70-8a90-7fd26b59a834"), "eine Therapie" });

            migrationBuilder.InsertData(
                table: "MedikamentTherapien",
                columns: new[] { "Id", "MedikamentId", "Menge", "TherapieId" },
                values: new object[] { new Guid("7ad80e56-b621-4ded-8151-49df77040408"), new Guid("84fc6b28-7c1d-46eb-a364-203632751225"), 5, new Guid("661a0576-157b-4c70-8a90-7fd26b59a834") });

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
        }
    }
}
