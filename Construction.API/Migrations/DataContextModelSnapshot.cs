﻿// <auto-generated />
using System;
using Construction.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Construction.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Construction.Shared.Entities.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ListaMiembros")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Maquinaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<bool>("Disponibilidad")
                        .HasColumnType("bit");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Maquinarias");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProyectosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectosId");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Presupuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("PresupuestoManoObra")
                        .HasColumnType("float");

                    b.Property<double>("PresupuestoMaquinaria")
                        .HasColumnType("float");

                    b.Property<double>("PresupuestoMateriales")
                        .HasColumnType("float");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId")
                        .IsUnique();

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.ProyectoEquipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquiposId")
                        .HasColumnType("int");

                    b.Property<int?>("ProyectosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquiposId");

                    b.HasIndex("ProyectosId");

                    b.ToTable("ProyectosEquipos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaquinariasId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProyectosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaquinariasId");

                    b.HasIndex("ProyectosId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entities.TareaMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaterialesId")
                        .HasColumnType("int");

                    b.Property<int?>("TareasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialesId");

                    b.HasIndex("TareasId");

                    b.ToTable("TareasMateriales");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Maquinaria", b =>
                {
                    b.HasOne("Construction.Shared.Entities.Proyecto", "Proyectos")
                        .WithMany("Maquinarias")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Material", b =>
                {
                    b.HasOne("Construction.Shared.Entities.Proyecto", "Proyectos")
                        .WithMany("Materiales")
                        .HasForeignKey("ProyectosId");

                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Presupuesto", b =>
                {
                    b.HasOne("Construction.Shared.Entities.Proyecto", "Proyectos")
                        .WithOne("Presupuestos")
                        .HasForeignKey("Construction.Shared.Entities.Presupuesto", "ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.ProyectoEquipo", b =>
                {
                    b.HasOne("Construction.Shared.Entities.Equipo", "Equipos")
                        .WithMany("ProyectosEquipos")
                        .HasForeignKey("EquiposId");

                    b.HasOne("Construction.Shared.Entities.Proyecto", "Proyectos")
                        .WithMany("ProyectosEquipos")
                        .HasForeignKey("ProyectosId");

                    b.Navigation("Equipos");

                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Tarea", b =>
                {
                    b.HasOne("Construction.Shared.Entities.Maquinaria", "Maquinarias")
                        .WithMany("Tareas")
                        .HasForeignKey("MaquinariasId");

                    b.HasOne("Construction.Shared.Entities.Proyecto", "Proyectos")
                        .WithMany("Tareas")
                        .HasForeignKey("ProyectosId");

                    b.Navigation("Maquinarias");

                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.TareaMaterial", b =>
                {
                    b.HasOne("Construction.Shared.Entities.Material", "Materiales")
                        .WithMany("TareasMateriales")
                        .HasForeignKey("MaterialesId");

                    b.HasOne("Construction.Shared.Entities.Tarea", "Tareas")
                        .WithMany("TareasMateriales")
                        .HasForeignKey("TareasId");

                    b.Navigation("Materiales");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Equipo", b =>
                {
                    b.Navigation("ProyectosEquipos");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Maquinaria", b =>
                {
                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Material", b =>
                {
                    b.Navigation("TareasMateriales");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Proyecto", b =>
                {
                    b.Navigation("Maquinarias");

                    b.Navigation("Materiales");

                    b.Navigation("Presupuestos");

                    b.Navigation("ProyectosEquipos");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entities.Tarea", b =>
                {
                    b.Navigation("TareasMateriales");
                });
#pragma warning restore 612, 618
        }
    }
}
