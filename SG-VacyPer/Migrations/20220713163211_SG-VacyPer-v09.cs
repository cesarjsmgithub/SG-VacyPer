using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SG_VacyPer.Migrations
{
    /// <inheritdoc />
    public partial class SGVacyPerv09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdVacaciones",
                table: "SolicitudVacaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVacaciones_IdVacaciones",
                table: "SolicitudVacaciones",
                column: "IdVacaciones");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVacaciones_Vacaciones_IdVacaciones",
                table: "SolicitudVacaciones",
                column: "IdVacaciones",
                principalTable: "Vacaciones",
                principalColumn: "IdVacaciones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVacaciones_Vacaciones_IdVacaciones",
                table: "SolicitudVacaciones");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudVacaciones_IdVacaciones",
                table: "SolicitudVacaciones");

            migrationBuilder.AlterColumn<int>(
                name: "IdVacaciones",
                table: "SolicitudVacaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
