using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class UsuarioPermisosBLL
    {
        public static void Guardar(UsuarioPermisosEntity entity)
        {
            UsuarioPermisosDAL.Guardar(entity);
        }

        public static void Eliminar(int id)
        {
            UsuarioPermisosDAL.Eliminar(id);
        }

        public static IEnumerable<UsuarioPermisosEntity> ObtenerPermisosUsuario(int usuarioID)
        {
            return UsuarioPermisosDAL.ObtenerPorUsuario(usuarioID);
        }

        public static UsuarioPermisosEntity Obtener(int usuarioID, int permisoID)
        {
            return UsuarioPermisosDAL.Obtener(usuarioID, permisoID);
        }

        public static bool TienePermiso(int usuarioId, string permiso)
        {
            return UsuarioPermisosDAL.TienePermiso(usuarioId, permiso);
        }

        public static void CrearPermisosUsuario(int usuarioID)
        {
            UsuarioPermisosDAL.CrearPermisosUsuario(usuarioID);
        }
    }
}
