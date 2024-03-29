﻿// <auto-generated />
using System;
using BulkyBookWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

// Disabling nullable warnings for this file
#nullable disable

// Namespace for managing database migrations
namespace BulkyBookWeb.Migrations
{
    // Class representing the model snapshot for the ApplicationDBContext
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        // Method for building the model snapshot
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            // Suppressing certain warnings related to obsolete features
#pragma warning disable 612, 618

            // Configuring annotations for the model
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            // Configuring the model to use identity columns for SQL Server
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            // Configuring the entity for the "Category" model
            modelBuilder.Entity("BulkyBookWeb.Models.Category", b =>
            {
                // Configuring the "Id" property
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd() // Auto-incrementing on add
                    .HasColumnType("int");

                // Configuring the "CreatedDateTime" property
                b.Property<DateTime>("CreatedDateTime")
                    .HasColumnType("datetime2");

                // Configuring the "DisplayOrder" property
                b.Property<int>("DisplayOrder")
                    .HasColumnType("int");

                // Configuring the "Name" property
                b.Property<string>("Name")
                    .IsRequired() // Marking as required
                    .HasColumnType("nvarchar(max)");

                // Configuring the primary key constraint for the "Id" property
                b.HasKey("Id");

                // Configuring the table name to be "Categories"
                b.ToTable("Categories");
            });

            // Restoring suppressed warnings
#pragma warning restore 612, 618
        }
    }
}
