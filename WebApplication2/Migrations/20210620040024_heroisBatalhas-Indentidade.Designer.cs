﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(Heroicontext))]
    [Migration("20210620040024_heroisBatalhas-Indentidade")]
    partial class heroisBatalhasIndentidade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.moldes.Arma", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiID")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("HeroiID");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("WebApplication2.moldes.Batalha", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DTfim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DTinicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("WebApplication2.moldes.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HErois");
                });

            modelBuilder.Entity("WebApplication2.moldes.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaID")
                        .HasColumnType("int");

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.HasKey("BatalhaID", "HeroiId");

                    b.HasIndex("HeroiId");

                    b.ToTable("HeroiBatalhas");
                });

            modelBuilder.Entity("WebApplication2.moldes.IndentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.Property<int>("NomeReal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId")
                        .IsUnique();

                    b.ToTable("IndentidadeSecretas");
                });

            modelBuilder.Entity("WebApplication2.moldes.Arma", b =>
                {
                    b.HasOne("WebApplication2.moldes.Heroi", "Heroi")
                        .WithMany("Armas")
                        .HasForeignKey("HeroiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Heroi");
                });

            modelBuilder.Entity("WebApplication2.moldes.HeroiBatalha", b =>
                {
                    b.HasOne("WebApplication2.moldes.Batalha", "Batalha")
                        .WithMany("heroiBatalhas")
                        .HasForeignKey("BatalhaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.moldes.Heroi", "Heroi")
                        .WithMany("heroiBatalhas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batalha");

                    b.Navigation("Heroi");
                });

            modelBuilder.Entity("WebApplication2.moldes.IndentidadeSecreta", b =>
                {
                    b.HasOne("WebApplication2.moldes.Heroi", "Heroi")
                        .WithOne("indentidade")
                        .HasForeignKey("WebApplication2.moldes.IndentidadeSecreta", "HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Heroi");
                });

            modelBuilder.Entity("WebApplication2.moldes.Batalha", b =>
                {
                    b.Navigation("heroiBatalhas");
                });

            modelBuilder.Entity("WebApplication2.moldes.Heroi", b =>
                {
                    b.Navigation("Armas");

                    b.Navigation("heroiBatalhas");

                    b.Navigation("indentidade");
                });
#pragma warning restore 612, 618
        }
    }
}
