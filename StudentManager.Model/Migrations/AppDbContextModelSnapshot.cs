﻿// <auto-generated />
using System;
using Fitness.Infrastracture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace StudentManager.Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentManager.Backend.Entities.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Period")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Achievement");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountOfRepeats")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FitnessTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FitnessTypeId")
                        .IsUnique();

                    b.ToTable("FitnessProgram");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessTip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("FitnessProgramId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("FitnessProgramId");

                    b.ToTable("FitnessTip");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessType", b =>
                {
                    b.Property<int>("FitnessProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FitnessProgramId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FitnessProgramId");

                    b.ToTable("FitnessType");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.LogModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthdayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.PersonFitnessProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FitnessProgramId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FitnessProgramId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonFitnessProgram");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AchievementId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("FitnessProgramId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.HasIndex("FitnessProgramId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Achievement", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.Person", "Person")
                        .WithMany("Achievements")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Exercise", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.Training", "Training")
                        .WithMany("Exercises")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessProgram", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.FitnessType", "FitnessType")
                        .WithOne("FitnessProgram")
                        .HasForeignKey("StudentManager.Backend.Entities.FitnessProgram", "FitnessTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessType");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessTip", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.FitnessProgram", "FitnessProgram")
                        .WithMany("FitnessTips")
                        .HasForeignKey("FitnessProgramId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FitnessProgram");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.PersonFitnessProgram", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.FitnessProgram", "FitnessProgram")
                        .WithMany("PersonFitnessPrograms")
                        .HasForeignKey("FitnessProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManager.Backend.Entities.Person", "Person")
                        .WithMany("PersonFitnessPrograms")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessProgram");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Training", b =>
                {
                    b.HasOne("StudentManager.Backend.Entities.Achievement", null)
                        .WithMany("Trainings")
                        .HasForeignKey("AchievementId");

                    b.HasOne("StudentManager.Backend.Entities.FitnessProgram", "FitnessProgram")
                        .WithMany("Trainings")
                        .HasForeignKey("FitnessProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessProgram");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Achievement", b =>
                {
                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessProgram", b =>
                {
                    b.Navigation("FitnessTips");

                    b.Navigation("PersonFitnessPrograms");

                    b.Navigation("Trainings");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.FitnessType", b =>
                {
                    b.Navigation("FitnessProgram")
                        .IsRequired();
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Person", b =>
                {
                    b.Navigation("Achievements");

                    b.Navigation("PersonFitnessPrograms");
                });

            modelBuilder.Entity("StudentManager.Backend.Entities.Training", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
