﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleManagementSystem.Data;

namespace VehicleManagementSystem.Data.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20190820000849_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleManagementSystem.Models.BodyType.BodyTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyType");

                    b.Property<string>("VehicleType");

                    b.HasKey("Id");

                    b.ToTable("bodyTypes");
                });

            modelBuilder.Entity("VehicleManagementSystem.Models.VehicleType.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyType");

                    b.Property<int>("Doors");

                    b.Property<string>("EngineDetail");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<string>("VehicleType");

                    b.Property<int>("Wheels");

                    b.HasKey("Id");

                    b.ToTable("vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
