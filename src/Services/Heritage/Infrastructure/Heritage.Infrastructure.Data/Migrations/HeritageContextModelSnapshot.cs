﻿// <auto-generated />
using System;
using Heritage.Infrastructure.Data.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Heritage.Infrastructure.Data.Migrations
{
    [DbContext(typeof(HeritageContext))]
    partial class HeritageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArchitecturalStyle")
                        .HasColumnType("int");

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BuildDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LossCause")
                        .HasColumnType("int");

                    b.Property<DateTime>("LossDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
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
