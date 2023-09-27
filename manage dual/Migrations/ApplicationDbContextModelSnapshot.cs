﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using manage_dual.NewFolder;

#nullable disable

namespace manage_dual.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("manage_dual.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<int>("Client_Item_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ItemDateAddedToSystem")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("Client_Item_Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("manage_dual.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("PaymentAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payment_Client_id")
                        .HasColumnType("int");

                    b.Property<int>("RemainingPayments")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("Payment_Client_id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("manage_dual.Models.client", b =>
                {
                    b.Property<int>("clientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clientId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ClientDateAddedToSystem")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("clientId");

                    b.ToTable("client");

                    b.HasData(
                        new
                        {
                            clientId = 1,
                            Address = "St 124",
                            City = "Amman",
                            ClientDateAddedToSystem = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ahmad3323@gmail.com",
                            Name = "Ahmad",
                            PhoneNumber = "079649321763",
                            PostalCode = "342667"
                        },
                        new
                        {
                            clientId = 2,
                            Address = "St 1324",
                            City = "Amman",
                            ClientDateAddedToSystem = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ali3323@gmail.com",
                            Name = "Ali",
                            PhoneNumber = "07964421763",
                            PostalCode = "134667"
                        },
                        new
                        {
                            clientId = 3,
                            Address = "St 1214",
                            City = "Amman",
                            ClientDateAddedToSystem = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Yaser4323@gmail.com",
                            Name = "Yaser",
                            PhoneNumber = "079649351763",
                            PostalCode = "142667"
                        },
                        new
                        {
                            clientId = 4,
                            Address = "St 1244",
                            City = "Amman",
                            ClientDateAddedToSystem = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "khaled4323@gmail.com",
                            Name = "khaled",
                            PhoneNumber = "079649521763",
                            PostalCode = "242667"
                        },
                        new
                        {
                            clientId = 5,
                            Address = "St 1224",
                            City = "Amman",
                            ClientDateAddedToSystem = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mhmod4323@gmail.com",
                            Name = "mhmod",
                            PhoneNumber = "079649321763",
                            PostalCode = "352667"
                        },
                        new
                        {
                            clientId = 6,
                            Address = "St 1264",
                            City = "Amman",
                            ClientDateAddedToSystem = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mustafa4323@gmail.com",
                            Name = "mustafa",
                            PhoneNumber = "079149321762",
                            PostalCode = "842667"
                        });
                });

            modelBuilder.Entity("manage_dual.Models.Item", b =>
                {
                    b.HasOne("manage_dual.Models.client", "client")
                        .WithMany("Item")
                        .HasForeignKey("Client_Item_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("manage_dual.Models.Payment", b =>
                {
                    b.HasOne("manage_dual.Models.client", "client")
                        .WithMany("Payment")
                        .HasForeignKey("Payment_Client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("manage_dual.Models.client", b =>
                {
                    b.Navigation("Item");

                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
