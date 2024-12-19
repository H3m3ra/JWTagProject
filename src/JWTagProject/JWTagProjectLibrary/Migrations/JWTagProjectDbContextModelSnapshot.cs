﻿// <auto-generated />
using System;
using JWTagProjectLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JWTagProjectLibrary.Migrations
{
    [DbContext(typeof(JWTagProjectDbContext))]
    partial class JWTagProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ExerciseTag", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExerciseTag");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quarter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.ExamType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExamTypes");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ExerciseTag", b =>
                {
                    b.HasOne("JWTagProjectLibrary.BDO.Exercise", null)
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JWTagProjectLibrary.BDO.Tag", null)
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Exam", b =>
                {
                    b.HasOne("JWTagProjectLibrary.BDO.ExamType", "Type")
                        .WithMany("NavExams")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JWTagProjectLibrary.BDO.Faculty", "Faculty")
                        .WithMany("NavExams")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Exercise", b =>
                {
                    b.HasOne("JWTagProjectLibrary.BDO.Exam", "Exam")
                        .WithMany("NavExercises")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Exam", b =>
                {
                    b.Navigation("NavExercises");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.ExamType", b =>
                {
                    b.Navigation("NavExams");
                });

            modelBuilder.Entity("JWTagProjectLibrary.BDO.Faculty", b =>
                {
                    b.Navigation("NavExams");
                });
#pragma warning restore 612, 618
        }
    }
}
