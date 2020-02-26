﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoInscripciones.Data;

namespace ProyectoInscripciones.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("ProyectoInscripciones.Models.Asignaturas", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Creditos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PreRequisito")
                        .HasColumnType("TEXT");

                    b.HasKey("AsignaturaId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("ProyectoInscripciones.Models.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("ProyectoInscripciones.Models.Inscripcion", b =>
                {
                    b.Property<int>("InscripcionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("InscripcionesId");

                    b.ToTable("Inscripcions");
                });

            modelBuilder.Entity("ProyectoInscripciones.Models.Pagos", b =>
                {
                    b.Property<int>("PagosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("InscripcionId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("PagosId");

                    b.ToTable("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
