﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StorePriceMonitor.Infastructure.Persistance;

namespace StorePriceMonitor.Infastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220701100551_Initialize_Migration")]
    partial class Initialize_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StorePriceMonitor.Domain.Models.PriceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PriceSourceId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TickerListId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PriceSourceId");

                    b.HasIndex("TickerListId");

                    b.ToTable("PriceList", "pr");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 110m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(5665)
                        },
                        new
                        {
                            Id = 2,
                            Price = 150m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 16, 50, 50, 851, DateTimeKind.Local).AddTicks(7297)
                        },
                        new
                        {
                            Id = 3,
                            Price = 140m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 17, 5, 50, 851, DateTimeKind.Local).AddTicks(7310)
                        },
                        new
                        {
                            Id = 4,
                            Price = 100m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 17, 20, 50, 851, DateTimeKind.Local).AddTicks(7313)
                        },
                        new
                        {
                            Id = 5,
                            Price = 140m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7315)
                        },
                        new
                        {
                            Id = 6,
                            Price = 160m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 17, 50, 50, 851, DateTimeKind.Local).AddTicks(7317)
                        },
                        new
                        {
                            Id = 7,
                            Price = 130m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 5, 50, 851, DateTimeKind.Local).AddTicks(7319)
                        },
                        new
                        {
                            Id = 8,
                            Price = 110m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 20, 50, 851, DateTimeKind.Local).AddTicks(7320)
                        },
                        new
                        {
                            Id = 9,
                            Price = 200m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7322)
                        },
                        new
                        {
                            Id = 10,
                            Price = 330m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 41, 50, 851, DateTimeKind.Local).AddTicks(7323)
                        },
                        new
                        {
                            Id = 11,
                            Price = 210m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 47, 50, 851, DateTimeKind.Local).AddTicks(7325)
                        },
                        new
                        {
                            Id = 12,
                            Price = 320m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 19, 5, 50, 851, DateTimeKind.Local).AddTicks(7327)
                        },
                        new
                        {
                            Id = 13,
                            Price = 340m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 19, 23, 50, 851, DateTimeKind.Local).AddTicks(7328)
                        },
                        new
                        {
                            Id = 14,
                            Price = 530m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7330)
                        },
                        new
                        {
                            Id = 15,
                            Price = 760m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 19, 41, 50, 851, DateTimeKind.Local).AddTicks(7331)
                        },
                        new
                        {
                            Id = 16,
                            Price = 450m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 19, 53, 50, 851, DateTimeKind.Local).AddTicks(7333)
                        },
                        new
                        {
                            Id = 17,
                            Price = 860m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7334)
                        },
                        new
                        {
                            Id = 18,
                            Price = 540m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7336)
                        },
                        new
                        {
                            Id = 19,
                            Price = 220m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7337)
                        },
                        new
                        {
                            Id = 20,
                            Price = 660m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7339)
                        },
                        new
                        {
                            Id = 21,
                            Price = 750m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7341)
                        },
                        new
                        {
                            Id = 22,
                            Price = 540m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7342)
                        },
                        new
                        {
                            Id = 23,
                            Price = 320m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7344)
                        },
                        new
                        {
                            Id = 24,
                            Price = 630m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7345)
                        },
                        new
                        {
                            Id = 25,
                            Price = 530m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 19, 5, 50, 851, DateTimeKind.Local).AddTicks(7347)
                        },
                        new
                        {
                            Id = 26,
                            Price = 110m,
                            PriceSourceId = 2,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7349)
                        },
                        new
                        {
                            Id = 27,
                            Price = 150m,
                            PriceSourceId = 3,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 16, 50, 50, 851, DateTimeKind.Local).AddTicks(7350)
                        },
                        new
                        {
                            Id = 28,
                            Price = 140m,
                            PriceSourceId = 5,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 17, 5, 50, 851, DateTimeKind.Local).AddTicks(7352)
                        },
                        new
                        {
                            Id = 29,
                            Price = 100m,
                            PriceSourceId = 3,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 17, 20, 50, 851, DateTimeKind.Local).AddTicks(7353)
                        },
                        new
                        {
                            Id = 30,
                            Price = 140m,
                            PriceSourceId = 2,
                            Status = true,
                            TickerListId = 1,
                            Time = new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7355)
                        },
                        new
                        {
                            Id = 31,
                            Price = 160m,
                            PriceSourceId = 5,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 17, 50, 50, 851, DateTimeKind.Local).AddTicks(7356)
                        },
                        new
                        {
                            Id = 32,
                            Price = 130m,
                            PriceSourceId = 5,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 5, 50, 851, DateTimeKind.Local).AddTicks(7358)
                        },
                        new
                        {
                            Id = 33,
                            Price = 110m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 20, 50, 851, DateTimeKind.Local).AddTicks(7359)
                        },
                        new
                        {
                            Id = 34,
                            Price = 200m,
                            PriceSourceId = 5,
                            Status = true,
                            TickerListId = 5,
                            Time = new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7361)
                        },
                        new
                        {
                            Id = 35,
                            Price = 330m,
                            PriceSourceId = 4,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 18, 41, 50, 851, DateTimeKind.Local).AddTicks(7363)
                        },
                        new
                        {
                            Id = 36,
                            Price = 210m,
                            PriceSourceId = 4,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 18, 47, 50, 851, DateTimeKind.Local).AddTicks(7364)
                        },
                        new
                        {
                            Id = 37,
                            Price = 320m,
                            PriceSourceId = 2,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 19, 5, 50, 851, DateTimeKind.Local).AddTicks(7406)
                        },
                        new
                        {
                            Id = 38,
                            Price = 340m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 5,
                            Time = new DateTime(2022, 7, 1, 19, 23, 50, 851, DateTimeKind.Local).AddTicks(7408)
                        },
                        new
                        {
                            Id = 39,
                            Price = 530m,
                            PriceSourceId = 1,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7410)
                        },
                        new
                        {
                            Id = 40,
                            Price = 760m,
                            PriceSourceId = 2,
                            Status = true,
                            TickerListId = 2,
                            Time = new DateTime(2022, 7, 1, 19, 41, 50, 851, DateTimeKind.Local).AddTicks(7411)
                        },
                        new
                        {
                            Id = 41,
                            Price = 450m,
                            PriceSourceId = 3,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 19, 53, 50, 851, DateTimeKind.Local).AddTicks(7413)
                        },
                        new
                        {
                            Id = 42,
                            Price = 860m,
                            PriceSourceId = 3,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7415)
                        },
                        new
                        {
                            Id = 43,
                            Price = 540m,
                            PriceSourceId = 4,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 17, 35, 50, 851, DateTimeKind.Local).AddTicks(7416)
                        },
                        new
                        {
                            Id = 44,
                            Price = 220m,
                            PriceSourceId = 4,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 19, 35, 50, 851, DateTimeKind.Local).AddTicks(7418)
                        },
                        new
                        {
                            Id = 45,
                            Price = 660m,
                            PriceSourceId = 5,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7419)
                        },
                        new
                        {
                            Id = 46,
                            Price = 750m,
                            PriceSourceId = 5,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 18, 35, 50, 851, DateTimeKind.Local).AddTicks(7421)
                        },
                        new
                        {
                            Id = 47,
                            Price = 540m,
                            PriceSourceId = 3,
                            Status = true,
                            TickerListId = 3,
                            Time = new DateTime(2022, 7, 1, 16, 35, 50, 851, DateTimeKind.Local).AddTicks(7423)
                        },
                        new
                        {
                            Id = 48,
                            Price = 320m,
                            PriceSourceId = 2,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7424)
                        },
                        new
                        {
                            Id = 49,
                            Price = 630m,
                            PriceSourceId = 2,
                            Status = true,
                            TickerListId = 4,
                            Time = new DateTime(2022, 7, 1, 20, 35, 50, 851, DateTimeKind.Local).AddTicks(7426)
                        });
                });

            modelBuilder.Entity("StorePriceMonitor.Domain.Models.PriceSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PriceSource", "msr");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 846, DateTimeKind.Local).AddTicks(1770),
                            CreatedUser = "System Seed",
                            Description = "PRC 1",
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5602),
                            CreatedUser = "System Seed",
                            Description = "PRC 2",
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5623),
                            CreatedUser = "System Seed",
                            Description = "PRC 3",
                            Status = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5625),
                            CreatedUser = "System Seed",
                            Description = "PRC 4",
                            Status = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 847, DateTimeKind.Local).AddTicks(5627),
                            CreatedUser = "System Seed",
                            Description = "PRC 5",
                            Status = false
                        });
                });

            modelBuilder.Entity("StorePriceMonitor.Domain.Models.TickerList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TickerList", "msr");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8812),
                            CreatedUser = "System Seed",
                            Description = "TICKER 1",
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8823),
                            CreatedUser = "System Seed",
                            Description = "TICKER 2",
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8825),
                            CreatedUser = "System Seed",
                            Description = "TICKER 3",
                            Status = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8827),
                            CreatedUser = "System Seed",
                            Description = "TICKER 4",
                            Status = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 7, 1, 15, 35, 50, 848, DateTimeKind.Local).AddTicks(8828),
                            CreatedUser = "System Seed",
                            Description = "TICKER 5",
                            Status = false
                        });
                });

            modelBuilder.Entity("StorePriceMonitor.Domain.Models.PriceList", b =>
                {
                    b.HasOne("StorePriceMonitor.Domain.Models.PriceSource", "PriceSource")
                        .WithMany()
                        .HasForeignKey("PriceSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StorePriceMonitor.Domain.Models.TickerList", "TickerList")
                        .WithMany()
                        .HasForeignKey("TickerListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PriceSource");

                    b.Navigation("TickerList");
                });
#pragma warning restore 612, 618
        }
    }
}
