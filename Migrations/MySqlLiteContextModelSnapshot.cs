﻿// <auto-generated />
using Laboratory_work_3.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Laboratory_work_3.Migrations
{
    [DbContext(typeof(MySqlLiteContext))]
    partial class MySqlLiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Laboratory_work_3.Model.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Body")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cooling")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Motherboard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PowerSupply")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Processor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RamMemory")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SSD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VideoCard")
                        .HasColumnType("INTEGER");

                    b.HasKey("ComputerId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("Laboratory_work_3.Model.Gamer", b =>
                {
                    b.Property<int>("GamerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fatigue")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<int>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Satiety")
                        .HasColumnType("INTEGER");

                    b.HasKey("GamerId");

                    b.ToTable("Gamers");
                });

            modelBuilder.Entity("Laboratory_work_3.Model.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Minqualifications")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("UpExperience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wages")
                        .HasColumnType("INTEGER");

                    b.HasKey("WorkId");

                    b.ToTable("Works");
                });
#pragma warning restore 612, 618
        }
    }
}
