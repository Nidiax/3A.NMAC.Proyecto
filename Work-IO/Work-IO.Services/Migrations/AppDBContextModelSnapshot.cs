﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Work_IO.Services;

namespace Work_IO.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Work_IO.Models.Asesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CuentaId");

                    b.ToTable("Asesores");
                });

            modelBuilder.Entity("Work_IO.Models.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Curp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_civil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha_Nam")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Genero")
                        .HasColumnType("bit");

                    b.Property<string>("Lugar_Nam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NSS")
                        .HasColumnType("int");

                    b.Property<int>("NacionalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<int>("RFC")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NacionalidadId");

                    b.HasIndex("OrdenId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("Work_IO.Models.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Work_IO.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<string>("TipoD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("Work_IO.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Work_IO.Models.Nacionalidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<string>("TipoNa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Nacionalidad");
                });

            modelBuilder.Entity("Work_IO.Models.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsesorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<string>("TipoVacante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AsesorId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Work_IO.Models.Referencias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desempenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha_separacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fun_ultimopuesto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inicio_laboral")
                        .HasColumnType("datetime2");

                    b.Property<string>("Motivos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_informante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Puesto_candidato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Puesto_informante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Puestos_anteriores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sueldo")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_contrato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Referencias");
                });

            modelBuilder.Entity("Work_IO.Models.Asesor", b =>
                {
                    b.HasOne("Work_IO.Models.Cuenta", "Cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Work_IO.Models.Candidato", b =>
                {
                    b.HasOne("Work_IO.Models.Nacionalidad", "Nacionalidad")
                        .WithMany()
                        .HasForeignKey("NacionalidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work_IO.Models.Orden", "Orden")
                        .WithMany("Candidatos")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Work_IO.Models.Documento", b =>
                {
                    b.HasOne("Work_IO.Models.Candidato", "Candidato")
                        .WithMany("Documentos")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Work_IO.Models.Orden", b =>
                {
                    b.HasOne("Work_IO.Models.Asesor", "Asesor")
                        .WithMany("Ordenes")
                        .HasForeignKey("AsesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work_IO.Models.Empresa", "Empresa")
                        .WithMany("Ordenes")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Work_IO.Models.Referencias", b =>
                {
                    b.HasOne("Work_IO.Models.Candidato", "Candidato")
                        .WithMany("Referencias")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
