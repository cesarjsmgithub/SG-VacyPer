using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SG_VacyPer.Migrations
{
    /// <inheritdoc />
    public partial class SGVacyPerv07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVacaciones_IdEmpleado",
                table: "SolicitudVacaciones",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPermisos_IdEmpleado",
                table: "SolicitudPermisos",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudPermisos_IdPermisos",
                table: "SolicitudPermisos",
                column: "IdPermisos");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudPermisos_Empleados_IdEmpleado",
                table: "SolicitudPermisos",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudPermisos_Permisos_IdPermisos",
                table: "SolicitudPermisos",
                column: "IdPermisos",
                principalTable: "Permisos",
                principalColumn: "IdPermisos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVacaciones_Empleados_IdEmpleado",
                table: "SolicitudVacaciones",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudPermisos_Empleados_IdEmpleado",
                table: "SolicitudPermisos");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudPermisos_Permisos_IdPermisos",
                table: "SolicitudPermisos");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVacaciones_Empleados_IdEmpleado",
                table: "SolicitudVacaciones");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudVacaciones_IdEmpleado",
                table: "SolicitudVacaciones");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudPermisos_IdEmpleado",
                table: "SolicitudPermisos");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudPermisos_IdPermisos",
                table: "SolicitudPermisos");
        }
    }
}
