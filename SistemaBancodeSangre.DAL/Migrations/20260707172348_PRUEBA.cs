using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class PRUEBA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    provincia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    dirreccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    fechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoSangre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonacionesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    solicitante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cantidad = table.Column<double>(type: "float", nullable: false),
                    medico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaDeSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hospital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    exequatur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prioridad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proposito = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    motivo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    tipoDeSangresolicitada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cartaMedica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoSolicitud = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Donantes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Edad = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PesoKlg = table.Column<double>(type: "float", nullable: false),
                    TipoDeSangre = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    TipodeDonante = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    EmpleadosID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donantes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Donantes_Empleados_EmpleadosID",
                        column: x => x.EmpleadosID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entregas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudID = table.Column<int>(type: "int", nullable: false),
                    DonanteID = table.Column<int>(type: "int", nullable: false),
                    cantidadEntregada = table.Column<double>(type: "float", nullable: false),
                    tipoDeSangre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechaentrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entregas_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clave = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false),
                    IntentosFallidos = table.Column<int>(type: "int", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDonante = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fechaCita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DonantesID = table.Column<int>(type: "int", nullable: false),
                    DonantesEntityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Citas_Donantes_DonantesEntityID",
                        column: x => x.DonantesEntityID,
                        principalTable: "Donantes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Donaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipoDeSangre = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    cantidadSangre = table.Column<double>(type: "float", nullable: false),
                    envase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDonacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    proposito = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    analista = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DonanteID = table.Column<int>(type: "int", nullable: false),
                    InventarioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Donaciones_Donantes_DonanteID",
                        column: x => x.DonanteID,
                        principalTable: "Donantes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donaciones_Inventario_InventarioID",
                        column: x => x.InventarioID,
                        principalTable: "Inventario",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Muestras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDonante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoDoante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoSangre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    presionAlterial = table.Column<double>(type: "float", nullable: false),
                    pulso = table.Column<double>(type: "float", nullable: false),
                    temperatura = table.Column<double>(type: "float", nullable: false),
                    fechaToma = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidadM = table.Column<double>(type: "float", nullable: false),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoMuestra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonanteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muestras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Muestras_Donantes_DonanteID",
                        column: x => x.DonanteID,
                        principalTable: "Donantes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Procesamientos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadoProceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaProceso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipodeSangre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    volumenDN = table.Column<double>(type: "float", nullable: false),
                    Almacenado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DonacionesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesamientos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Procesamientos_Donaciones_DonacionesID",
                        column: x => x.DonacionesID,
                        principalTable: "Donaciones",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Analisis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vhsida = table.Column<bool>(type: "bit", nullable: false),
                    Diabetes = table.Column<bool>(type: "bit", nullable: false),
                    hepatitisBoC = table.Column<bool>(type: "bit", nullable: false),
                    HipertensionAlterial = table.Column<bool>(type: "bit", nullable: false),
                    insuficienciaCardiaca = table.Column<bool>(type: "bit", nullable: false),
                    Cancer = table.Column<bool>(type: "bit", nullable: false),
                    Arritmias = table.Column<bool>(type: "bit", nullable: false),
                    Hemofilia = table.Column<bool>(type: "bit", nullable: false),
                    chagas = table.Column<bool>(type: "bit", nullable: false),
                    fechaAnalisis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipodesangre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    analista = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MuestraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analisis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Analisis_Muestras_MuestraID",
                        column: x => x.MuestraID,
                        principalTable: "Muestras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analisis_MuestraID",
                table: "Analisis",
                column: "MuestraID");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_DonantesEntityID",
                table: "Citas",
                column: "DonantesEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_DonanteID",
                table: "Donaciones",
                column: "DonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_InventarioID",
                table: "Donaciones",
                column: "InventarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Donantes_EmpleadosID",
                table: "Donantes",
                column: "EmpleadosID");

            migrationBuilder.CreateIndex(
                name: "IX_EntregaEntitySolicitudEntity_SolicitudesID",
                table: "EntregaEntitySolicitudEntity",
                column: "SolicitudesID");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_EmpleadoID",
                table: "Entregas",
                column: "EmpleadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Muestras_DonanteID",
                table: "Muestras",
                column: "DonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_Procesamientos_DonacionesID",
                table: "Procesamientos",
                column: "DonacionesID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpleadoID",
                table: "Usuarios",
                column: "EmpleadoID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analisis");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "EntregaEntitySolicitudEntity");

            migrationBuilder.DropTable(
                name: "Procesamientos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Muestras");

            migrationBuilder.DropTable(
                name: "Entregas");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Donaciones");

            migrationBuilder.DropTable(
                name: "Donantes");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
