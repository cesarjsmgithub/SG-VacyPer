using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SG_VacyPer.Migrations
{
    /// <inheritdoc />
    public partial class SGVacyPerv05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VacacionesId",
                table: "Empleados",
                newName: "OtrosMotivos");

            migrationBuilder.RenameColumn(
                name: "OtrosPermisos",
                table: "Empleados",
                newName: "NacimientoHijos");

            migrationBuilder.AddColumn<int>(
                name: "AsuntosPropios",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Formacion",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVacaciones",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncapacidadTemporal",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Matrimonio",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SolicitudPermisos",
                columns: table => new
                {
                    IdSolicitudPermisos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdPermisos = table.Column<int>(type: "int", nullable: false),
                    DocIdentidad = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaComienzo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MotivoRechazo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudPermisos", x => x.IdSolicitudPermisos);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudVacaciones",
                columns: table => new
                {
                    IdSolicitudVacaciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    DocIdentidad = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaComienzo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MotivoRechazo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudVacaciones", x => x.IdSolicitudVacaciones);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPermisos_DocIdentidad",
                table: "SolicitudPermisos",
                column: "DocIdentidad");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPermisos_Estado",
                table: "SolicitudPermisos",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPermisos_FechaComienzo",
                table: "SolicitudPermisos",
                column: "FechaComienzo");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPermisos_FechaSolicitud",
                table: "SolicitudPermisos",
                column: "FechaSolicitud");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVacaciones_DocIdentidad",
                table: "SolicitudVacaciones",
                column: "DocIdentidad");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVacaciones_Estado",
                table: "SolicitudVacaciones",
                column: "Estado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitudPermisos");

            migrationBuilder.DropTable(
                name: "SolicitudVacaciones");

            migrationBuilder.DropColumn(
                name: "AsuntosPropios",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Formacion",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdVacaciones",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IncapacidadTemporal",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Matrimonio",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "OtrosMotivos",
                table: "Empleados",
                newName: "VacacionesId");

            migrationBuilder.RenameColumn(
                name: "NacimientoHijos",
                table: "Empleados",
                newName: "OtrosPermisos");
        }
    }
}
