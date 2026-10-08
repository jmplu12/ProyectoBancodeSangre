using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class AgregarMuestraDonacionesid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muestras_Donantes_DonanteID",
                table: "Muestras");

            migrationBuilder.RenameColumn(
                name: "DonanteID",
                table: "Muestras",
                newName: "DonacionesID");

            migrationBuilder.RenameIndex(
                name: "IX_Muestras_DonanteID",
                table: "Muestras",
                newName: "IX_Muestras_DonacionesID");

            migrationBuilder.AddColumn<int>(
                name: "DonantesEntityID",
                table: "Muestras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Muestras_DonantesEntityID",
                table: "Muestras",
                column: "DonantesEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Muestras_Donaciones_DonacionesID",
                table: "Muestras",
                column: "DonacionesID",
                principalTable: "Donaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Muestras_Donantes_DonantesEntityID",
                table: "Muestras",
                column: "DonantesEntityID",
                principalTable: "Donantes",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muestras_Donaciones_DonacionesID",
                table: "Muestras");

            migrationBuilder.DropForeignKey(
                name: "FK_Muestras_Donantes_DonantesEntityID",
                table: "Muestras");

            migrationBuilder.DropIndex(
                name: "IX_Muestras_DonantesEntityID",
                table: "Muestras");

            migrationBuilder.DropColumn(
                name: "DonantesEntityID",
                table: "Muestras");

            migrationBuilder.RenameColumn(
                name: "DonacionesID",
                table: "Muestras",
                newName: "DonanteID");

            migrationBuilder.RenameIndex(
                name: "IX_Muestras_DonacionesID",
                table: "Muestras",
                newName: "IX_Muestras_DonanteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Muestras_Donantes_DonanteID",
                table: "Muestras",
                column: "DonanteID",
                principalTable: "Donantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
