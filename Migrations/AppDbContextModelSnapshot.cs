﻿// <auto-generated />
using CatalogoAutomotivo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatalogoAutomotivo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatalogoAutomotivo.MER.Alimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TipoAlimentacao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Alimentacao");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Aspiracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TipoAspiracao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Aspiracao");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlimentacaoId")
                        .HasColumnType("int");

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AspiracaoId")
                        .HasColumnType("int");

                    b.Property<int>("AutonomiaRodoviaria")
                        .HasColumnType("int");

                    b.Property<int>("AutonomiaUrbana")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeCombustivel")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("CombustivelId")
                        .HasColumnType("int");

                    b.Property<int>("ConsumoRodoviario")
                        .HasColumnType("int");

                    b.Property<int>("ConsumoUrbano")
                        .HasColumnType("int");

                    b.Property<int>("FabricanteId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreioDianteiro")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FreioTraseiro")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Motor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OleoMotor")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<string>("PneusDianteiros")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PneusTraseiros")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.Property<int>("PrecoTabela")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeLugares")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadePortas")
                        .HasColumnType("int");

                    b.Property<int>("RotacaoMaxima")
                        .HasColumnType("int");

                    b.Property<int>("TracaoId")
                        .HasColumnType("int");

                    b.Property<int>("TransmissaoId")
                        .HasColumnType("int");

                    b.Property<int>("VelocidadeMaxima")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlimentacaoId");

                    b.HasIndex("AspiracaoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CombustivelId");

                    b.HasIndex("FabricanteId");

                    b.HasIndex("TracaoId");

                    b.HasIndex("TransmissaoId");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Combustivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeCombustivel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Combustivel");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Fabricante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DataFundacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fundador")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sede")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Slogan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WebSite")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Fabricante");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Tracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TipoTracao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Tracao");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Transmissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TipoTransmissao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Transmissao");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Carro", b =>
                {
                    b.HasOne("CatalogoAutomotivo.MER.Alimentacao", "Alimentacao")
                        .WithMany("Carros")
                        .HasForeignKey("AlimentacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoAutomotivo.MER.Aspiracao", "Aspiracao")
                        .WithMany("Carros")
                        .HasForeignKey("AspiracaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoAutomotivo.MER.Categoria", "Categoria")
                        .WithMany("Carros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoAutomotivo.MER.Combustivel", "Combustivel")
                        .WithMany("Carros")
                        .HasForeignKey("CombustivelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoAutomotivo.MER.Fabricante", "Fabricante")
                        .WithMany("Carros")
                        .HasForeignKey("FabricanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoAutomotivo.MER.Tracao", "Tracao")
                        .WithMany("Carros")
                        .HasForeignKey("TracaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoAutomotivo.MER.Transmissao", "Transmissao")
                        .WithMany("Carros")
                        .HasForeignKey("TransmissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alimentacao");

                    b.Navigation("Aspiracao");

                    b.Navigation("Categoria");

                    b.Navigation("Combustivel");

                    b.Navigation("Fabricante");

                    b.Navigation("Tracao");

                    b.Navigation("Transmissao");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Alimentacao", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Aspiracao", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Categoria", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Combustivel", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Fabricante", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Tracao", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CatalogoAutomotivo.MER.Transmissao", b =>
                {
                    b.Navigation("Carros");
                });
#pragma warning restore 612, 618
        }
    }
}
