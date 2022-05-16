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
                            Id = new Guid("d1ecbaf4-ac58-438f-954e-af296126ed2c"),
                            Name = "warten"
                        },
                        new
                        {
                            Id = new Guid("a4d92082-eca4-44e9-806a-2aca14c67453"),
                            Name = "einfahren"
                        },
                        new
                        {
                            Id = new Guid("68c9753e-7b98-4064-8fce-52587b242231"),
                            Name = "verlassen"
                        },
                        new
                        {
                            Id = new Guid("7168d446-2732-417b-b4ea-82b8cb2a79d1"),
                            Name = "Medikament abgeben"
                        },
                        new
                        {
                            Id = new Guid("02cfec77-0a69-4156-afd1-226fee6fd1cd"),
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
                            Id = new Guid("036dcb0c-f639-424d-b6fc-6a3742e4a88a"),
                            Name = "Apotheke"
                        },
                        new
                        {
                            Id = new Guid("8861eefa-4235-4759-a890-2ef42f3808d5"),
                            Name = "Parkposition"
                        },
                        new
                        {
                            Id = new Guid("86c23d03-e6a7-4003-82a4-d3e8828c3d8c"),
                            Name = "Zimmer 1"
                        },
                        new
                        {
                            Id = new Guid("a6cf04af-ef7d-457a-94d6-44aa5c56012a"),
                            Name = "Zimmer 2"
                        },
                        new
                        {
                            Id = new Guid("6b40a360-8347-4207-99e7-3480fd320386"),
                            Name = "Zimmer 3"
                        },
                        new
                        {
                            Id = new Guid("4b6ffeba-236c-4f4e-be65-5b1c041787e4"),
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
                            Id = new Guid("1eadca3b-e296-4140-8d19-e8e3e060a932"),
                            Einheit = 0,
                            Name = "Pantoloc",
                            Verabreichungsprozess = 1
                        },
                        new
                        {
                            Id = new Guid("b991718c-993f-4e5a-9456-187f9f9ed026"),
                            Einheit = 0,
                            Name = "Daflon",
                            Verabreichungsprozess = 6
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
                            Id = new Guid("b1152b78-60dd-4d4d-896c-1720fb34adcf"),
                            MedikamentId = new Guid("1eadca3b-e296-4140-8d19-e8e3e060a932"),
                            Menge = 5,
                            TherapieId = new Guid("f3a55eb6-7b71-49d1-a99e-c6eeb31f10e4")
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
                            Id = new Guid("82193335-8a66-4c5e-92b1-c9907acfe71f"),
                            Anamnese = "isch en gaile siech",
                            EintrittDatum = new DateTime(2022, 5, 16, 19, 30, 40, 996, DateTimeKind.Local).AddTicks(1127),
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
                            Id = new Guid("f3a55eb6-7b71-49d1-a99e-c6eeb31f10e4"),
                            Name = "Diät"
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
