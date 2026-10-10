using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class BDPRUEBA1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bitacora",
                columns: table => new
                {
                    IdBitacora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Accion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Entidad = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EntidadId = table.Column<int>(type: "int", nullable: true),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora", x => x.IdBitacora);
                });

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
                name: "Permisos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePermiso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    solicitante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    medico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaDeSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hospital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    exequatur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prioridad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    proposito = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    motivo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    tipoDeSangresolicitada = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    cartaMedica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoSolicitud = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                name: "EvaluacionesDonantes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonanteID = table.Column<int>(type: "int", nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false),
                    FechaEvaluacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    PresionArterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    TieneEnfermedad = table.Column<bool>(type: "bit", nullable: false),
                    TomaMedicamentos = table.Column<bool>(type: "bit", nullable: false),
                    TieneSintomas = table.Column<bool>(type: "bit", nullable: false),
                    HaTenidoCirugia = table.Column<bool>(type: "bit", nullable: false),
                    HaDonadoAnteriormente = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionesDonantes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EvaluacionesDonantes_Donantes_DonanteID",
                        column: x => x.DonanteID,
                        principalTable: "Donantes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluacionesDonantes_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPermisos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    PermisoID = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermisos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UsuarioPermisos_Permisos_PermisoID",
                        column: x => x.PermisoID,
                        principalTable: "Permisos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPermisos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDeSangre = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CantidadSangre = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: false),
                    Envase = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaDonacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proposito = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Analista = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumeroSangre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DonanteID = table.Column<int>(type: "int", nullable: false),
                    EvaluacionDonanteID = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Donaciones_EvaluacionesDonantes_EvaluacionDonanteID",
                        column: x => x.EvaluacionDonanteID,
                        principalTable: "EvaluacionesDonantes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Muestras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDonante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoDonante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoSangre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaToma = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDonacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadM = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Responsable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CodigoMuestra = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DonacionesID = table.Column<int>(type: "int", nullable: false),
                    DonanteID = table.Column<int>(type: "int", nullable: true),
                    DonantesEntityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muestras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Muestras_Donaciones_DonacionesID",
                        column: x => x.DonacionesID,
                        principalTable: "Donaciones",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Muestras_Donantes_DonanteID",
                        column: x => x.DonanteID,
                        principalTable: "Donantes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Muestras_Donantes_DonantesEntityID",
                        column: x => x.DonantesEntityID,
                        principalTable: "Donantes",
                        principalColumn: "ID");
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

            migrationBuilder.CreateTable(
                name: "Procesamientos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoProceso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaProceso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoDeSangre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VolumenDN = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false),
                    Almacenado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NumeroSangre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConcentradoGlobulosRojos = table.Column<bool>(type: "bit", nullable: false),
                    Plasma = table.Column<bool>(type: "bit", nullable: false),
                    Plaquetas = table.Column<bool>(type: "bit", nullable: false),
                    DonacionesID = table.Column<int>(type: "int", nullable: false),
                    MuestraID = table.Column<int>(type: "int", nullable: true),
                    AnalisisID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesamientos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Procesamientos_Analisis_AnalisisID",
                        column: x => x.AnalisisID,
                        principalTable: "Analisis",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Procesamientos_Donaciones_DonacionesID",
                        column: x => x.DonacionesID,
                        principalTable: "Donaciones",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procesamientos_Muestras_MuestraID",
                        column: x => x.MuestraID,
                        principalTable: "Muestras",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoBolsa = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TipoSangre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadInicial = table.Column<int>(type: "int", nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    FechaDonacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcesamientoID = table.Column<int>(type: "int", nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inventario_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventario_Procesamientos_ProcesamientoID",
                        column: x => x.ProcesamientoID,
                        principalTable: "Procesamientos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entregas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudID = table.Column<int>(type: "int", nullable: false),
                    InventarioID = table.Column<int>(type: "int", nullable: false),
                    CantidadEntregada = table.Column<int>(type: "int", nullable: false),
                    TipoDeSangre = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoID = table.Column<int>(type: "int", nullable: false),
                    EmpleadosEntityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entregas_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entregas_Empleados_EmpleadosEntityID",
                        column: x => x.EmpleadosEntityID,
                        principalTable: "Empleados",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Entregas_Inventario_InventarioID",
                        column: x => x.InventarioID,
                        principalTable: "Inventario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entregas_Solicitudes_SolicitudID",
                        column: x => x.SolicitudID,
                        principalTable: "Solicitudes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Donaciones_EvaluacionDonanteID",
                table: "Donaciones",
                column: "EvaluacionDonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_NumeroSangre",
                table: "Donaciones",
                column: "NumeroSangre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donantes_EmpleadosID",
                table: "Donantes",
                column: "EmpleadosID");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_EmpleadoID",
                table: "Entregas",
                column: "EmpleadoID");

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
                name: "IX_EvaluacionesDonantes_DonanteID",
                table: "EvaluacionesDonantes",
                column: "DonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDonantes_EmpleadoID",
                table: "EvaluacionesDonantes",
                column: "EmpleadoID");

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
                name: "IX_Muestras_DonacionesID",
                table: "Muestras",
                column: "DonacionesID");

            migrationBuilder.CreateIndex(
                name: "IX_Muestras_DonanteID",
                table: "Muestras",
                column: "DonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_Muestras_DonantesEntityID",
                table: "Muestras",
                column: "DonantesEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Procesamientos_AnalisisID",
                table: "Procesamientos",
                column: "AnalisisID");

            migrationBuilder.CreateIndex(
                name: "IX_Procesamientos_DonacionesID",
                table: "Procesamientos",
                column: "DonacionesID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Procesamientos_MuestraID",
                table: "Procesamientos",
                column: "MuestraID");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermisos_PermisoID",
                table: "UsuarioPermisos",
                column: "PermisoID");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermisos_UsuarioID",
                table: "UsuarioPermisos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpleadoID",
                table: "Usuarios",
                column: "EmpleadoID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bitacora");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Entregas");

            migrationBuilder.DropTable(
                name: "UsuarioPermisos");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Procesamientos");

            migrationBuilder.DropTable(
                name: "Analisis");

            migrationBuilder.DropTable(
                name: "Muestras");

            migrationBuilder.DropTable(
                name: "Donaciones");

            migrationBuilder.DropTable(
                name: "EvaluacionesDonantes");

            migrationBuilder.DropTable(
                name: "Donantes");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
