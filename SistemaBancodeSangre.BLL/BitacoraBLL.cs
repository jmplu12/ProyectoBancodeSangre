using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class BitacoraBLL
    {
        public static void RegistrarAccion(
            string accion,
            string detalle = "",
            string entidad = "",
            int? entidadId = null)
        {
            BitacoraEntity bitacora = new BitacoraEntity
            {
                UsuarioID = SesionUsuario.UsuarioID,
                NombreUsuario = SesionUsuario.NombreCompleto,
                Cargo = SesionUsuario.Cargo,

                Accion = accion,
                Entidad = entidad,
                EntidadId = entidadId,
                Detalle = detalle,
                Fecha = DateTime.Now
            };

            BitacoraDAL.Insertar(bitacora);
        }

        public static List<BitacoraEntity> ObtenerTodas()
        {
            return BitacoraDAL.ObtenerTodas();
        }

        public static List<BitacoraEntity> ObtenerPorUsuario(int usuarioId)
        {
            return BitacoraDAL.ObtenerPorUsuario(usuarioId);
        }

        public static List<BitacoraEntity> ObtenerPorFecha(DateTime desde, DateTime hasta)
        {
            return BitacoraDAL.ObtenerPorFecha(desde, hasta);
        }
    }
}
