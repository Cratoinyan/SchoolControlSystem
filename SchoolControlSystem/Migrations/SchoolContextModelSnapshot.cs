﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolControlSystem.DataBase;

namespace SchoolControlSystem.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolControlSystem.Model.AcademicStaff", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("academicStaffs");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Course", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("instructorID")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.HasIndex("instructorID");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.CourseGrades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode");

                    b.HasIndex("StudentID");

                    b.ToTable("courseGrades");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.CourseSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.Property<int>("endHour")
                        .HasColumnType("int");

                    b.Property<int>("initialHour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode");

                    b.ToTable("CourseSchedule");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("students");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Course", b =>
                {
                    b.HasOne("SchoolControlSystem.Model.Instructor", "instructor")
                        .WithMany("course")
                        .HasForeignKey("instructorID");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.CourseGrades", b =>
                {
                    b.HasOne("SchoolControlSystem.Model.Course", "Course")
                        .WithMany("CourseGrades")
                        .HasForeignKey("CourseCode");

                    b.HasOne("SchoolControlSystem.Model.Student", "Student")
                        .WithMany("grades")
                        .HasForeignKey("StudentID");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.CourseSchedule", b =>
                {
                    b.HasOne("SchoolControlSystem.Model.Course", "Course")
                        .WithMany("courseSchedules")
                        .HasForeignKey("CourseCode");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Course", b =>
                {
                    b.Navigation("CourseGrades");

                    b.Navigation("courseSchedules");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Instructor", b =>
                {
                    b.Navigation("course");
                });

            modelBuilder.Entity("SchoolControlSystem.Model.Student", b =>
                {
                    b.Navigation("grades");
                });
#pragma warning restore 612, 618
        }
    }
}
