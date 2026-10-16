using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class CorregirNombresColumnasMuestra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "temperatura",
                table: "Muestras",
                newName: "Temperatura");

            migrationBuilder.RenameColumn(
                name: "sexo",
                table: "Muestras",
                newName: "Sexo");

            migrationBuilder.RenameColumn(
                name: "pulso",
                table: "Muestras",
                newName: "Pulso");

            migrationBuilder.RenameColumn(
                name: "fechaToma",
                table: "Muestras",
                newName: "FechaToma");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Muestras",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "edad",
                table: "Muestras",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "cantidadM",
                table: "Muestras",
                newName: "CantidadM");

            migrationBuilder.RenameColumn(
                name: "presionAlterial",
                table: "Muestras",
                newName: "PresionArterial");

            migrationBuilder.RenameColumn(
                name: "ApellidoDoante",
                table: "Muestras",
                newName: "ApellidoDonante");

            migrationBuilder.RenameColumn(
                name: "FechaDonacion",
                table: "Donaciones",
                newName: "fechaDonacion");

            migrationBuilder.AlterColumn<string>(
                name: "TipoSangre",
                table: "Muestras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "envase",
                table: "Donaciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperatura",
                table: "Muestras",
                newName: "temperatura");

            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "Muestras",
                newName: "sexo");

            migrationBuilder.RenameColumn(
                name: "Pulso",
                table: "Muestras",
                newName: "pulso");

            migrationBuilder.RenameColumn(
                name: "FechaToma",
                table: "Muestras",
                newName: "fechaToma");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Muestras",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Muestras",
                newName: "edad");

            migrationBuilder.RenameColumn(
                name: "CantidadM",
                table: "Muestras",
                newName: "cantidadM");

            migrationBuilder.RenameColumn(
                name: "PresionArterial",
                table: "Muestras",
                newName: "presionAlterial");

            migrationBuilder.RenameColumn(
                name: "ApellidoDonante",
                table: "Muestras",
                newName: "ApellidoDoante");

            migrationBuilder.RenameColumn(
                name: "fechaDonacion",
                table: "Donaciones",
                newName: "FechaDonacion");

            migrationBuilder.AlterColumn<string>(
                name: "TipoSangre",
                table: "Muestras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "envase",
                table: "Donaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
