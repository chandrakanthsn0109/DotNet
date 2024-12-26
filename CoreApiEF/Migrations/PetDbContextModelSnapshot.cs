﻿// <auto-generated />
using CoreApiEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoreApiEF.Migrations
{
    [DbContext(typeof(PetDbContext))]
    partial class PetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CoreApiEF.Models.PetAnimal", b =>
                {
                    b.Property<int>("petId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("petId"));

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isVeg")
                        .HasColumnType("boolean");

                    b.Property<string>("petName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("petType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("petId");

                    b.ToTable("PetAnimals");
                });
#pragma warning restore 612, 618
        }
    }
}
