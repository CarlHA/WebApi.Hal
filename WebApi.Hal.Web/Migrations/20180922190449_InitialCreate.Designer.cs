﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApi.Hal.Web.Data;

namespace WebApi.Hal.Web.Migrations
{
    [DbContext(typeof(BeerDbContext))]
    [Migration("20180922190449_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("WebApi.Hal.Web.Models.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Abv")
                        .HasColumnType("decimal(3,2)");

                    b.Property<int>("Brewery_Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Style_Id");

                    b.HasKey("Id");

                    b.HasIndex("Brewery_Id");

                    b.HasIndex("Style_Id");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("WebApi.Hal.Web.Models.BeerStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("BeerStyles");
                });

            modelBuilder.Entity("WebApi.Hal.Web.Models.Brewery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Notes");

                    b.Property<string>("Phone")
                        .HasMaxLength(100);

                    b.Property<string>("Twitter")
                        .HasMaxLength(100);

                    b.Property<string>("Website")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Breweries");
                });

            modelBuilder.Entity("WebApi.Hal.Web.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Beer_Id");

                    b.Property<string>("Content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Beer_Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WebApi.Hal.Web.Models.Beer", b =>
                {
                    b.HasOne("WebApi.Hal.Web.Models.Brewery", "Brewery")
                        .WithMany()
                        .HasForeignKey("Brewery_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Hal.Web.Models.BeerStyle", "Style")
                        .WithMany()
                        .HasForeignKey("Style_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApi.Hal.Web.Models.Review", b =>
                {
                    b.HasOne("WebApi.Hal.Web.Models.Beer", "Beer")
                        .WithMany()
                        .HasForeignKey("Beer_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
