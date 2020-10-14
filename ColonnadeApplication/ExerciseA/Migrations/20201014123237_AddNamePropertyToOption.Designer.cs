﻿// <auto-generated />
using System;
using ExerciseA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExerciseA.Migrations
{
    [DbContext(typeof(ColonnadeAppDbContext))]
    [Migration("20201014123237_AddNamePropertyToOption")]
    partial class AddNamePropertyToOption
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExerciseA.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccidentInsuranceLimit")
                        .HasColumnType("int");

                    b.Property<int>("Cash")
                        .HasColumnType("int");

                    b.Property<int>("Luggage")
                        .HasColumnType("int");

                    b.Property<int>("LuggageLimit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            AccidentInsuranceLimit = 50000000,
                            Cash = 0,
                            Luggage = 0,
                            LuggageLimit = 200000000,
                            Name = "Standard"
                        },
                        new
                        {
                            Id = 1,
                            AccidentInsuranceLimit = 200000000,
                            Cash = 100000,
                            Luggage = 200000,
                            LuggageLimit = 200000000,
                            Name = "Optimal"
                        },
                        new
                        {
                            Id = 3,
                            AccidentInsuranceLimit = 100000000,
                            Cash = 0,
                            Luggage = 50000,
                            LuggageLimit = 200000000,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 2,
                            AccidentInsuranceLimit = 150000000,
                            Cash = 100000,
                            Luggage = 100000,
                            LuggageLimit = 200000000,
                            Name = "Extra"
                        });
                });

            modelBuilder.Entity("ExerciseA.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OptionId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ExerciseA.Models.User", b =>
                {
                    b.HasOne("ExerciseA.Models.Option", "Option")
                        .WithMany("Users")
                        .HasForeignKey("OptionId");
                });
#pragma warning restore 612, 618
        }
    }
}
