﻿// <auto-generated />
using CourseProjectBlazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseProjectBlazor.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210216193809_initial-commit")]
    partial class initialcommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Cooling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RamCooling");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.FormFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RamFormFactor");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RamManufacturer");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Ram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CoolingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FormFactorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Frequency")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Latency")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModuleAmount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OneModuleSize")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RasToCasDelay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RowPrechargeDelay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Throughput")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Voltage")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CoolingId");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("TypeId");

                    b.ToTable("Ram");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RamType");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Ram", b =>
                {
                    b.HasOne("CourseProjectBlazor.Models.Ram.Cooling", "Cooling")
                        .WithMany("Rams")
                        .HasForeignKey("CoolingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseProjectBlazor.Models.Ram.FormFactor", "FormFactor")
                        .WithMany("Rams")
                        .HasForeignKey("FormFactorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseProjectBlazor.Models.Ram.Manufacturer", "Manufacturer")
                        .WithMany("Rams")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseProjectBlazor.Models.Ram.Type", "Type")
                        .WithMany("Rams")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cooling");

                    b.Navigation("FormFactor");

                    b.Navigation("Manufacturer");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Cooling", b =>
                {
                    b.Navigation("Rams");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.FormFactor", b =>
                {
                    b.Navigation("Rams");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Manufacturer", b =>
                {
                    b.Navigation("Rams");
                });

            modelBuilder.Entity("CourseProjectBlazor.Models.Ram.Type", b =>
                {
                    b.Navigation("Rams");
                });
#pragma warning restore 612, 618
        }
    }
}
