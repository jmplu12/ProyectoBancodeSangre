using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class UsuariosDAL
    {

        public static UsuariosEntity Crear(UsuariosEntity entity)
        {
            using (var context = new AppDbContext())
            {
                context.Usuarios.Add(entity);

                context.SaveChanges();

                return entity;
            }
        }

        public static void Update(UsuariosEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var usuarioEncontrado = dbContext.Usuarios.FirstOrDefault(u => u.ID == entity.ID);

                if (usuarioEncontrado != null)
                {
                    usuarioEncontrado.nombreUsuario = entity.nombreUsuario;
                    usuarioEncontrado.clave = entity.clave;
                    usuarioEncontrado.Cargo = entity.Cargo;
                    usuarioEncontrado.EmpleadoID = entity.EmpleadoID;
                    usuarioEncontrado.Nombre = entity.Nombre;
                    usuarioEncontrado.Apellido = entity.Apellido;
                    usuarioEncontrado.correo = entity.correo;
                    usuarioEncontrado.telefono = entity.telefono;
                    usuarioEncontrado.IntentosFallidos = entity.IntentosFallidos;
                    usuarioEncontrado.Bloqueado = entity.Bloqueado;

                    dbContext.SaveChanges();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var usuarioEncontrado = dbContext.Usuarios.FirstOrDefault(x => x.ID == id);

                if (usuarioEncontrado != null)
                {
                    dbContext.Usuarios.Remove(usuarioEncontrado);
                    dbContext.SaveChanges();
                }
            }
        }

        public static UsuariosEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Usuarios.FirstOrDefault(x => x.ID == id);
            }
        }

        public static IEnumerable<UsuariosEntity> GetByNombre(string nombre)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Usuarios
                    .Where(x => x.nombreUsuario.Contains(nombre))
                    .ToList();
            }
        }

        public static IEnumerable<UsuariosEntity> GetAll()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Usuarios.ToList();
            }
        }

    }
}
