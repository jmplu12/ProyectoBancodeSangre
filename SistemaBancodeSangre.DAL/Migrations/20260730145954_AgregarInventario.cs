using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class AgregarInventario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Inventario_InventarioID",
                table: "Donaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Donantes_Empleados_EmpleadosID",
                table: "Donantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Empleados_EmpleadoID",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Procesamientos_Donaciones_DonacionesID",
                table: "Procesamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoID",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "EntregaEntitySolicitudEntity");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_InventarioID",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "InventarioID",
                table: "Donaciones");

            migrationBuilder.RenameColumn(
                name: "fechaVencimiento",
                table: "Inventario",
                newName: "FechaVencimiento");

            migrationBuilder.RenameColumn(
                name: "cantidadDisponible",
                table: "Inventario",
                newName: "CantidadDisponible");

            migrationBuilder.RenameColumn(
                name: "DonacionesID",
                table: "Inventario",
                newName: "ProcesamientoID");

            migrationBuilder.RenameColumn(
                name: "tipoDeSangre",
                table: "Entregas",
                newName: "TipoDeSangre");

            migrationBuilder.RenameColumn(
                name: "cantidadEntregada",
                table: "Entregas",
                newName: "CantidadEntregada");

            migrationBuilder.RenameColumn(
                name: "Fechaentrega",
                table: "Entregas",
                newName: "FechaEntrega");

            migrationBuilder.RenameColumn(
                name: "DonanteID",
                table: "Entregas",
                newName: "InventarioID");

            migrationBuilder.AlterColumn<string>(
                name: "tipoDeSangresolicitada",
                table: "Solicitudes",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "prioridad",
                table: "Solicitudes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "exequatur",
                table: "Solicitudes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "estadoSolicitud",
                table: "Solicitudes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cantidad",
                table: "Solicitudes",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "VolumenDN",
                table: "Procesamientos",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "CantidadInicial",
                table: "Inventario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CodigoBolsa",
                table: "Inventario",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoID",
                table: "Inventario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Inventario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDonacion",
                table: "Inventario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "Inventario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "TipoDeSangre",
                table: "Entregas",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CantidadEntregada",
                table: "Entregas",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadosEntityID",
                table: "Entregas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CantidadSangre",
                table: "Donaciones",
                type: "int",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_CodigoBolsa",
                table: "Inventario",
                column: "CodigoBolsa",
                unique: true,
                filter: "[CodigoBolsa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_EmpleadoID",
                table: "Inventario",
                column: "EmpleadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_ProcesamientoID",
                table: "Inventario",
                column: "ProcesamientoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_EmpleadosEntityID",
                table: "Entregas",
                column: "EmpleadosEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_InventarioID",
                table: "Entregas",
                column: "InventarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_SolicitudID",
                table: "Entregas",
                column: "SolicitudID");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_NumeroSangre",
                table: "Donaciones",
                column: "NumeroSangre",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones",
                column: "DonanteID",
                principalTable: "Donantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donantes_Empleados_EmpleadosID",
                table: "Donantes",
                column: "EmpleadosID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Empleados_EmpleadoID",
                table: "Entregas",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Empleados_EmpleadosEntityID",
                table: "Entregas",
                column: "EmpleadosEntityID",
                principalTable: "Empleados",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Inventario_InventarioID",
                table: "Entregas",
                column: "InventarioID",
                principalTable: "Inventario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Solicitudes_SolicitudID",
                table: "Entregas",
                column: "SolicitudID",
                principalTable: "Solicitudes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_Empleados_EmpleadoID",
                table: "Inventario",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_Procesamientos_ProcesamientoID",
                table: "Inventario",
                column: "ProcesamientoID",
                principalTable: "Procesamientos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procesamientos_Donaciones_DonacionesID",
                table: "Procesamientos",
                column: "DonacionesID",
                principalTable: "Donaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoID",
                table: "Usuarios",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Donantes_Empleados_EmpleadosID",
                table: "Donantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Empleados_EmpleadoID",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Empleados_EmpleadosEntityID",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Inventario_InventarioID",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Solicitudes_SolicitudID",
                table: "Entregas");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_Empleados_EmpleadoID",
                table: "Inventario");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_Procesamientos_ProcesamientoID",
                table: "Inventario");

            migrationBuilder.DropForeignKey(
                name: "FK_Procesamientos_Donaciones_DonacionesID",
                table: "Procesamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoID",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Inventario_CodigoBolsa",
                table: "Inventario");

            migrationBuilder.DropIndex(
                name: "IX_Inventario_EmpleadoID",
                table: "Inventario");

            migrationBuilder.DropIndex(
                name: "IX_Inventario_ProcesamientoID",
                table: "Inventario");

            migrationBuilder.DropIndex(
                name: "IX_Entregas_EmpleadosEntityID",
                table: "Entregas");

            migrationBuilder.DropIndex(
                name: "IX_Entregas_InventarioID",
                table: "Entregas");

            migrationBuilder.DropIndex(
                name: "IX_Entregas_SolicitudID",
                table: "Entregas");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_NumeroSangre",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "CantidadInicial",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "CodigoBolsa",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "EmpleadoID",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "FechaDonacion",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "EmpleadosEntityID",
                table: "Entregas");

            migrationBuilder.RenameColumn(
                name: "FechaVencimiento",
                table: "Inventario",
                newName: "fechaVencimiento");

            migrationBuilder.RenameColumn(
                name: "CantidadDisponible",
                table: "Inventario",
                newName: "cantidadDisponible");

            migrationBuilder.RenameColumn(
                name: "ProcesamientoID",
                table: "Inventario",
                newName: "DonacionesID");

            migrationBuilder.RenameColumn(
                name: "TipoDeSangre",
                table: "Entregas",
                newName: "tipoDeSangre");

            migrationBuilder.RenameColumn(
                name: "FechaEntrega",
                table: "Entregas",
                newName: "Fechaentrega");

            migrationBuilder.RenameColumn(
                name: "CantidadEntregada",
                table: "Entregas",
                newName: "cantidadEntregada");

            migrationBuilder.RenameColumn(
                name: "InventarioID",
                table: "Entregas",
                newName: "DonanteID");

            migrationBuilder.AlterColumn<string>(
                name: "tipoDeSangresolicitada",
                table: "Solicitudes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "prioridad",
                table: "Solicitudes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "exequatur",
                table: "Solicitudes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "estadoSolicitud",
                table: "Solicitudes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "cantidad",
                table: "Solicitudes",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "VolumenDN",
                table: "Procesamientos",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "tipoDeSangre",
                table: "Entregas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<double>(
                name: "cantidadEntregada",
                table: "Entregas",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CantidadSangre",
                table: "Donaciones",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "InventarioID",
                table: "Donaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EntregaEntitySolicitudEntity",
                columns: table => new
                {
                    EntregasID = table.Column<int>(type: "int", nullable: false),
                    SolicitudesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntregaEntitySolicitudEntity", x => new { x.EntregasID, x.SolicitudesID });
                    table.ForeignKey(
                        name: "FK_EntregaEntitySolicitudEntity_Entregas_EntregasID",
                        column: x => x.EntregasID,
                        principalTable: "Entregas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntregaEntitySolicitudEntity_Solicitudes_SolicitudesID",
                        column: x => x.SolicitudesID,
                        principalTable: "Solicitudes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_InventarioID",
                table: "Donaciones",
                column: "InventarioID");

            migrationBuilder.CreateIndex(
                name: "IX_EntregaEntitySolicitudEntity_SolicitudesID",
                table: "EntregaEntitySolicitudEntity",
                column: "SolicitudesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones",
                column: "DonanteID",
                principalTable: "Donantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Inventario_InventarioID",
                table: "Donaciones",
                column: "InventarioID",
                principalTable: "Inventario",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donantes_Empleados_EmpleadosID",
                table: "Donantes",
                column: "EmpleadosID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Empleados_EmpleadoID",
                table: "Entregas",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Procesamientos_Donaciones_DonacionesID",
                table: "Procesamientos",
                column: "DonacionesID",
                principalTable: "Donaciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoID",
                table: "Usuarios",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
