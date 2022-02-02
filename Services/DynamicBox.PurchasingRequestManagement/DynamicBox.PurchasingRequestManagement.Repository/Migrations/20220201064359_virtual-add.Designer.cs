﻿// <auto-generated />
using System;
using DynamicBox.PurchasingManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DynamicBox.PurchasingRequestManagement.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220201064359_virtual-add")]
    partial class virtualadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DynamicBox.PurchasingManagement.Core.Models.Company.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BusinessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BusinessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("MaterialDemands");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemandDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BusinessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MaterialDemandId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StockName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Total")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaterialDemandId");

                    b.ToTable("MaterialDemandDetails");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemandHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BusinessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CancelledAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("ContextId")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContextType")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrelationId")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefinationId")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefinationVersionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FaultedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("FinishedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("LastExecutedActivityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastExecutedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<long>("MaterialDemandId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasPrecision(450)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<int>("WorkflowStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialDemandId");

                    b.ToTable("MaterialDemandHistory");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialList", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BusinessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaterialGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialStockNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MaterialLists");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemand", b =>
                {
                    b.HasOne("DynamicBox.PurchasingManagement.Core.Models.Company.Company", "Company")
                        .WithMany("MaterialDemands")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemandDetail", b =>
                {
                    b.HasOne("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemand", "MaterialDemands")
                        .WithMany("MaterialDemandDetails")
                        .HasForeignKey("MaterialDemandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialDemands");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemandHistory", b =>
                {
                    b.HasOne("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemand", "MaterialDemand")
                        .WithMany("MaterialDemandHistories")
                        .HasForeignKey("MaterialDemandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialDemand");
                });

            modelBuilder.Entity("DynamicBox.PurchasingManagement.Core.Models.Company.Company", b =>
                {
                    b.Navigation("MaterialDemands");
                });

            modelBuilder.Entity("DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand.MaterialDemand", b =>
                {
                    b.Navigation("MaterialDemandDetails");

                    b.Navigation("MaterialDemandHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
