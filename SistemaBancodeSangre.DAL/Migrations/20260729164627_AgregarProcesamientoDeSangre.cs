using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class AgregarProcesamientoDeSangre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "volumenDN",
                table: "Procesamientos",
                newName: "VolumenDN");

            migrationBuilder.RenameColumn(
                name: "tipodeSangre",
                table: "Procesamientos",
                newName: "TipoDeSangre");

            migrationBuilder.RenameColumn(
                name: "fechaProceso",
                table: "Procesamientos",
                newName: "FechaProceso");

            migrationBuilder.RenameColumn(
                name: "estadoProceso",
                table: "Procesamientos",
                newName: "EstadoProceso");

            migrationBuilder.RenameColumn(
                name: "tipoDeSangre",
                table: "Donaciones",
                newName: "TipoDeSangre");

            migrationBuilder.RenameColumn(
                name: "proposito",
                table: "Donaciones",
                newName: "Proposito");

            migrationBuilder.RenameColumn(
                name: "fechaDonacion",
                table: "Donaciones",
                newName: "FechaDonacion");

            migrationBuilder.RenameColumn(
                name: "envase",
                table: "Donaciones",
                newName: "Envase");

            migrationBuilder.RenameColumn(
                name: "cantidadSangre",
                table: "Donaciones",
                newName: "CantidadSangre");

            migrationBuilder.RenameColumn(
                name: "analista",
                table: "Donaciones",
                newName: "Analista");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDeSangre",
                table: "Procesamientos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstadoProceso",
                table: "Procesamientos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Almacenado",
                table: "Procesamientos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnalisisID",
                table: "Procesamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ConcentradoGlobulosRojos",
                table: "Procesamientos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MuestraID",
                table: "Procesamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroSangre",
                table: "Procesamientos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Plaquetas",
                table: "Procesamientos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Plasma",
                table: "Procesamientos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NumeroSangre",
                table: "Donaciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Procesamientos_AnalisisID",
                table: "Procesamientos",
                column: "AnalisisID");

            migrationBuilder.CreateIndex(
                name: "IX_Procesamientos_MuestraID",
                table: "Procesamientos",
                column: "MuestraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Procesamientos_Analisis_AnalisisID",
                table: "Procesamientos",
                column: "AnalisisID",
                principalTable: "Analisis",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Procesamientos_Muestras_MuestraID",
                table: "Procesamientos",
                column: "MuestraID",
                principalTable: "Muestras",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procesamientos_Analisis_AnalisisID",
                table: "Procesamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Procesamientos_Muestras_MuestraID",
                table: "Procesamientos");

            migrationBuilder.DropIndex(
                name: "IX_Procesamientos_AnalisisID",
                table: "Procesamientos");

            migrationBuilder.DropIndex(
                name: "IX_Procesamientos_MuestraID",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "AnalisisID",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "ConcentradoGlobulosRojos",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "MuestraID",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "NumeroSangre",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "Plaquetas",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "Plasma",
                table: "Procesamientos");

            migrationBuilder.DropColumn(
                name: "NumeroSangre",
                table: "Donaciones");

            migrationBuilder.RenameColumn(
                name: "VolumenDN",
                table: "Procesamientos",
                newName: "volumenDN");

            migrationBuilder.RenameColumn(
                name: "TipoDeSangre",
                table: "Procesamientos",
                newName: "tipodeSangre");

            migrationBuilder.RenameColumn(
                name: "FechaProceso",
                table: "Procesamientos",
                newName: "fechaProceso");

            migrationBuilder.RenameColumn(
                name: "EstadoProceso",
                table: "Procesamientos",
                newName: "estadoProceso");

            migrationBuilder.RenameColumn(
                name: "TipoDeSangre",
                table: "Donaciones",
                newName: "tipoDeSangre");

            migrationBuilder.RenameColumn(
                name: "Proposito",
                table: "Donaciones",
                newName: "proposito");

            migrationBuilder.RenameColumn(
                name: "FechaDonacion",
                table: "Donaciones",
                newName: "fechaDonacion");

            migrationBuilder.RenameColumn(
                name: "Envase",
                table: "Donaciones",
                newName: "envase");

            migrationBuilder.RenameColumn(
                name: "CantidadSangre",
                table: "Donaciones",
                newName: "cantidadSangre");

            migrationBuilder.RenameColumn(
                name: "Analista",
                table: "Donaciones",
                newName: "analista");

            migrationBuilder.AlterColumn<string>(
                name: "tipodeSangre",
                table: "Procesamientos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "estadoProceso",
                table: "Procesamientos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Almacenado",
                table: "Procesamientos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
