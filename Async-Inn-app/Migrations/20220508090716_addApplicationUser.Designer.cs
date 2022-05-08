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
    [Migration("20220508090716_addApplicationUser")]
    partial class addApplicationUser
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
                        },
                        new
                        {
                            amenitiesId = 22,
                            description = "haveing a romantic mode with flour for couples",
                            name = "Romantic mode",
                            price = 70m
                        },
                        new
                        {
                            amenitiesId = 23,
                            description = "have fancy library with more than 100 book",
                            name = "fancy library",
                            price = 20m
                        });
                });

            modelBuilder.Entity("Async_Inn_app.models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

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
                            PetFriendly = true,
                            nickName = "Restful Rainier",
                            price = 29.9m,
                            space = 2,
                            visitorId = 0
                        },
                        new
                        {
                            hotelId = 1,
                            roomId = 102,
                            PetFriendly = false,
                            nickName = "Seahawks Snooze",
                            price = 45m,
                            space = 2,
                            visitorId = 0
                        },
                        new
                        {
                            hotelId = 2,
                            roomId = 101,
                            PetFriendly = true,
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

                    b.Property<bool>("canRemove")
                        .HasColumnType("bit");

                    b.HasKey("hotelId", "roomId", "amenitiesId");

                    b.HasIndex("amenitiesId");

                    b.ToTable("RoomsAmenities");

                    b.HasData(
                        new
                        {
                            hotelId = 1,
                            roomId = 101,
                            amenitiesId = 11,
                            canRemove = true
                        },
                        new
                        {
                            hotelId = 2,
                            roomId = 101,
                            amenitiesId = 11,
                            canRemove = false
                        },
                        new
                        {
                            hotelId = 1,
                            roomId = 101,
                            amenitiesId = 21,
                            canRemove = false
                        },
                        new
                        {
                            hotelId = 1,
                            roomId = 102,
                            amenitiesId = 22,
                            canRemove = true
                        },
                        new
                        {
                            hotelId = 1,
                            roomId = 102,
                            amenitiesId = 23,
                            canRemove = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
                        .WithMany("rooms")
                        .HasForeignKey("hotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelBranches");
                });

            modelBuilder.Entity("Async_Inn_app.models.RoomsAmenities", b =>
                {
                    b.HasOne("Async_Inn_app.models.Amenities", "Amenities")
                        .WithMany("roomsAmenities")
                        .HasForeignKey("amenitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn_app.models.Rooms", "Rooms")
                        .WithMany("roomsAmenities")
                        .HasForeignKey("hotelId", "roomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenities");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Async_Inn_app.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Async_Inn_app.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn_app.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Async_Inn_app.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Async_Inn_app.models.Amenities", b =>
                {
                    b.Navigation("roomsAmenities");
                });

            modelBuilder.Entity("Async_Inn_app.models.HotelBranches", b =>
                {
                    b.Navigation("rooms");
                });

            modelBuilder.Entity("Async_Inn_app.models.Rooms", b =>
                {
                    b.Navigation("roomsAmenities");
                });
#pragma warning restore 612, 618
        }
    }
}