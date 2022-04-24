﻿// <auto-generated />
using System;
using Async_Inn_app.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Async_Inn_app.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20220424124810_addRoomsAmenities")]
    partial class addRoomsAmenities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Async_Inn_app.models.Amenities", b =>
                {
                    b.Property<int>("amenitiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("amenitiesId");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            amenitiesId = 11,
                            description = "have a coffee maker with unlimited drink amounts from machine choices.",
                            name = "coffee maker",
                            price = 25m
                        },
                        new
                        {
                            amenitiesId = 21,
                            description = "have a view from the window on the ocean.",
                            name = "ocean view",
                            price = 35m
                        },
                        new
                        {
                            amenitiesId = 31,
                            description = "Have a mini bar in your rome with a discount of 25% on drinks from it.",
                            name = "mini bar",
                            price = 40m
                        });
                });

            modelBuilder.Entity("Async_Inn_app.models.Employees", b =>
                {
                    b.Property<int>("empId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelBrancheshotelId")
                        .HasColumnType("int");

                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("workTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empId");

                    b.HasIndex("HotelBrancheshotelId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Async_Inn_app.models.HotelBranches", b =>
                {
                    b.Property<int>("hotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roomsNum")
                        .HasColumnType("int");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hotelId");

                    b.ToTable("HotelBranches");

                    b.HasData(
                        new
                        {
                            hotelId = 1,
                            address = "Downtoun-ALsame street ",
                            city = "jordan",
                            name = "Downtown Branch",
                            phoneNum = "00963323423212",
                            roomsNum = 30,
                            state = "amman"
                        },
                        new
                        {
                            hotelId = 2,
                            address = " ali street",
                            city = "jordan",
                            name = "Zarqa Branch",
                            phoneNum = "00962790941468",
                            roomsNum = 40,
                            state = "Zarqa"
                        },
                        new
                        {
                            hotelId = 13,
                            address = "AL-waseh street",
                            city = "jordan",
                            name = "Karak Branch",
                            phoneNum = "00962301520123",
                            roomsNum = 90,
                            state = "Karak"
                        });
                });

            modelBuilder.Entity("Async_Inn_app.models.Rooms", b =>
                {
                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<int>("roomId")
                        .HasColumnType("int");

                    b.Property<string>("nickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("space")
                        .HasColumnType("int");

                    b.Property<int>("visitorId")
                        .HasColumnType("int");

                    b.HasKey("hotelId", "roomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            hotelId = 1,
                            roomId = 101,
                            nickName = "Restful Rainier",
                            price = 29.9m,
                            space = 2,
                            visitorId = 0
                        },
                        new
                        {
                            hotelId = 1,
                            roomId = 102,
                            nickName = "Seahawks Snooze",
                            price = 45m,
                            space = 2,
                            visitorId = 0
                        },
                        new
                        {
                            hotelId = 2,
                            roomId = 101,
                            nickName = "Golden hat",
                            price = 75m,
                            space = 3,
                            visitorId = 0
                        });
                });

            modelBuilder.Entity("Async_Inn_app.models.RoomsAmenities", b =>
                {
                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<int>("roomId")
                        .HasColumnType("int");

                    b.Property<int>("amenitiesId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomshotelId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomsroomId")
                        .HasColumnType("int");

                    b.Property<bool>("canRemove")
                        .HasColumnType("bit");

                    b.HasKey("hotelId", "roomId", "amenitiesId");

                    b.HasIndex("amenitiesId");

                    b.HasIndex("RoomshotelId", "RoomsroomId");

                    b.ToTable("RoomsAmenities");
                });

            modelBuilder.Entity("Async_Inn_app.models.Employees", b =>
                {
                    b.HasOne("Async_Inn_app.models.HotelBranches", "HotelBranches")
                        .WithMany()
                        .HasForeignKey("HotelBrancheshotelId");

                    b.Navigation("HotelBranches");
                });

            modelBuilder.Entity("Async_Inn_app.models.Rooms", b =>
                {
                    b.HasOne("Async_Inn_app.models.HotelBranches", "HotelBranches")
                        .WithMany()
                        .HasForeignKey("hotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelBranches");
                });

            modelBuilder.Entity("Async_Inn_app.models.RoomsAmenities", b =>
                {
                    b.HasOne("Async_Inn_app.models.Amenities", "Amenities")
                        .WithMany()
                        .HasForeignKey("amenitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn_app.models.Rooms", "Rooms")
                        .WithMany()
                        .HasForeignKey("RoomshotelId", "RoomsroomId");

                    b.Navigation("Amenities");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
