﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalApi.Infraestrutura.Db;

#nullable disable

namespace MinimalApi.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20241010175709_CriaBancoMigration")]
    partial class CriaBancoMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "administrador@teste.com",
                            Perfil = "Adm",
                            Senha = "123456"
                        });
                });

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("MarcaVeiculoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("MarcaVeiculoId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeMarca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MarcaVeiculo");
                });

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Veiculo", b =>
                {
                    b.HasOne("MinimalApi.Dominio.Entidades.Marca", "MarcaVeiculo")
                        .WithMany("Veiculos")
                        .HasForeignKey("MarcaVeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MarcaVeiculo");
                });

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Marca", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
