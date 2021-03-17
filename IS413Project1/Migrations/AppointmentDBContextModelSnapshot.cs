﻿// <auto-generated />
using System;
using IS413Project1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IS413Project1.Migrations
{
    [DbContext(typeof(AppointmentDBContext))]
    partial class AppointmentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13");

            modelBuilder.Entity("IS413Project1.Models.Appointment", b =>
                {
                    b.Property<int>("ApptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApptTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ApptID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("IS413Project1.Models.TimeSlot", b =>
                {
                    b.Property<int>("TimeSlotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ApptID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeSlotID");

                    b.ToTable("TimeSlots");
                });
#pragma warning restore 612, 618
        }
    }
}
