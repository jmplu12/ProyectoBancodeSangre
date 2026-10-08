using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class PermisosDAL
    {
        public static void Crear(PermisosEntity entity)
        {
            using (var context = new AppDbContext())
            {
                if (entity.ID == 0)
                    context.Permisos.Add(entity);
                else
                    context.Permisos.Update(entity);

                context.SaveChanges();
            }
        }

        public static void Actualizar(PermisosEntity entity)
        {
            using (var context = new AppDbContext())
            {
                var permiso = context.Permisos.FirstOrDefault(x => x.ID == entity.ID);

                if (permiso != null)
                {
                    permiso.NombrePermiso = entity.NombrePermiso;

                    context.SaveChanges();
                }
            }
        }

        public static void Eliminar(int id)
        {
            using (var context = new AppDbContext())
            {
                var permiso = context.Permisos.FirstOrDefault(x => x.ID == id);

                if (permiso != null)
                {
                    context.Permisos.Remove(permiso);
                    context.SaveChanges();
                }
            }
        }

        public static PermisosEntity GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Permisos.FirstOrDefault(x => x.ID == id);
            }
        }

        public static IEnumerable<PermisosEntity> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Permisos.ToList();
            }
        }
    }
}
