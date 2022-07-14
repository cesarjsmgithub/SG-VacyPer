using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SG_VacyPer.Migrations
{
    /// <inheritdoc />
    public partial class SGVacyPerv06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdVacaciones",
                table: "Empleados",
                column: "IdVacaciones");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Vacaciones_IdVacaciones",
                table: "Empleados",
                column: "IdVacaciones",
                principalTable: "Vacaciones",
                principalColumn: "IdVacaciones",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Vacaciones_IdVacaciones",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdVacaciones",
                table: "Empleados");
        }
    }
}
