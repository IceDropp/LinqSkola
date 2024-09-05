﻿// <auto-generated />
using System;
using LinqSkola.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LinqSchool.Migrations
{
    [DbContext(typeof(LinqSkolaDbContext))]
    partial class LinqSkolaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LinqSkola.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "3A"
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "3B"
                        },
                        new
                        {
                            ClassId = 3,
                            ClassName = "4A"
                        },
                        new
                        {
                            ClassId = 4,
                            ClassName = "4B"
                        });
                });

            modelBuilder.Entity("LinqSkola.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("StudentFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ClassId = 1,
                            StudentFirstName = "Lars",
                            StudentLastName = "Trollsten",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            ClassId = 2,
                            StudentFirstName = "Eva",
                            StudentLastName = "Svensson"
                        },
                        new
                        {
                            StudentId = 3,
                            ClassId = 3,
                            StudentFirstName = "Carl",
                            StudentLastName = "Erikrson"
                        },
                        new
                        {
                            StudentId = 4,
                            ClassId = 4,
                            StudentFirstName = "Tore",
                            StudentLastName = "Jansson"
                        },
                        new
                        {
                            StudentId = 5,
                            ClassId = 1,
                            StudentFirstName = "Frida",
                            StudentLastName = "Svensson"
                        },
                        new
                        {
                            StudentId = 6,
                            ClassId = 2,
                            StudentFirstName = "Niklas",
                            StudentLastName = "MacMillan",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            ClassId = 3,
                            StudentFirstName = "Adam",
                            StudentLastName = "Andersson"
                        },
                        new
                        {
                            StudentId = 8,
                            ClassId = 4,
                            StudentFirstName = "Joel",
                            StudentLastName = "Westin"
                        },
                        new
                        {
                            StudentId = 9,
                            ClassId = 4,
                            StudentFirstName = "Lina",
                            StudentLastName = "Colfer",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 10,
                            ClassId = 2,
                            StudentFirstName = "Pia",
                            StudentLastName = "Kres",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 11,
                            ClassId = 1,
                            StudentFirstName = "Anna",
                            StudentLastName = "Stark",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 12,
                            ClassId = 3,
                            StudentFirstName = "Mia",
                            StudentLastName = "DeGeer",
                            TeacherId = 1
                        });
                });

            modelBuilder.Entity("LinqSkola.Models.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjects");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 8,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 9,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 10,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 11,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 12,
                            SubjectId = 1
                        });
                });

            modelBuilder.Entity("LinqSkola.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            SubjectName = "Programming 1"
                        },
                        new
                        {
                            SubjectId = 2,
                            SubjectName = "Programming 2"
                        },
                        new
                        {
                            SubjectId = 3,
                            SubjectName = "Science"
                        },
                        new
                        {
                            SubjectId = 4,
                            SubjectName = "Math"
                        },
                        new
                        {
                            SubjectId = 5,
                            SubjectName = "Chemistry"
                        });
                });

            modelBuilder.Entity("LinqSkola.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("TeacherFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            TeacherFirstName = "Niclas",
                            TeacherLastName = "Jonsn"
                        },
                        new
                        {
                            TeacherId = 2,
                            TeacherFirstName = "Frida",
                            TeacherLastName = "Annadotter"
                        },
                        new
                        {
                            TeacherId = 3,
                            TeacherFirstName = "Frodo",
                            TeacherLastName = "Bylke"
                        });
                });

            modelBuilder.Entity("LinqSkola.Models.TeacherSubject", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("TeacherSubjects");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            TeacherId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            TeacherId = 1,
                            SubjectId = 4
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectId = 5
                        });
                });

            modelBuilder.Entity("LinqSkola.Models.Student", b =>
                {
                    b.HasOne("LinqSkola.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("LinqSkola.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Class");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LinqSkola.Models.StudentSubject", b =>
                {
                    b.HasOne("LinqSkola.Models.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LinqSkola.Models.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("LinqSkola.Models.TeacherSubject", b =>
                {
                    b.HasOne("LinqSkola.Models.Subject", "Subject")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LinqSkola.Models.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LinqSkola.Models.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("LinqSkola.Models.Subject", b =>
                {
                    b.Navigation("StudentSubjects");

                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("LinqSkola.Models.Teacher", b =>
                {
                    b.Navigation("TeacherSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}