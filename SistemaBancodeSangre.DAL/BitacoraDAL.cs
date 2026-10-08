using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class BitacoraDAL
    {
        public static void Insertar(BitacoraEntity entity)
        {
            using (var context = new AppDbContext())
            {
                entity.Fecha = DateTime.Now;

                context.Bitacora.Add(entity);
                context.SaveChanges();
            }
        }

        public static List<BitacoraEntity> ObtenerTodas()
        {
            using (var context = new AppDbContext())
            {
                return context.Bitacora
                              .OrderByDescending(b => b.Fecha)
                              .ToList();
            }
        }

        public static List<BitacoraEntity> ObtenerPorUsuario(int usuarioId)
        {
            using (var context = new AppDbContext())
            {
                return context.Bitacora
                              .Where(b => b.UsuarioID == usuarioId)
                              .OrderByDescending(b => b.Fecha)
                              .ToList();
            }
        }

        public static List<BitacoraEntity> ObtenerPorFecha(DateTime desde, DateTime hasta)
        {
            using (var context = new AppDbContext())
            {
                return context.Bitacora
                              .Where(b => b.Fecha >= desde &&
                                          b.Fecha <= hasta)
                              .OrderByDescending(b => b.Fecha)
                              .ToList();
            }
        }
    }
}
