﻿// <auto-generated />
using System;
using System.Collections.Generic;
using ConnectionNPG.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConnectionNPG.Migrations
{
    [DbContext(typeof(AppDbContext.AppDbContext))]
    [Migration("20230810095453_Init2")]
    partial class Init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConnectionNPG.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Desc")
                        .HasColumnType("text");

                    b.Property<string>("DocumentPath")
                        .HasColumnType("text");

                    b.Property<Guid?>("Task_Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("User_Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<string>("ReturnCall")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("DescriptionCourse_Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.DescriptionCourse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Course_Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Review")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DescriptionCourses");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Homework", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("Task_Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("User_Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Homework");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Course_Id")
                        .HasColumnType("uuid");

                    b.Property<List<string>>("Info")
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<List<string>>("VideoUrl")
                        .HasColumnType("text[]");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Result", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DescriptionCourse_Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ImgPath")
                        .HasColumnType("text");

                    b.Property<Guid?>("User_Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("DescriptionCourse_Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Comment_Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Desc")
                        .HasColumnType("text");

                    b.Property<Guid?>("Lesson_Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Desc")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<List<string>>("Choices")
                        .HasColumnType("text[]");

                    b.Property<int?>("CorrectAnswerQuestion")
                        .HasColumnType("integer");

                    b.Property<string>("QuestionText")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("ConnectionNPG.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
