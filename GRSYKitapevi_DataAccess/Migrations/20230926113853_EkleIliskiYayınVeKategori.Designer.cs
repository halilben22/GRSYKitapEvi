﻿// <auto-generated />
using System;
using GRSYKitapevi_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GRSYKitapevi_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230926113853_EkleIliskiYayınVeKategori")]
    partial class EkleIliskiYayınVeKategori
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GRSYKitapEvi_Models.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("tb_kategoriler");
                });

            modelBuilder.Entity("GRSYKitapEvi_Models.Models.Kitap", b =>
                {
                    b.Property<int>("Kitap_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("KitapAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Kitap_Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("tb_Kitap");
                });

            modelBuilder.Entity("GRSYKitapEvi_Models.Models.Tur", b =>
                {
                    b.Property<int>("TurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoruntulemeSirasi")
                        .HasColumnType("int");

                    b.HasKey("TurId");

                    b.ToTable("Turler");
                });

            modelBuilder.Entity("GRSYKitapEvi_Models.Models.Yayınevi", b =>
                {
                    b.Property<int>("YayınEvi_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lokasyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayınEviAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YayınEvi_Id");

                    b.ToTable("tb_Yayinevi");
                });

            modelBuilder.Entity("GRSYKitapEvi_Models.Models.Yazar", b =>
                {
                    b.Property<int>("Yazar_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lokasyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazar_Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Yazar_Dogum_Tarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yazar_Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Yazar_Id");

                    b.ToTable("tb_Yazar");
                });

            modelBuilder.Entity("GRSYKitapEvi_Models.Models.Kitap", b =>
                {
                    b.HasOne("GRSYKitapEvi_Models.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });
#pragma warning restore 612, 618
        }
    }
}
