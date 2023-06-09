﻿// <auto-generated />
using System;
using Calculator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Calculator.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Calculator.Models.Calculation", b =>
                {
                    b.Property<int>("CalculationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalculationID"));

                    b.Property<DateTime>("DateCalculated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Result")
                        .HasColumnType("float");

                    b.Property<double>("Value1")
                        .HasColumnType("float");

                    b.Property<double>("Value2")
                        .HasColumnType("float");

                    b.HasKey("CalculationID");

                    b.ToTable("Calculations");

                    b.HasData(
                        new
                        {
                            CalculationID = 1,
                            DateCalculated = new DateTime(2023, 6, 1, 11, 42, 50, 714, DateTimeKind.Local).AddTicks(3279),
                            Operation = "+",
                            Result = 8.0,
                            Value1 = 5.0,
                            Value2 = 3.0
                        },
                        new
                        {
                            CalculationID = 2,
                            DateCalculated = new DateTime(2023, 6, 1, 11, 42, 50, 714, DateTimeKind.Local).AddTicks(3284),
                            Operation = "/",
                            Result = 5.0,
                            Value1 = 10.0,
                            Value2 = 2.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
