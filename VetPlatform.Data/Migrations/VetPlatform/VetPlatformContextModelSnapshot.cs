﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetPlatform.Data;

namespace VetPlatform.Data.Migrations.VetPlatform
{
    [DbContext(typeof(VetPlatformContext))]
    partial class VetPlatformContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Reason");

                    b.Property<DateTime>("Schedule");

                    b.Property<string>("Status");

                    b.Property<Guid>("TenantId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f35a503-971e-4a34-ac73-039aa9e870eb"),
                            Schedule = new DateTime(2019, 4, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Done",
                            TenantId = new Guid("37ef41bd-b7ed-4fa2-bef8-916b03b1e174")
                        },
                        new
                        {
                            Id = new Guid("07a8efa1-13e6-4b57-94b6-51c4fd812456"),
                            Schedule = new DateTime(2019, 4, 20, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            TenantId = new Guid("37ef41bd-b7ed-4fa2-bef8-916b03b1e174")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
