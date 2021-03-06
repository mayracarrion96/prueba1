// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(Repositorio))]
    [Migration("20220124234213_Prueba")]
    partial class Prueba
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Address", b =>
                {
                    b.Property<int>("addressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<string>("district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("lastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("addressId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Modelo.Entidades.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<bool>("activebool")
                        .HasColumnType("bit");

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("lastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("storeId")
                        .HasColumnType("int");

                    b.HasKey("customerId");

                    b.HasIndex("addressId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Modelo.Entidades.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("paymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("rentalId")
                        .HasColumnType("int");

                    b.Property<int>("stafftId")
                        .HasColumnType("int");

                    b.HasKey("paymentId");

                    b.HasIndex("customerId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("Modelo.Entidades.Customer", b =>
                {
                    b.HasOne("Modelo.Entidades.Address", "Address")
                        .WithMany("Customer")
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Modelo.Entidades.Payment", b =>
                {
                    b.HasOne("Modelo.Entidades.Customer", "Customer")
                        .WithMany("Payment")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Modelo.Entidades.Address", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Modelo.Entidades.Customer", b =>
                {
                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
