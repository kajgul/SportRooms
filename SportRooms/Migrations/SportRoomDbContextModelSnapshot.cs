﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportRooms.Entities;

namespace SportRooms.Migrations
{
    [DbContext(typeof(SportRoomDbContext))]
    partial class SportRoomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SportRooms.Entities.Bet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("TeamABet")
                        .HasColumnType("int");

                    b.Property<int>("TeamBBet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("RoomId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("SportRooms.Entities.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("SportRooms.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfMatch")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("RoundNumber")
                        .HasColumnType("int");

                    b.Property<string>("TeamAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("TeamAScore")
                        .HasColumnType("tinyint");

                    b.Property<string>("TeamBName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("TeamBScore")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.HasIndex("RoomId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("SportRooms.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SportRooms.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("SportRooms.Entities.Bet", b =>
                {
                    b.HasOne("SportRooms.Entities.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportRooms.Entities.Player", "Player")
                        .WithMany("Bets")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SportRooms.Entities.Room", null)
                        .WithMany("Bets")
                        .HasForeignKey("RoomId");

                    b.Navigation("Match");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("SportRooms.Entities.Match", b =>
                {
                    b.HasOne("SportRooms.Entities.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportRooms.Entities.Room", null)
                        .WithMany("Matches")
                        .HasForeignKey("RoomId");

                    b.Navigation("League");
                });

            modelBuilder.Entity("SportRooms.Entities.Player", b =>
                {
                    b.HasOne("SportRooms.Entities.Room", "Room")
                        .WithMany("Players")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("SportRooms.Entities.Room", b =>
                {
                    b.HasOne("SportRooms.Entities.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("SportRooms.Entities.Player", b =>
                {
                    b.Navigation("Bets");
                });

            modelBuilder.Entity("SportRooms.Entities.Room", b =>
                {
                    b.Navigation("Bets");

                    b.Navigation("Matches");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}