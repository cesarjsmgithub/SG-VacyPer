// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SG_VacyPer.AppData;

#nullable disable

namespace SG_VacyPer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220713155236_SG-VacyPer-v08")]
    partial class SGVacyPerv08
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SG_VacyPer.Models.Calendario", b =>
                {
                    b.Property<int>("IdCalendario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCalendario"), 1L, 1);

                    b.Property<DateTime>("Comienzo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCalendario");

                    b.HasIndex("Comienzo");

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("SG_VacyPer.Models.Empleados", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"), 1L, 1);

                    b.Property<int>("AsuntosPropios")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DocIdentidad")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("Formacion")
                        .HasColumnType("int");

                    b.Property<int>("IdVacaciones")
                        .HasColumnType("int");

                    b.Property<int>("IncapacidadTemporal")
                        .HasColumnType("int");

                    b.Property<int>("Matrimonio")
                        .HasColumnType("int");

                    b.Property<int>("NacimientoHijos")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("OtrosMotivos")
                        .HasColumnType("int");

                    b.Property<int>("ResponsableId")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefonos")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("VacacionesDisfrutadas")
                        .HasColumnType("int");

                    b.HasKey("IdEmpleado");

                    b.HasIndex("DocIdentidad")
                        .IsUnique();

                    b.HasIndex("IdVacaciones");

                    b.HasIndex("NombreCompleto");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("SG_VacyPer.Models.Permisos", b =>
                {
                    b.Property<int>("IdPermisos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPermisos"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("DiasOficiales")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdPermisos");

                    b.HasIndex("Descripcion");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("SG_VacyPer.Models.SolicitudPermisos", b =>
                {
                    b.Property<int>("IdSolicitudPermisos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSolicitudPermisos"), 1L, 1);

                    b.Property<string>("Comentarios")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DocIdentidad")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("FechaComienzo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdPermisos")
                        .HasColumnType("int");

                    b.Property<string>("MotivoRechazo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdSolicitudPermisos");

                    b.HasIndex("DocIdentidad");

                    b.HasIndex("Estado");

                    b.HasIndex("FechaComienzo");

                    b.HasIndex("FechaSolicitud");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdPermisos");

                    b.ToTable("SolicitudPermisos");
                });

            modelBuilder.Entity("SG_VacyPer.Models.SolicitudVacaciones", b =>
                {
                    b.Property<int>("IdSolicitudVacaciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSolicitudVacaciones"), 1L, 1);

                    b.Property<string>("Comentarios")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DocIdentidad")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("FechaComienzo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdVacaciones")
                        .HasColumnType("int");

                    b.Property<string>("MotivoRechazo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdSolicitudVacaciones");

                    b.HasIndex("DocIdentidad");

                    b.HasIndex("Estado");

                    b.HasIndex("IdEmpleado");

                    b.ToTable("SolicitudVacaciones");
                });

            modelBuilder.Entity("SG_VacyPer.Models.Vacaciones", b =>
                {
                    b.Property<int>("IdVacaciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVacaciones"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("DiasAdicionales")
                        .HasColumnType("int");

                    b.Property<int>("DiasOficiales")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IdVacaciones");

                    b.ToTable("Vacaciones");
                });

            modelBuilder.Entity("SG_VacyPer.Models.Empleados", b =>
                {
                    b.HasOne("SG_VacyPer.Models.Vacaciones", "Vacaciones")
                        .WithMany("Empleadoss")
                        .HasForeignKey("IdVacaciones")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vacaciones");
                });

            modelBuilder.Entity("SG_VacyPer.Models.SolicitudPermisos", b =>
                {
                    b.HasOne("SG_VacyPer.Models.Empleados", "Empleados")
                        .WithMany("SolicitudPermisoss")
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SG_VacyPer.Models.Permisos", "Permisos")
                        .WithMany()
                        .HasForeignKey("IdPermisos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleados");

                    b.Navigation("Permisos");
                });

            modelBuilder.Entity("SG_VacyPer.Models.SolicitudVacaciones", b =>
                {
                    b.HasOne("SG_VacyPer.Models.Empleados", "Empleados")
                        .WithMany("SolicitudVacacioness")
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("SG_VacyPer.Models.Empleados", b =>
                {
                    b.Navigation("SolicitudPermisoss");

                    b.Navigation("SolicitudVacacioness");
                });

            modelBuilder.Entity("SG_VacyPer.Models.Vacaciones", b =>
                {
                    b.Navigation("Empleadoss");
                });
#pragma warning restore 612, 618
        }
    }
}
