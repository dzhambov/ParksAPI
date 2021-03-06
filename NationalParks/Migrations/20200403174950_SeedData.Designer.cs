﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParks.Models;

namespace NationalParks.Migrations
{
    [DbContext(typeof(NationalParksContext))]
    [Migration("20200403174950_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Campgrounds");

                    b.Property<string>("City");

                    b.Property<int>("ClimbingRoutes");

                    b.Property<string>("Description");

                    b.Property<int>("GeneralStores");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 2,
                            Campgrounds = 3,
                            City = "Three Rivers",
                            ClimbingRoutes = 1,
                            Description = "It's ancient",
                            GeneralStores = 4,
                            Name = "Sequoia National Park",
                            State = "CA"
                        },
                        new
                        {
                            ParkId = 3,
                            Campgrounds = 9,
                            City = "Yosemite National Park",
                            ClimbingRoutes = 1348,
                            Description = "I met my friend Sam here",
                            GeneralStores = 8,
                            Name = "Yosemite National Park",
                            State = "CA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
