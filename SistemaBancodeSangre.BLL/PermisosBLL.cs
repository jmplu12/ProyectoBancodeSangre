using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
  public  class PermisosBLL
    {
     
            public static void Guardar(PermisosEntity entity)
            {
                PermisosDAL.Crear(entity);
            }

            public static void Eliminar(int id)
            {
                PermisosDAL.Eliminar(id);
            }

            public static PermisosEntity Obtener(int id)
            {
                return PermisosDAL.GetById(id);
            }

            public static IEnumerable<PermisosEntity> ObtenerTodos()
            {
                return PermisosDAL.GetAll();
            }
        }
}
