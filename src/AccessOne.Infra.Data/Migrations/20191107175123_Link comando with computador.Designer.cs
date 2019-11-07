﻿// <auto-generated />
using System;
using AccessOne.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccessOne.Infra.Data.Migrations
{
    [DbContext(typeof(AccessOneContext))]
    [Migration("20191107175123_Link comando with computador")]
    partial class Linkcomandowithcomputador
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccessOne.Domain.Models.Comando", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ComandoStr")
                        .IsRequired()
                        .HasColumnName("ComandoStr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ComputadorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataExecucao")
                        .HasColumnName("DataExecucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnName("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Retorno")
                        .HasColumnName("Retorno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComputadorId");

                    b.ToTable("Comando");
                });

            modelBuilder.Entity("AccessOne.Domain.Models.Computador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Disco")
                        .HasColumnName("EspacoEmDisco")
                        .HasColumnType("int");

                    b.Property<Guid?>("GrupoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnName("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Memoria")
                        .HasColumnName("Memoria")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Computador");
                });

            modelBuilder.Entity("AccessOne.Domain.Models.Grupo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("AccessOne.Domain.Models.Comando", b =>
                {
                    b.HasOne("AccessOne.Domain.Models.Computador", "Computador")
                        .WithMany("Comandos")
                        .HasForeignKey("ComputadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AccessOne.Domain.Models.Computador", b =>
                {
                    b.HasOne("AccessOne.Domain.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");
                });
#pragma warning restore 612, 618
        }
    }
}
