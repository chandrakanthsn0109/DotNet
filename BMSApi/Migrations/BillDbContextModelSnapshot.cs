﻿// <auto-generated />
using BMSApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BMSApi.Migrations
{
    [DbContext(typeof(BillDbContext))]
    partial class BillDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BMSApi.Models.Bill", b =>
                {
                    b.Property<int>("billId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("billId"));

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.Property<string>("customerEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("customerPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("billId");

                    b.ToTable("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}