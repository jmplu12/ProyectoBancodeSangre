using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class UsuariosBLL
    {
        public static void Guardar(UsuariosEntity entity)
        {
            entity = UsuariosDAL.Crear(entity);

            UsuarioPermisosBLL.CrearPermisosUsuario(entity.ID);
        }

        public static void Borrar(int id)
        {
            UsuariosDAL.Delete(id);
        }

        public static UsuariosEntity ObtenerID(int id)
        {
            return UsuariosDAL.GetById(id);
        }

        public static IEnumerable<UsuariosEntity> ObtenerNombre(string nombre)
        {
            return UsuariosDAL.GetByNombre(nombre);
        }

        public static IEnumerable<UsuariosEntity> ObtenerTodas()
        {
            return UsuariosDAL.GetAll();
        }
    }
}
