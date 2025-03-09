﻿// <auto-generated />
using System;
using BookOfHabitsMicroservice.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookOfHabitsMicroservice.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<byte[]>("Image")
                        .HasMaxLength(25000)
                        .HasColumnType("bytea");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Options")
                        .HasColumnType("integer");

                    b.Property<Guid>("TemplateValuesId")
                        .HasColumnType("uuid");

                    b.Property<string>("TitlesCheck")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("character varying(1500)");

                    b.HasKey("Id");

                    b.HasIndex("TemplateValuesId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Coins", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CostOfWinning")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("Falls")
                        .HasColumnType("integer");

                    b.Property<int>("Forfeit")
                        .HasColumnType("integer");

                    b.Property<Guid>("HabitId")
                        .HasColumnType("uuid");

                    b.Property<int>("Options")
                        .HasColumnType("integer");

                    b.Property<Guid>("RoomId1")
                        .HasColumnType("uuid");

                    b.Property<int>("Start")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.HasIndex("RoomId1");

                    b.ToTable("Вags");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Habit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DelayId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Options")
                        .HasColumnType("integer");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RepetitionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TimeResetIntervalId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DelayId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RepetitionId");

                    b.HasIndex("RoomId");

                    b.HasIndex("TimeResetIntervalId");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Propertys.Delay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AfterTime")
                        .HasColumnType("integer");

                    b.Property<int>("DurationTime")
                        .HasColumnType("integer");

                    b.Property<bool>("IsAfterATime")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsEndless")
                        .HasColumnType("boolean");

                    b.Property<string>("NameType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("DelayProperties");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Propertys.Repetition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CountLimit")
                        .HasColumnType("integer");

                    b.Property<bool>("IsLimit")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxCountNegative")
                        .HasColumnType("integer");

                    b.Property<int>("MaxCountPositive")
                        .HasColumnType("integer");

                    b.Property<string>("NameType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("RepetitionProperties");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Propertys.TemplateValues", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("StatusString")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("TagsString")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("TitleCheck")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("TitleNegative")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("TitlePositive")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("TitleReportField")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("TitleValue")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Signatures");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Propertys.TimeResetInterval", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("NumberDayOfTheMonth")
                        .HasColumnType("integer");

                    b.Property<int>("Options")
                        .HasColumnType("integer");

                    b.Property<int>("TimeTheDay")
                        .HasColumnType("integer");

                    b.Property<int>("WeekDays")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TimeResetIntervalProperties");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Card", b =>
                {
                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Propertys.TemplateValues", "TemplateValues")
                        .WithMany()
                        .HasForeignKey("TemplateValuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TemplateValues");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Coins", b =>
                {
                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Habit", "Habit")
                        .WithMany()
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Room", "Room")
                        .WithMany("_bags")
                        .HasForeignKey("RoomId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habit");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Habit", b =>
                {
                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Propertys.Delay", "Delay")
                        .WithMany()
                        .HasForeignKey("DelayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Person", "Owner")
                        .WithMany("_habits")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Propertys.Repetition", "Repetition")
                        .WithMany()
                        .HasForeignKey("RepetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Room", "Room")
                        .WithMany("_habits")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Propertys.TimeResetInterval", "TimeResetInterval")
                        .WithMany()
                        .HasForeignKey("TimeResetIntervalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Delay");

                    b.Navigation("Owner");

                    b.Navigation("Repetition");

                    b.Navigation("Room");

                    b.Navigation("TimeResetInterval");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Room", b =>
                {
                    b.HasOne("BookOfHabitsMicroservice.Domain.Entity.Person", "Manager")
                        .WithMany("_rooms")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Person", b =>
                {
                    b.Navigation("_habits");

                    b.Navigation("_rooms");
                });

            modelBuilder.Entity("BookOfHabitsMicroservice.Domain.Entity.Room", b =>
                {
                    b.Navigation("_bags");

                    b.Navigation("_habits");
                });
#pragma warning restore 612, 618
        }
    }
}
