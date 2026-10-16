using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class MuestraDonanteOpcional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muestras_Donaciones_DonacionesID",
                table: "Muestras");

            migrationBuilder.AddColumn<int>(
                name: "DonanteID",
                table: "Muestras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Muestras_DonanteID",
                table: "Muestras",
                column: "DonanteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Muestras_Donaciones_DonacionesID",
                table: "Muestras",
                column: "DonacionesID",
                principalTable: "Donaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Muestras_Donantes_DonanteID",
                table: "Muestras",
                column: "DonanteID",
                principalTable: "Donantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muestras_Donaciones_DonacionesID",
                table: "Muestras");

            migrationBuilder.DropForeignKey(
                name: "FK_Muestras_Donantes_DonanteID",
                table: "Muestras");

            migrationBuilder.DropIndex(
                name: "IX_Muestras_DonanteID",
                table: "Muestras");

            migrationBuilder.DropColumn(
                name: "DonanteID",
                table: "Muestras");

            migrationBuilder.AddForeignKey(
                name: "FK_Muestras_Donaciones_DonacionesID",
                table: "Muestras",
                column: "DonacionesID",
                principalTable: "Donaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
