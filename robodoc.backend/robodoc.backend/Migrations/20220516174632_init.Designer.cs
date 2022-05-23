﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using robodoc.backend.Data;

#nullable disable

namespace robodoc.backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220516174632_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("9dd7762a-5b17-4635-9124-65634531e71e"),
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
                            Id = new Guid("07542230-584c-44c0-ac70-3481bbfc99be"),
                            Name = "warten"
                        },
                        new
                        {
                            Id = new Guid("c3065d9c-e0fb-48d2-ba40-eb6eaa1951f7"),
                            Name = "einfahren"
                        },
                        new
                        {
                            Id = new Guid("48fa61dd-803a-434a-b103-cfc4266ab27c"),
                            Name = "verlassen"
                        },
                        new
                        {
                            Id = new Guid("76a0100f-ccc3-4e5f-a799-53ff26f439c7"),
                            Name = "Medikament abgeben"
                        },
                        new
                        {
                            Id = new Guid("562e445f-96cb-46a6-ab70-15edfdbd2bb1"),
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
                            Id = new Guid("ad4cadca-19a1-4141-a630-f26b2c9e4892"),
                            Name = "Apotheke"
                        },
                        new
                        {
                            Id = new Guid("3f501665-260f-4b85-b891-60ca4c765405"),
                            Name = "Parkposition"
                        },
                        new
                        {
                            Id = new Guid("12c11030-cb7c-4bd7-92d1-b6975a497a2a"),
                            Name = "Zimmer 1"
                        },
                        new
                        {
                            Id = new Guid("2f7a49c9-a6cc-48d0-8265-d844dd90081a"),
                            Name = "Zimmer 2"
                        },
                        new
                        {
                            Id = new Guid("a6a0073c-96f2-4078-b43a-d0bc650133a9"),
                            Name = "Zimmer 3"
                        },
                        new
                        {
                            Id = new Guid("5aa01803-2323-4f58-aea8-1187d62eb94d"),
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
                            Id = new Guid("ea611dd3-9cb5-4db1-b04a-1a3afa21acbf"),
                            Einheit = 0,
                            Name = "Pantoloc",
                            Verabreichungsprozess = 1
                        },
                        new
                        {
                            Id = new Guid("fe453955-3b6c-4606-b852-275872fadde0"),
                            Einheit = 0,
                            Name = "Daflon",
                            Verabreichungsprozess = 6
                        },
                        new
                        {
                            Id = new Guid("8086a12c-f11f-4e6e-b4c2-8124cbd21e23"),
                            Einheit = 1,
                            Name = "Vivotif",
                            Verabreichungsprozess = 1
                        },
                        new
                        {
                            Id = new Guid("8b2b4bc6-833d-4df1-a3b9-dadedf5755c6"),
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
                            Id = new Guid("1ecf928b-ca90-4927-a1d9-8657dc49317e"),
                            MedikamentId = new Guid("ea611dd3-9cb5-4db1-b04a-1a3afa21acbf"),
                            Menge = 5,
                            TherapieId = new Guid("238543bc-eaf0-4919-a076-c11229cc718f")
                        },
                        new
                        {
                            Id = new Guid("eba32032-5d56-49a2-8166-5f62ff32ed69"),
                            MedikamentId = new Guid("fe453955-3b6c-4606-b852-275872fadde0"),
                            Menge = 3,
                            TherapieId = new Guid("238543bc-eaf0-4919-a076-c11229cc718f")
                        },
                        new
                        {
                            Id = new Guid("46ea95d5-3d9e-4e1d-88f0-31196acf383c"),
                            MedikamentId = new Guid("fe453955-3b6c-4606-b852-275872fadde0"),
                            Menge = 2,
                            TherapieId = new Guid("ef543ba8-fc95-4314-802b-850eb136d121")
                        },
                        new
                        {
                            Id = new Guid("c7f9922b-ea09-4de5-b72d-a16a7845b146"),
                            MedikamentId = new Guid("8086a12c-f11f-4e6e-b4c2-8124cbd21e23"),
                            Menge = 1,
                            TherapieId = new Guid("ef543ba8-fc95-4314-802b-850eb136d121")
                        },
                        new
                        {
                            Id = new Guid("8e510409-7c1a-4108-8864-3265316f293c"),
                            MedikamentId = new Guid("8086a12c-f11f-4e6e-b4c2-8124cbd21e23"),
                            Menge = 5,
                            TherapieId = new Guid("7138c4be-6a93-47bb-90b9-ce7441b01259")
                        },
                        new
                        {
                            Id = new Guid("b6e75cda-9106-4a85-812c-247407fc11dc"),
                            MedikamentId = new Guid("8b2b4bc6-833d-4df1-a3b9-dadedf5755c6"),
                            Menge = 2,
                            TherapieId = new Guid("5c74a333-a50f-4304-9734-3bd9d2864790")
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
                            Id = new Guid("845afdb7-599f-4aa7-9e7e-2b9f0e5e6c2b"),
                            Anamnese = "isch en gaile siech",
                            EintrittDatum = new DateTime(2022, 5, 16, 19, 46, 32, 575, DateTimeKind.Local).AddTicks(4232),
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
                            Id = new Guid("238543bc-eaf0-4919-a076-c11229cc718f"),
                            Name = "Diät"
                        },
                        new
                        {
                            Id = new Guid("ef543ba8-fc95-4314-802b-850eb136d121"),
                            Name = "Elektrotherapie"
                        },
                        new
                        {
                            Id = new Guid("7138c4be-6a93-47bb-90b9-ce7441b01259"),
                            Name = "Hydrotherapie"
                        },
                        new
                        {
                            Id = new Guid("5c74a333-a50f-4304-9734-3bd9d2864790"),
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
                        .WithMany("MedikamentTherapies")
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

            modelBuilder.Entity("Robodoc.Data.Models.Medikament", b =>
                {
                    b.Navigation("MedikamentTherapies");
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
