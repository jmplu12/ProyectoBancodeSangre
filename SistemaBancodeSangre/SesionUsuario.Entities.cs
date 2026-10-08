using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class SesionUsuario
    {
        public static int UsuarioID { get; set; }

        public static int EmpleadoID { get; set; }

        public static string NombreCompleto { get; set; }

        public static string Cargo { get; set; }

        public static void Iniciar(
            int usuarioId,
            int empleadoId,
            string nombre,
            string apellido,
            string cargo)
        {
            UsuarioID = usuarioId;
            EmpleadoID = empleadoId;
            NombreCompleto = $"{nombre} {apellido}";
            Cargo = cargo;
        }

        public static void CerrarSesion()
        {
            UsuarioID = 0;
            EmpleadoID = 0;
            NombreCompleto = "";
            Cargo = "";
        }
    }
}
