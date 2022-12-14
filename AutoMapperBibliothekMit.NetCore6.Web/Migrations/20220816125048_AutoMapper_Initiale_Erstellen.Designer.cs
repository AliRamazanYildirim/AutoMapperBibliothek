// <auto-generated />
using System;
using AutoMapperBibliothekMit.NetCore6.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoMapperBibliothekMit.NetCore6.Web.Migrations
{
    [DbContext(typeof(AppDbKontext))]
    [Migration("20220816125048_AutoMapper_Initiale_Erstellen")]
    partial class AutoMapper_Initiale_Erstellen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoMapperBibliothekMit.NetCore6.Web.Models.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Inhalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KundeId")
                        .HasColumnType("int");

                    b.Property<string>("PostleitZahl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provinz")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KundeId");

                    b.ToTable("Adressen");
                });

            modelBuilder.Entity("AutoMapperBibliothekMit.NetCore6.Web.Models.Kunde", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Alter")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GeburtsDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Geschlecht")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kunden");
                });

            modelBuilder.Entity("AutoMapperBibliothekMit.NetCore6.Web.Models.Adresse", b =>
                {
                    b.HasOne("AutoMapperBibliothekMit.NetCore6.Web.Models.Kunde", "Kunde")
                        .WithMany("Adressen")
                        .HasForeignKey("KundeId");

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("AutoMapperBibliothekMit.NetCore6.Web.Models.Kunde", b =>
                {
                    b.Navigation("Adressen");
                });
#pragma warning restore 612, 618
        }
    }
}
