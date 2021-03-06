﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USVisual.API.Data;

namespace USVisual.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190310014853_AddDeathClass")]
    partial class AddDeathClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("USVisual.API.Models.Death", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("attacktype1_txt");

                    b.Property<string>("country_txt");

                    b.Property<string>("imonth");

                    b.Property<string>("iyear");

                    b.Property<string>("latitude");

                    b.Property<string>("longitude");

                    b.Property<string>("nkill");

                    b.Property<string>("nwound");

                    b.Property<string>("region_txt");

                    b.Property<string>("weaptype1_txt");

                    b.HasKey("Id");

                    b.ToTable("Deaths");
                });

            modelBuilder.Entity("USVisual.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
