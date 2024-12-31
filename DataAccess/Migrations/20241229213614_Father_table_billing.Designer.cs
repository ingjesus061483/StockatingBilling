﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(StockatingDbContext))]
    [Migration("20241229213614_Father_table_billing")]
    partial class Father_table_billing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Factory.BillDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BillHeaderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillHeaderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("BillDetail");
                });

            modelBuilder.Entity("Factory.BillHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Credit")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StateId");

                    b.ToTable("BillHeaders");
                });

            modelBuilder.Entity("Factory.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Factory.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdentificationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.HasIndex("IdentificationTypeId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Factory.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("RegimenTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Slogan")
                        .HasColumnType("longtext");

                    b.Property<string>("TradeCamera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Nit")
                        .IsUnique();

                    b.HasIndex("RegimenTypeId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "b / quilla",
                            Contact = "pepito perez",
                            Email = "alguien@ejempo.com",
                            Name = "Empresa de prueba",
                            Nit = "11111 - 1",
                            Phone = "5444555",
                            RegimenTypeId = 1,
                            Slogan = "",
                            TradeCamera = "0001"
                        });
                });

            modelBuilder.Entity("Factory.DetailPay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MethodPaymentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MethodPaymentId");

                    b.HasIndex("PaymentId");

                    b.ToTable("DetailPays");
                });

            modelBuilder.Entity("Factory.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Factura"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Compra"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Ticket"
                        });
                });

            modelBuilder.Entity("Factory.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdentificationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.HasIndex("IdentificationTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "B/quilla",
                            Identification = "11111",
                            IdentificationTypeId = 1,
                            LastName = "admin",
                            Name = "admin",
                            Phone = "55555",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Factory.IdentificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("IdentificationTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "cedula de ciudadania"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "nit"
                        });
                });

            modelBuilder.Entity("Factory.MethodPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MethodPays");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Contado"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Datafono"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Tranferencia"
                        });
                });

            modelBuilder.Entity("Factory.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BillHeaderId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BillHeaderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Factory.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Factory.PictureProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PictureID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PictureID");

                    b.HasIndex("ProductID");

                    b.ToTable("PictureProducts");
                });

            modelBuilder.Entity("Factory.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitMeasurementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("UnitMeasurementId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Factory.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdentificationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.HasIndex("IdentificationTypeId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Factory.RegimenType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RegimenTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Simplificado"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Comun"
                        });
                });

            modelBuilder.Entity("Factory.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Administrador"
                        });
                });

            modelBuilder.Entity("Factory.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "En proceso"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Entregado"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Pagado"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "En mora"
                        });
                });

            modelBuilder.Entity("Factory.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Entrance")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("Factory.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Factory.UnitMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UnitMeasurement");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Gramo"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Litro"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Unidad"
                        });
                });

            modelBuilder.Entity("Factory.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Email = "example1@mail.com",
                            Name = "admin",
                            Password = "YQBkAG0AaQBuADEAMgAzADQALgA=",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Factory.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("StockMaximo")
                        .HasColumnType("int");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int");

                    b.Property<bool>("limitado")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Factory.BillDetail", b =>
                {
                    b.HasOne("Factory.BillHeader", "BillHeader")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Warehouse", "Warehouse")
                        .WithMany("BillDetails")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("BillHeader");

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Factory.BillHeader", b =>
                {
                    b.HasOne("Factory.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.DocumentType", "DocumentType")
                        .WithMany("BillHeaders")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.State", "State")
                        .WithMany("BillHeaders")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("DocumentType");

                    b.Navigation("Employee");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Factory.Client", b =>
                {
                    b.HasOne("Factory.IdentificationType", "IdentificationType")
                        .WithMany("Clients")
                        .HasForeignKey("IdentificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentificationType");
                });

            modelBuilder.Entity("Factory.Company", b =>
                {
                    b.HasOne("Factory.RegimenType", "RegimenType")
                        .WithMany("Companies")
                        .HasForeignKey("RegimenTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegimenType");
                });

            modelBuilder.Entity("Factory.DetailPay", b =>
                {
                    b.HasOne("Factory.MethodPayment", "MethodPayment")
                        .WithMany()
                        .HasForeignKey("MethodPaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MethodPayment");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Factory.Employee", b =>
                {
                    b.HasOne("Factory.IdentificationType", "IdentificationType")
                        .WithMany("Employees")
                        .HasForeignKey("IdentificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.User", "User")
                        .WithMany("Employees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentificationType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Factory.Payment", b =>
                {
                    b.HasOne("Factory.BillHeader", "BillHeader")
                        .WithMany()
                        .HasForeignKey("BillHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillHeader");
                });

            modelBuilder.Entity("Factory.PictureProduct", b =>
                {
                    b.HasOne("Factory.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Factory.Product", b =>
                {
                    b.HasOne("Factory.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.UnitMeasurement", "UnitMeasurement")
                        .WithMany("Products")
                        .HasForeignKey("UnitMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("UnitMeasurement");
                });

            modelBuilder.Entity("Factory.Provider", b =>
                {
                    b.HasOne("Factory.IdentificationType", "IdentificationType")
                        .WithMany("Providers")
                        .HasForeignKey("IdentificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentificationType");
                });

            modelBuilder.Entity("Factory.Stock", b =>
                {
                    b.HasOne("Factory.Product", "Product")
                        .WithMany("Stocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Factory.User", b =>
                {
                    b.HasOne("Factory.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Factory.BillHeader", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Factory.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Factory.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Factory.DocumentType", b =>
                {
                    b.Navigation("BillHeaders");
                });

            modelBuilder.Entity("Factory.IdentificationType", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Employees");

                    b.Navigation("Providers");
                });

            modelBuilder.Entity("Factory.Product", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("Factory.RegimenType", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("Factory.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Factory.State", b =>
                {
                    b.Navigation("BillHeaders");
                });

            modelBuilder.Entity("Factory.UnitMeasurement", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Factory.User", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Factory.Warehouse", b =>
                {
                    b.Navigation("BillDetails");
                });
#pragma warning restore 612, 618
        }
    }
}