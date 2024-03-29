﻿// <auto-generated />
using System;
using EF.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EF.WebAPI.Migrations
{
    [DbContext(typeof(HeroiContext))]
    [Migration("20191219220715_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EF.WebAPI.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HeroiId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EF.WebAPI.Models.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("DtFim");

                    b.Property<DateTime>("DtInicio");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EF.WebAPI.Models.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BatalhaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("BatalhaId");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EF.WebAPI.Models.Arma", b =>
                {
                    b.HasOne("EF.WebAPI.Models.Heroi", "Heroi")
                        .WithMany()
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EF.WebAPI.Models.Heroi", b =>
                {
                    b.HasOne("EF.WebAPI.Models.Batalha", "Batalha")
                        .WithMany()
                        .HasForeignKey("BatalhaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
