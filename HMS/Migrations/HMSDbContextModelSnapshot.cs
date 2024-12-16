﻿// <auto-generated />
using HMS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HMS.Migrations
{
    [DbContext(typeof(HMSDbContext))]
    partial class HMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HMS.Models.Doctor", b =>
                {
                    b.Property<int>("DocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DocId"));

                    b.Property<string>("DocName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HosId")
                        .HasColumnType("integer");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Specality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DocId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("HMS.Models.Hospital", b =>
                {
                    b.Property<int>("HosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("HosId"));

                    b.Property<string>("HosLoc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HosName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("HosId");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("HMS.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("DocId")
                        .HasColumnType("integer");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}