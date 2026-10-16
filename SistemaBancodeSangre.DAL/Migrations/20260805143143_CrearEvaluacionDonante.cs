using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancodeSangre.DAL.Migrations
{
    public partial class CrearEvaluacionDonante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones");

            migrationBuilder.AddColumn<int>(
                name: "EvaluacionDonanteID",
                table: "Donaciones",
                type: "int",
                nullable: true);

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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluacionesDonantes_Empleados_EmpleadoID",
                        column: x => x.EmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_EvaluacionDonanteID",
                table: "Donaciones",
                column: "EvaluacionDonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDonantes_DonanteID",
                table: "EvaluacionesDonantes",
                column: "DonanteID");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluacionesDonantes_EmpleadoID",
                table: "EvaluacionesDonantes",
                column: "EmpleadoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones",
                column: "DonanteID",
                principalTable: "Donantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_EvaluacionesDonantes_EvaluacionDonanteID",
                table: "Donaciones",
                column: "EvaluacionDonanteID",
                principalTable: "EvaluacionesDonantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_EvaluacionesDonantes_EvaluacionDonanteID",
                table: "Donaciones");

            migrationBuilder.DropTable(
                name: "EvaluacionesDonantes");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_EvaluacionDonanteID",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "EvaluacionDonanteID",
                table: "Donaciones");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Donantes_DonanteID",
                table: "Donaciones",
                column: "DonanteID",
                principalTable: "Donantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
