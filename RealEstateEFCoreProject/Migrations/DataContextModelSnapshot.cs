﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateEFCoreProject.Data;

namespace RealEstateEFCoreProject.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealEstateEFCoreProject.Models.ApartmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int?>("BrokerId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingFloors")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("FlatFloor")
                        .HasColumnType("int");

                    b.Property<int>("FlatNo")
                        .HasColumnType("int");

                    b.Property<string>("HouseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrokerId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.BrokerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brokers");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.CompanyBroker", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("BrokerId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId", "BrokerId");

                    b.HasIndex("BrokerId");

                    b.ToTable("CompanyBrokers");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.CompanyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseFlatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.ApartmentModel", b =>
                {
                    b.HasOne("RealEstateEFCoreProject.Models.BrokerModel", "Broker")
                        .WithMany("Apartments")
                        .HasForeignKey("BrokerId");

                    b.HasOne("RealEstateEFCoreProject.Models.CompanyModel", "Company")
                        .WithMany("Apartments")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Broker");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.CompanyBroker", b =>
                {
                    b.HasOne("RealEstateEFCoreProject.Models.BrokerModel", "Broker")
                        .WithMany("CompanyBrokers")
                        .HasForeignKey("BrokerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateEFCoreProject.Models.CompanyModel", "Company")
                        .WithMany("CompanyBrokers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Broker");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.BrokerModel", b =>
                {
                    b.Navigation("Apartments");

                    b.Navigation("CompanyBrokers");
                });

            modelBuilder.Entity("RealEstateEFCoreProject.Models.CompanyModel", b =>
                {
                    b.Navigation("Apartments");

                    b.Navigation("CompanyBrokers");
                });
#pragma warning restore 612, 618
        }
    }
}
