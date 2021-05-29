﻿// <auto-generated />
using System;
using Heritage.Infrastructure.Data.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

namespace Heritage.Infrastructure.Data.Migrations
{
    [DbContext(typeof(HeritageContext))]
    [Migration("20201222141437_added_description_and_data_annotations")]
    partial class added_description_and_data_annotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Heritage.Domain.Core.Entities.Construction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ArchitecturalStyle")
                        .HasColumnType("int");

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(2083)")
                        .HasMaxLength(2083);

                    b.Property<DateTime?>("BuildDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<int?>("LossCause")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LossDate")
                        .HasColumnType("date");

                    b.Property<int?>("Material")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Constructions");
                });

            modelBuilder.Entity("Heritage.Domain.Core.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConstructionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConstructionId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Heritage.Domain.Core.Entities.Image", b =>
                {
                    b.HasOne("Heritage.Domain.Core.Entities.Construction", "Construction")
                        .WithMany("Images")
                        .HasForeignKey("ConstructionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
