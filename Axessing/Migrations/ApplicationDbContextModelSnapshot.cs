﻿// <auto-generated />
using System;
using Axessing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Axessing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("Axessing.Models.Schema.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkspaceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Axessing.Models.Schema.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HexValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("Axessing.Models.Schema.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkspaceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5914),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5915),
                            Stage = 1,
                            Title = "Create new dashboard",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5921),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5922),
                            Stage = 2,
                            Title = "Change state of data models",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5925),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5926),
                            Stage = 0,
                            Title = "Type state error when accessing ticket",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5928),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5929),
                            Stage = 0,
                            Title = "Git log error after update",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5932),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5933),
                            Stage = 4,
                            Title = "Wishlist sharing problems",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5937),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5938),
                            Stage = 3,
                            Title = "Telegram does not accept list of type x",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5940),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5941),
                            Stage = 0,
                            Title = "Button color palette should be changed",
                            WorkspaceId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5944),
                            Description = "Lorem ipsum dolor sit amet at avis mia seguind ralf cuspat en colo lat gerda mecant e.",
                            LastModifiedDate = new DateTime(2024, 1, 12, 2, 36, 34, 236, DateTimeKind.Local).AddTicks(5945),
                            Stage = 5,
                            Title = "Account appears only when logged in",
                            WorkspaceId = 1
                        });
                });

            modelBuilder.Entity("Axessing.Models.Schema.Workspace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LogoURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workspaces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem ipsum dolor sit amet.",
                            LogoURL = "https://png.pngtree.com/png-vector/20221119/ourmid/pngtree-aa-letter-logos-png-image_6471608.png",
                            Name = "Axessing - Monorepo"
                        });
                });

            modelBuilder.Entity("LabelTicket", b =>
                {
                    b.Property<int>("LabelsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LabelsId", "TicketsId");

                    b.HasIndex("TicketsId");

                    b.ToTable("LabelTicket");
                });

            modelBuilder.Entity("Axessing.Models.Schema.AppUser", b =>
                {
                    b.HasOne("Axessing.Models.Schema.Workspace", null)
                        .WithMany("Collaborators")
                        .HasForeignKey("WorkspaceId");
                });

            modelBuilder.Entity("Axessing.Models.Schema.Ticket", b =>
                {
                    b.HasOne("Axessing.Models.Schema.Workspace", "Workspace")
                        .WithMany("Tickets")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("LabelTicket", b =>
                {
                    b.HasOne("Axessing.Models.Schema.Label", null)
                        .WithMany()
                        .HasForeignKey("LabelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Axessing.Models.Schema.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Axessing.Models.Schema.Workspace", b =>
                {
                    b.Navigation("Collaborators");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
