﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestApiTemplate.Infrastructure;

namespace RestApiTemplate.Infrastructure.Migrations
{
    [DbContext(typeof(RestApiTemplateDbContext))]
    [Migration("20200225213437_InitialSeedData")]
    partial class InitialSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestApiTemplate.Core.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Games"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Heroes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Movies"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CollectionName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("CollectionId");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.CollectionFunkoPop", b =>
                {
                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<int>("FunkoPopId")
                        .HasColumnType("int");

                    b.HasKey("CollectionId", "FunkoPopId");

                    b.HasIndex("FunkoPopId");

                    b.ToTable("CollectionFunkoPop");
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatureName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("FeatureId");

                    b.ToTable("Feature");

                    b.HasData(
                        new
                        {
                            FeatureId = 1,
                            FeatureName = "Chase"
                        },
                        new
                        {
                            FeatureId = 2,
                            FeatureName = "Colour Variant"
                        },
                        new
                        {
                            FeatureId = 3,
                            FeatureName = "Exclusive"
                        },
                        new
                        {
                            FeatureId = 4,
                            FeatureName = "Flocked"
                        },
                        new
                        {
                            FeatureId = 5,
                            FeatureName = "Glitter"
                        },
                        new
                        {
                            FeatureId = 6,
                            FeatureName = "Glow"
                        },
                        new
                        {
                            FeatureId = 7,
                            FeatureName = "Metallic"
                        },
                        new
                        {
                            FeatureId = 8,
                            FeatureName = "Multipack"
                        },
                        new
                        {
                            FeatureId = 9,
                            FeatureName = "Outfit Variant"
                        },
                        new
                        {
                            FeatureId = 10,
                            FeatureName = "Texture Variant"
                        });
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.FunkoPop", b =>
                {
                    b.Property<int>("FunkoPopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int?>("LicenseId")
                        .HasColumnType("int");

                    b.Property<int>("MoldNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("FunkoPopId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FeatureId");

                    b.HasIndex("LicenseId");

                    b.ToTable("FunkoPop");
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.License", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicenseName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("LicenseId");

                    b.ToTable("License");

                    b.HasData(
                        new
                        {
                            LicenseId = 1,
                            LicenseName = "DC"
                        },
                        new
                        {
                            LicenseId = 2,
                            LicenseName = "Marvel"
                        },
                        new
                        {
                            LicenseId = 3,
                            LicenseName = "Mr Robot"
                        },
                        new
                        {
                            LicenseId = 4,
                            LicenseName = "Star Wars"
                        });
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.CollectionFunkoPop", b =>
                {
                    b.HasOne("RestApiTemplate.Core.Domain.Collection", "Collection")
                        .WithMany("CollectionFunkoPops")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestApiTemplate.Core.Domain.FunkoPop", "FunkoPop")
                        .WithMany("CollectionFunkoPops")
                        .HasForeignKey("FunkoPopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApiTemplate.Core.Domain.FunkoPop", b =>
                {
                    b.HasOne("RestApiTemplate.Core.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("RestApiTemplate.Core.Domain.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId");

                    b.HasOne("RestApiTemplate.Core.Domain.License", "License")
                        .WithMany()
                        .HasForeignKey("LicenseId");
                });
#pragma warning restore 612, 618
        }
    }
}
