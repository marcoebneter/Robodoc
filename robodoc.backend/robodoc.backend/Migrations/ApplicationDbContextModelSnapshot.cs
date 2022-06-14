﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using robodoc.backend.Data;

#nullable disable

namespace robodoc.backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("robodoc.backend.Data.Models.Personal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsArzt")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Personals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e38cc348-b847-4753-8aaf-ac4380ff6e5d"),
                            IsArzt = true,
                            Password = "marco",
                            Username = "Marco"
                        });
                });

            modelBuilder.Entity("robodoc.backend.Data.Models.RoboActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RoboActivity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b81e33b-17a4-493e-938a-8e33b3041a42"),
                            Name = "warten"
                        },
                        new
                        {
                            Id = new Guid("476b3a0e-f1ed-4405-ad2e-4fc659a76970"),
                            Name = "einfahren"
                        },
                        new
                        {
                            Id = new Guid("bc35d9ba-91e3-4e7e-ae77-6cfd07c8a86e"),
                            Name = "verlassen"
                        },
                        new
                        {
                            Id = new Guid("7e4de35a-66ab-4e49-a147-5c56823e3aa1"),
                            Name = "Medikament abgeben"
                        },
                        new
                        {
                            Id = new Guid("11bec420-4616-4c26-9910-523557ae6503"),
                            Name = "Medikament aufnehmen"
                        });
                });

            modelBuilder.Entity("robodoc.backend.Data.Models.RoboActivityStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ActivityId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoboOrtId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("RoboOrtId");

                    b.ToTable("RoboActivityStatus");
                });

            modelBuilder.Entity("robodoc.backend.Data.Models.RoboOrt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RoboOrt");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab6111b4-6b6f-427d-9edb-b1bbeb9e2af4"),
                            Name = "Apotheke"
                        },
                        new
                        {
                            Id = new Guid("cb32f71a-d688-4bb0-8937-bfb7ade1bf88"),
                            Name = "Parkposition"
                        },
                        new
                        {
                            Id = new Guid("9b2799c1-b0bb-4a40-87ed-7b5cdad3ec8d"),
                            Name = "Zimmer 1"
                        },
                        new
                        {
                            Id = new Guid("6c0a9ebc-793b-42ab-95f9-2ca676269228"),
                            Name = "Zimmer 2"
                        },
                        new
                        {
                            Id = new Guid("282f0ccf-d16b-40d4-91aa-d9163045b13f"),
                            Name = "Zimmer 3"
                        },
                        new
                        {
                            Id = new Guid("8beb8967-df40-4741-8d9f-b0dac6f1e7ac"),
                            Name = "Zimmer 4"
                        });
                });

            modelBuilder.Entity("Robodoc.Data.Models.Medikament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Einheit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Verabreichungsprozess")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medikamente");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e73fc593-f083-4773-b03b-6813b4055a1a"),
                            Einheit = 0,
                            Name = "Pantoloc",
                            Verabreichungsprozess = 1
                        },
                        new
                        {
                            Id = new Guid("57983716-ee82-4492-986f-707fcfec90f1"),
                            Einheit = 0,
                            Name = "Daflon",
                            Verabreichungsprozess = 6
                        },
                        new
                        {
                            Id = new Guid("de033ef6-fdc9-4036-a2ec-fdee4950bb70"),
                            Einheit = 1,
                            Name = "Vivotif",
                            Verabreichungsprozess = 1
                        },
                        new
                        {
                            Id = new Guid("6fae7988-0b53-42a7-9afa-67a05cf03514"),
                            Einheit = 6,
                            Name = "Hepatec",
                            Verabreichungsprozess = 3
                        });
                });

            modelBuilder.Entity("Robodoc.Data.Models.MedikamentTherapie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MedikamentId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Menge")
                        .HasColumnType("int");

                    b.Property<Guid>("TherapieId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("MedikamentId");

                    b.HasIndex("TherapieId");

                    b.ToTable("MedikamentTherapien");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8eeaba4e-fb19-40d9-b0c9-232af9b8bc78"),
                            MedikamentId = new Guid("e73fc593-f083-4773-b03b-6813b4055a1a"),
                            Menge = 5,
                            TherapieId = new Guid("47c7407e-eff5-4b4f-88e1-003009a0cd8d")
                        },
                        new
                        {
                            Id = new Guid("2874d8de-ae55-4f7c-b513-b7d35702aaf4"),
                            MedikamentId = new Guid("57983716-ee82-4492-986f-707fcfec90f1"),
                            Menge = 3,
                            TherapieId = new Guid("47c7407e-eff5-4b4f-88e1-003009a0cd8d")
                        },
                        new
                        {
                            Id = new Guid("24838c3b-b3b8-4319-9029-186e6c0a9309"),
                            MedikamentId = new Guid("57983716-ee82-4492-986f-707fcfec90f1"),
                            Menge = 2,
                            TherapieId = new Guid("ee859e92-0278-4d33-8ae7-2ce3f4b96899")
                        },
                        new
                        {
                            Id = new Guid("46cb64a3-a265-42c9-8b5d-f139301df543"),
                            MedikamentId = new Guid("de033ef6-fdc9-4036-a2ec-fdee4950bb70"),
                            Menge = 1,
                            TherapieId = new Guid("ee859e92-0278-4d33-8ae7-2ce3f4b96899")
                        },
                        new
                        {
                            Id = new Guid("f2d956b0-aef2-42a0-9074-1476a759a219"),
                            MedikamentId = new Guid("de033ef6-fdc9-4036-a2ec-fdee4950bb70"),
                            Menge = 5,
                            TherapieId = new Guid("8c33d707-ab85-4210-bd1f-8da6df53710b")
                        },
                        new
                        {
                            Id = new Guid("cc167b7f-0cf1-48c2-af4f-4f37653b6c88"),
                            MedikamentId = new Guid("6fae7988-0b53-42a7-9afa-67a05cf03514"),
                            Menge = 2,
                            TherapieId = new Guid("12b986f0-4c2f-4cf3-a9ef-f7b085a15546")
                        });
                });

            modelBuilder.Entity("Robodoc.Data.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Anamnese")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("AustrittDatum")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EintrittDatum")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Zimmer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patienten");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68a6d1da-7f81-408b-b62c-53b3d2920c66"),
                            Anamnese = "isch en gaile siech",
                            EintrittDatum = new DateTime(2022, 6, 14, 10, 32, 44, 965, DateTimeKind.Local).AddTicks(1628),
                            Name = "Zingg",
                            Vorname = "Joel",
                            Zimmer = 0
                        });
                });

            modelBuilder.Entity("Robodoc.Data.Models.Therapie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Therapien");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47c7407e-eff5-4b4f-88e1-003009a0cd8d"),
                            Name = "Diät"
                        },
                        new
                        {
                            Id = new Guid("ee859e92-0278-4d33-8ae7-2ce3f4b96899"),
                            Name = "Elektrotherapie"
                        },
                        new
                        {
                            Id = new Guid("8c33d707-ab85-4210-bd1f-8da6df53710b"),
                            Name = "Hydrotherapie"
                        },
                        new
                        {
                            Id = new Guid("12b986f0-4c2f-4cf3-a9ef-f7b085a15546"),
                            Name = "Atlaslogie"
                        });
                });

            modelBuilder.Entity("Robodoc.Data.Models.Therapieverfahren", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ArztId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<TimeSpan>("Intervall")
                        .HasColumnType("time(6)");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PersonalId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("TherapieId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ArztId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PersonalId");

                    b.HasIndex("TherapieId");

                    b.ToTable("Therapieverfahren");
                });

            modelBuilder.Entity("Robodoc.Data.Models.TherapieverfahrenDurchfuehrung", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TherapieverfahrenId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Zeitpunkt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("TherapieverfahrenId");

                    b.ToTable("Durchfuehrungen");
                });

            modelBuilder.Entity("robodoc.backend.Data.Models.RoboActivityStatus", b =>
                {
                    b.HasOne("robodoc.backend.Data.Models.RoboActivity", "RoboActivity")
                        .WithMany("ActivityStatuses")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("robodoc.backend.Data.Models.RoboOrt", "RoboOrt")
                        .WithMany("ActivityStatuses")
                        .HasForeignKey("RoboOrtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoboActivity");

                    b.Navigation("RoboOrt");
                });

            modelBuilder.Entity("Robodoc.Data.Models.MedikamentTherapie", b =>
                {
                    b.HasOne("Robodoc.Data.Models.Medikament", "Medikament")
                        .WithMany()
                        .HasForeignKey("MedikamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Robodoc.Data.Models.Therapie", "Therapie")
                        .WithMany("MedikamentTherapies")
                        .HasForeignKey("TherapieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medikament");

                    b.Navigation("Therapie");
                });

            modelBuilder.Entity("Robodoc.Data.Models.Therapieverfahren", b =>
                {
                    b.HasOne("robodoc.backend.Data.Models.Personal", "Arzt")
                        .WithMany()
                        .HasForeignKey("ArztId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Robodoc.Data.Models.Patient", "Patient")
                        .WithMany("Therapieverfahren")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("robodoc.backend.Data.Models.Personal", "Zustaendigkeit")
                        .WithMany()
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Robodoc.Data.Models.Therapie", "Therapie")
                        .WithMany("Therapieverfahren")
                        .HasForeignKey("TherapieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arzt");

                    b.Navigation("Patient");

                    b.Navigation("Therapie");

                    b.Navigation("Zustaendigkeit");
                });

            modelBuilder.Entity("Robodoc.Data.Models.TherapieverfahrenDurchfuehrung", b =>
                {
                    b.HasOne("Robodoc.Data.Models.Therapieverfahren", "Therapieverfahren")
                        .WithMany("TherapieverfahrenDurchfuehrungen")
                        .HasForeignKey("TherapieverfahrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Therapieverfahren");
                });

            modelBuilder.Entity("robodoc.backend.Data.Models.RoboActivity", b =>
                {
                    b.Navigation("ActivityStatuses");
                });

            modelBuilder.Entity("robodoc.backend.Data.Models.RoboOrt", b =>
                {
                    b.Navigation("ActivityStatuses");
                });

            modelBuilder.Entity("Robodoc.Data.Models.Patient", b =>
                {
                    b.Navigation("Therapieverfahren");
                });

            modelBuilder.Entity("Robodoc.Data.Models.Therapie", b =>
                {
                    b.Navigation("MedikamentTherapies");

                    b.Navigation("Therapieverfahren");
                });

            modelBuilder.Entity("Robodoc.Data.Models.Therapieverfahren", b =>
                {
                    b.Navigation("TherapieverfahrenDurchfuehrungen");
                });
#pragma warning restore 612, 618
        }
    }
}
