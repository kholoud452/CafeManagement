﻿// <auto-generated />
using System;
using FinalEFProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalEFProject.Migrations
{
    [DbContext(typeof(CafeContext))]
    partial class CafeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalEFProject.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Change")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FinalEFProject.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomersId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Order_Delete_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Order_Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Prod_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prod_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prod_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FinalEFProject.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date_Delete")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Insert")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prod_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prod_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prod_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Prod_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Prod_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Prod_Stock")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FinalEFProject.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Customer_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Reg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FinalEFProject.Models.Orders", b =>
                {
                    b.HasOne("FinalEFProject.Models.Customers", null)
                        .WithMany("orders")
                        .HasForeignKey("CustomersId");

                    b.HasOne("FinalEFProject.Models.Users", "User")
                        .WithMany("orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinalEFProject.Models.Customers", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("FinalEFProject.Models.Users", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
