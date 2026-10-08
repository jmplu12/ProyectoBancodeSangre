using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
  public class UsuarioPermisosDAL
    {
        public static void Guardar(UsuarioPermisosEntity entity)
        {
            using (var context = new AppDbContext())
            {
                if (entity.ID == 0)
                    context.UsuarioPermisos.Add(entity);
                else
                    context.UsuarioPermisos.Update(entity);

                context.SaveChanges();
            }
        }

        public static void Eliminar(int id)
        {
            using (var context = new AppDbContext())
            {
                var permiso = context.UsuarioPermisos.FirstOrDefault(x => x.ID == id);

                if (permiso != null)
                {
                    context.UsuarioPermisos.Remove(permiso);
                    context.SaveChanges();
                }
            }
        }

        public static IEnumerable<UsuarioPermisosEntity> ObtenerPorUsuario(int usuarioID)
        {
            using (var context = new AppDbContext())
            {
                return context.UsuarioPermisos
                    .Include(x => x.Permiso)
                    .Where(x => x.UsuarioID == usuarioID)
                    .ToList();
            }
        }

        public static UsuarioPermisosEntity Obtener(int usuarioID, int permisoID)
        {
            using (var context = new AppDbContext())
            {
                return context.UsuarioPermisos.FirstOrDefault(x =>
                    x.UsuarioID == usuarioID &&
                    x.PermisoID == permisoID);
            }
        }

        public static bool TienePermiso(int usuarioId, string permiso)
        {
            using (var context = new AppDbContext())
            {
                return context.UsuarioPermisos
                    .Include(x => x.Permiso)
                    .Any(x =>
                        x.UsuarioID == usuarioId &&
                        x.Activo &&
                        x.Permiso.NombrePermiso == permiso);
            }
        }

        public static void CrearPermisosUsuario(int usuarioID)
        {
            using (var context = new AppDbContext())
            {
                var permisos = context.Permisos.ToList();

                foreach (var permiso in permisos)
                {
                    bool existe = context.UsuarioPermisos.Any(x =>
                        x.UsuarioID == usuarioID &&
                        x.PermisoID == permiso.ID);

                    if (!existe)
                    {
                        context.UsuarioPermisos.Add(new UsuarioPermisosEntity
                        {
                            UsuarioID = usuarioID,
                            PermisoID = permiso.ID,
                            Activo = false
                        });
                    }
                }

                context.SaveChanges();
            }
        }
    }
}
