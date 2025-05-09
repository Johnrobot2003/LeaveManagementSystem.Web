﻿// <auto-generated />
using System;
using LeaveManagementSystem.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250326085604_AddNewAdmin")]
    partial class AddNewAdmin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LeaveManagementSystem.Web.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2af3bd28-fdd6-4d4c-8c24-23f170ad58bb",
                            DateOfBirth = new DateOnly(2003, 1, 23),
                            Email = "adminemail@user.com",
                            EmailConfirmed = true,
                            FirstName = "Default",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINEMAIL@USER.COM",
                            NormalizedUserName = "ADMINEMAIL@USER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEC4wutt5r0nibVbELwF3IYxQJ44hVnfEcj/Q/P8cgFx9oOL0KnbV+JxA1qqsZTRFsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5d9a2fb2-b6fb-4b5d-8eeb-e4d66790f87d",
                            TwoFactorEnabled = false,
                            UserName = "adminemail@user.com"
                        },
                        new
                        {
                            Id = "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5bb96bd8-38b6-4255-a813-85359447685f",
                            DateOfBirth = new DateOnly(2003, 1, 23),
                            Email = "secondadmin@user.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Admin3",
                            LockoutEnabled = false,
                            NormalizedEmail = "SECONDADMIN@USER.COM",
                            NormalizedUserName = "SECONDADMIN@USER.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHiMyPpWk1yn/L7UdNdQlsEfZlks4muX+vnKaTuRHTNl1qzVEtAMsyq2knVmdWk36g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "58c3e68c-8ce6-4911-b0a6-bd3c6becd3b7",
                            TwoFactorEnabled = false,
                            UserName = "secondadmin@user.com"
                        },
                        new
                        {
                            Id = "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1722fe1d-f460-43f2-9aee-b470b589be49",
                            DateOfBirth = new DateOnly(2003, 1, 23),
                            Email = "acebojohnrohan@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Acebo",
                            LockoutEnabled = false,
                            NormalizedEmail = "ACEBOJOHNROHAN@GMAIL.COM",
                            NormalizedUserName = "ACEBOJOHNROHAN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL4qqSTHy2FuzO0Z/JoMckHGlrc66ntxWLIjMUL4Au+C2t2an9223VrA2uhtQof+YA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fab85a99-5512-464b-bade-f116a8fc164a",
                            TwoFactorEnabled = false,
                            UserName = "acebojohnrohan@gmail.com"
                        });
                });

            modelBuilder.Entity("LeaveManagementSystem.Web.Data.DogBreeds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(150)");

                    b.HasKey("Id");

                    b.ToTable("DogBreeds");
                });

            modelBuilder.Entity("LeaveManagementSystem.Web.Data.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7d92f11f-4d87-4ba7-9b1e-918906386c78",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "f9fa948a-5780-4cfd-bb53-8b3d326014af",
                            Name = "Supervisor",
                            NormalizedName = "SUPERVISOR"
                        },
                        new
                        {
                            Id = "f7023c71-325f-45af-b159-0437489f5f6f",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                            RoleId = "f7023c71-325f-45af-b159-0437489f5f6f"
                        },
                        new
                        {
                            UserId = "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                            RoleId = "f7023c71-325f-45af-b159-0437489f5f6f"
                        },
                        new
                        {
                            UserId = "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                            RoleId = "f7023c71-325f-45af-b159-0437489f5f6f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("LeaveManagementSystem.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LeaveManagementSystem.Web.Data.ApplicationUser", null)
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

                    b.HasOne("LeaveManagementSystem.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LeaveManagementSystem.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
