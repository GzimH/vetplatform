﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetPlatform.Data;

namespace VetPlatform.Data.Migrations.VetPlatform
{
    [DbContext(typeof(VetPlatformContext))]
    [Migration("20190505211248_Bookings_Add_Status_Col")]
    partial class Bookings_Add_Status_Col
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VetPlatform.Data.Models.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Schedule");

                    b.Property<string>("Status");

                    b.Property<Guid>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e7e00907-9e9d-4eaf-ba8e-76f0057240db"),
                            Schedule = new DateTime(2019, 4, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            TenantId = new Guid("37ef41bd-b7ed-4fa2-bef8-916b03b1e174")
                        },
                        new
                        {
                            Id = new Guid("430c6f82-f06a-46de-9c2f-2dfd13bf4acd"),
                            Schedule = new DateTime(2019, 4, 20, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            TenantId = new Guid("85029b8d-86f1-4c81-befc-a832819ad557")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
