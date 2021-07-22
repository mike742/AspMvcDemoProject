﻿// <auto-generated />
using System;
using AspMvcDemoProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspMvcDemoProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210722180214_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspMvcDemoProject.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Date = new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mark's order"
                        },
                        new
                        {
                            Id = 102,
                            Date = new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lucy's order"
                        });
                });

            modelBuilder.Entity("AspMvcDemoProject.Models.OrderProducs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("P_Code")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("P_Code");

                    b.ToTable("OrderProducs");
                });

            modelBuilder.Entity("AspMvcDemoProject.Models.Product", b =>
                {
                    b.Property<string>("P_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("P_Discount")
                        .HasColumnType("float");

                    b.Property<DateTime>("P_InDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("P_Min")
                        .HasColumnType("int");

                    b.Property<double>("P_Price")
                        .HasColumnType("float");

                    b.Property<int>("P_QOH")
                        .HasColumnType("int");

                    b.Property<string>("P_descript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("V_code")
                        .HasColumnType("int");

                    b.HasKey("P_Code");

                    b.HasIndex("V_code");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            P_Code = "11GER/G1",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2017, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 109.98999999999999,
                            P_QOH = 8,
                            P_descript = "Power painter, 15 psi., 3-nozzle",
                            V_code = 25595
                        },
                        new
                        {
                            P_Code = "13-Q2/P2",
                            P_Discount = 0.050000000000000003,
                            P_InDate = new DateTime(2017, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 15,
                            P_Price = 14.99,
                            P_QOH = 32,
                            P_descript = "7.25-in pwr. saw blade",
                            V_code = 21344
                        },
                        new
                        {
                            P_Code = "14-Q1/L3",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2017, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 12,
                            P_Price = 17.489999999999998,
                            P_QOH = 18,
                            P_descript = "9.00-in pwr. saw blade",
                            V_code = 21344
                        },
                        new
                        {
                            P_Code = "1548-QQ2",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 8,
                            P_Price = 39.950000000000003,
                            P_QOH = 15,
                            P_descript = "Hrd. cloth, 1/4-in., 2x50",
                            V_code = 23119
                        },
                        new
                        {
                            P_Code = "1558-QW1",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 43.990000000000002,
                            P_QOH = 23,
                            P_descript = "Hrd. cloth, 1/2-in., 1x50",
                            V_code = 23119
                        },
                        new
                        {
                            P_Code = "2232/QTY",
                            P_Discount = 0.050000000000000003,
                            P_InDate = new DateTime(2017, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 109.92,
                            P_QOH = 8,
                            P_descript = "B&D jigsaw, 12-in. blade",
                            V_code = 24288
                        },
                        new
                        {
                            P_Code = "2232/QWE",
                            P_Discount = 0.050000000000000003,
                            P_InDate = new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 99.870000000000005,
                            P_QOH = 6,
                            P_descript = "B&D jigsaw, 8-in. blade",
                            V_code = 24288
                        },
                        new
                        {
                            P_Code = "2238/QPD",
                            P_Discount = 0.050000000000000003,
                            P_InDate = new DateTime(2018, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 38.950000000000003,
                            P_QOH = 12,
                            P_descript = "B&D cordless drill, 12-in",
                            V_code = 25595
                        },
                        new
                        {
                            P_Code = "23109-HB",
                            P_Discount = 0.10000000000000001,
                            P_InDate = new DateTime(2018, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 10,
                            P_Price = 9.9499999999999993,
                            P_QOH = 23,
                            P_descript = "Claw hammer",
                            V_code = 21225
                        },
                        new
                        {
                            P_Code = "23114-AA",
                            P_Discount = 0.050000000000000003,
                            P_InDate = new DateTime(2018, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 14.4,
                            P_QOH = 8,
                            P_descript = "Sledge hammer, 12 lb."
                        },
                        new
                        {
                            P_Code = "54778-2T",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2017, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 20,
                            P_Price = 4.9900000000000002,
                            P_QOH = 43,
                            P_descript = "Rat-tail file, 1/8-in. fine",
                            V_code = 21344
                        },
                        new
                        {
                            P_Code = "89-WRE-Q",
                            P_Discount = 0.050000000000000003,
                            P_InDate = new DateTime(2018, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 256.99000000000001,
                            P_QOH = 11,
                            P_descript = "Hicut chain saw, 16 in.",
                            V_code = 24288
                        },
                        new
                        {
                            P_Code = "PVC23DRT",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2018, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 75,
                            P_Price = 5.8700000000000001,
                            P_QOH = 188,
                            P_descript = "PVC pipe, 3.5-in, 8-ft"
                        },
                        new
                        {
                            P_Code = "SM-18277",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 75,
                            P_Price = 6.9900000000000002,
                            P_QOH = 172,
                            P_descript = "1.25-in. metal screw, 25",
                            V_code = 21225
                        },
                        new
                        {
                            P_Code = "SM-23116",
                            P_Discount = 0.0,
                            P_InDate = new DateTime(2018, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 100,
                            P_Price = 8.4499999999999993,
                            P_QOH = 237,
                            P_descript = "2.5-in. wd screw, 50",
                            V_code = 21231
                        },
                        new
                        {
                            P_Code = "WR3/TT3",
                            P_Discount = 0.10000000000000001,
                            P_InDate = new DateTime(2018, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            P_Min = 5,
                            P_Price = 119.95,
                            P_QOH = 18,
                            P_descript = "Steel matting, 4x8x1/6, .5 mesh",
                            V_code = 25595
                        });
                });

            modelBuilder.Entity("AspMvcDemoProject.Models.Vendor", b =>
                {
                    b.Property<int>("V_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("V_AreaCode")
                        .HasColumnType("int");

                    b.Property<string>("V_contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_order")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("V_state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("V_code");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            V_code = 21225,
                            V_AreaCode = 615,
                            V_contact = "Smithson",
                            V_name = "Bryson, Inc",
                            V_order = "Y",
                            V_phone = "223-3234",
                            V_state = "TN"
                        },
                        new
                        {
                            V_code = 21226,
                            V_AreaCode = 904,
                            V_contact = "Flushing",
                            V_name = "SuperLoo, Inc",
                            V_order = "N",
                            V_phone = "215-8995",
                            V_state = "FL"
                        },
                        new
                        {
                            V_code = 21231,
                            V_AreaCode = 615,
                            V_contact = "Singh",
                            V_name = "D&E Supply",
                            V_order = "Y",
                            V_phone = "228-3245",
                            V_state = "TN"
                        },
                        new
                        {
                            V_code = 21344,
                            V_AreaCode = 615,
                            V_contact = "Singh",
                            V_name = "Gomez Bros.",
                            V_order = "N",
                            V_phone = "889-2546",
                            V_state = "KY"
                        },
                        new
                        {
                            V_code = 22567,
                            V_AreaCode = 901,
                            V_contact = "Smith",
                            V_name = "Dome Supply",
                            V_order = "N",
                            V_phone = "878-1419",
                            V_state = "GA"
                        },
                        new
                        {
                            V_code = 23119,
                            V_AreaCode = 901,
                            V_contact = "Anderson",
                            V_name = "Randset Ltd.",
                            V_order = "Y",
                            V_phone = "678-3998",
                            V_state = "GA"
                        },
                        new
                        {
                            V_code = 24004,
                            V_AreaCode = 615,
                            V_contact = "Brownling",
                            V_name = "Brackman Bros.",
                            V_order = "N",
                            V_phone = "228-1410",
                            V_state = "TN"
                        },
                        new
                        {
                            V_code = 24288,
                            V_AreaCode = 615,
                            V_contact = "Hakford",
                            V_name = "ORDVA, Inc.",
                            V_order = "Y",
                            V_phone = "898-1234",
                            V_state = "TN"
                        },
                        new
                        {
                            V_code = 25443,
                            V_AreaCode = 904,
                            V_contact = "Smith",
                            V_name = "B&K, Inc.",
                            V_order = "N",
                            V_phone = "227-0093",
                            V_state = "FL"
                        },
                        new
                        {
                            V_code = 25501,
                            V_AreaCode = 615,
                            V_contact = "Smythe",
                            V_name = "Damal Supplies",
                            V_order = "N",
                            V_phone = "890-3529",
                            V_state = "TN"
                        },
                        new
                        {
                            V_code = 25595,
                            V_AreaCode = 904,
                            V_contact = "Orton",
                            V_name = "Rubicon Systems",
                            V_order = "Y",
                            V_phone = "456-0092",
                            V_state = "FL"
                        });
                });

            modelBuilder.Entity("AspMvcDemoProject.Models.OrderProducs", b =>
                {
                    b.HasOne("AspMvcDemoProject.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspMvcDemoProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("P_Code");
                });

            modelBuilder.Entity("AspMvcDemoProject.Models.Product", b =>
                {
                    b.HasOne("AspMvcDemoProject.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("V_code");
                });
#pragma warning restore 612, 618
        }
    }
}
