﻿// <auto-generated />
using System;
using CampusBookingAPI.DbContextMysql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampusBookingAPI.Migrations
{
    [DbContext(typeof(CampusApiDbContext))]
    partial class CampusApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("CampusBookingAPI.Model.Bookings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("className")
                        .HasColumnType("text");

                    b.Property<int?>("roomId")
                        .HasColumnType("int");

                    b.Property<byte?>("seatsBooked")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("timeEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("timeStart")
                        .HasColumnType("datetime");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("roomId");

                    b.HasIndex("userId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Ratings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("RoomsId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .HasColumnType("text");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomsId");

                    b.HasIndex("UsersId");

                    b.ToTable("rating");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Rooms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("equipment")
                        .HasColumnType("text");

                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("roomName")
                        .HasColumnType("text");

                    b.Property<byte>("seating")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("typeOfRoom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<int>("typeofAccount")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Bookings", b =>
                {
                    b.HasOne("CampusBookingAPI.Model.Rooms", "room")
                        .WithMany("bookings")
                        .HasForeignKey("roomId");

                    b.HasOne("CampusBookingAPI.Model.Users", "user")
                        .WithMany("bookings")
                        .HasForeignKey("userId");

                    b.Navigation("room");

                    b.Navigation("user");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Ratings", b =>
                {
                    b.HasOne("CampusBookingAPI.Model.Rooms", null)
                        .WithMany("Rating")
                        .HasForeignKey("RoomsId");

                    b.HasOne("CampusBookingAPI.Model.Users", null)
                        .WithMany("Rated")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Rooms", b =>
                {
                    b.Navigation("bookings");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("CampusBookingAPI.Model.Users", b =>
                {
                    b.Navigation("bookings");

                    b.Navigation("Rated");
                });
#pragma warning restore 612, 618
        }
    }
}
