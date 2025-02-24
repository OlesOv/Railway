﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Railway.Data;

#nullable disable

namespace Railway.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Railway.Models.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteID"));

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArrivalStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FixationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoutePriceID")
                        .HasColumnType("int");

                    b.Property<int>("TrainTypeID")
                        .HasColumnType("int");

                    b.HasKey("RouteID");

                    b.HasIndex("RoutePriceID");

                    b.HasIndex("TrainTypeID");

                    b.ToTable("Route", (string)null);
                });

            modelBuilder.Entity("Railway.Models.RoutePrice", b =>
                {
                    b.Property<int>("RoutePriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoutePriceID"));

                    b.Property<decimal>("Route_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RoutePriceID");

                    b.ToTable("RoutePrice", (string)null);
                });

            modelBuilder.Entity("Railway.Models.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketID"));

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArrivalStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteID")
                        .HasColumnType("int");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TicketStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Ticket_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("TicketID");

                    b.HasIndex("RouteID");

                    b.HasIndex("TicketTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("Ticket", (string)null);
                });

            modelBuilder.Entity("Railway.Models.TicketType", b =>
                {
                    b.Property<int>("TicketTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketTypeID"));

                    b.Property<decimal>("TicketTypePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ticket_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketTypeID");

                    b.ToTable("TicketType", (string)null);
                });

            modelBuilder.Entity("Railway.Models.TrainType", b =>
                {
                    b.Property<int>("TrainTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainTypeID"));

                    b.Property<decimal>("TrainTypePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Train_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainTypeID");

                    b.ToTable("TrainType", (string)null);
                });

            modelBuilder.Entity("Railway.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Railway.Models.Route", b =>
                {
                    b.HasOne("Railway.Models.RoutePrice", "RoutePrice")
                        .WithMany("Routes")
                        .HasForeignKey("RoutePriceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Railway.Models.TrainType", "TrainType")
                        .WithMany("Routes")
                        .HasForeignKey("TrainTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoutePrice");

                    b.Navigation("TrainType");
                });

            modelBuilder.Entity("Railway.Models.Ticket", b =>
                {
                    b.HasOne("Railway.Models.Route", "Route")
                        .WithMany("Tickets")
                        .HasForeignKey("RouteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Railway.Models.TicketType", "TicketType")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Railway.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");

                    b.Navigation("TicketType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Railway.Models.Route", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Railway.Models.RoutePrice", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Railway.Models.TicketType", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Railway.Models.TrainType", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Railway.Models.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
