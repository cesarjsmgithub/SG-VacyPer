using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SG_VacyPer.Migrations
{
    /// <inheritdoc />
    public partial class SGVacyPerv02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Empleados_DocIdentidad",
                table: "Empleados");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Empleados",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefonos",
                table: "Empleados",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DocIdentidad",
                table: "Empleados",
                column: "DocIdentidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Empleados_DocIdentidad",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Telefonos",
                table: "Empleados");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DocIdentidad",
                table: "Empleados",
                column: "DocIdentidad",
                unique: true);
        }
    }
}
