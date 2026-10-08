using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class EntregaDAL
    {
        #region Crear entrega

        public static void Crear(EntregaEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var inventario = dbContext.Inventario
                    .FirstOrDefault(i => i.ID == entity.InventarioID);

                if (inventario == null)
                {
                    throw new Exception("El inventario seleccionado no existe.");
                }

                if (inventario.Estado != "Disponible")
                {
                    throw new Exception(
                        "La sangre seleccionada no está disponible para entrega.");
                }

                if (inventario.FechaVencimiento.Date < DateTime.Today)
                {
                    throw new Exception(
                        "No se puede entregar sangre vencida.");
                }

                if (entity.CantidadEntregada <= 0)
                {
                    throw new Exception(
                        "La cantidad entregada debe ser mayor que cero.");
                }

                if (entity.CantidadEntregada > inventario.CantidadDisponible)
                {
                    throw new Exception(
                        "La cantidad solicitada supera la cantidad disponible.");
                }

                // Descontamos la cantidad del inventario
                inventario.CantidadDisponible -= entity.CantidadEntregada;

                // Si ya no queda sangre
                if (inventario.CantidadDisponible == 0)
                {
                    inventario.Estado = "Utilizada";
                }

                // Guardamos la entrega
                dbContext.Entregas.Add(entity);

                dbContext.SaveChanges();
            }
        }

        #endregion
        #region Eliminar

        public static void Eliminar(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var entregaEncontrada =
                    dbContext.Entregas
                    .FirstOrDefault(e => e.ID == id);

                if (entregaEncontrada == null)
                {
                    throw new Exception(
                        "La entrega que desea eliminar no existe.");
                }

                dbContext.Entregas.Remove(entregaEncontrada);

                dbContext.SaveChanges();
            }
        }

        #endregion

        #region Obtener por ID

        public static EntregaEntity ObtenerPorId(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Entregas
                    .FirstOrDefault(e => e.ID == id);
            }
        }

        #endregion


        #region Obtener todas

        public static IEnumerable<EntregaEntity> ObtenerTodas()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Entregas
                    .OrderByDescending(e => e.ID)
                    .ToList();
            }
        }

        #endregion


        #region Buscar

        public static IEnumerable<EntregaEntity> Buscar(string texto)
        {
            using (var dbContext = new AppDbContext())
            {
                texto = texto ?? "";

                return dbContext.Entregas
                    .Where(e =>
                        e.TipoDeSangre.Contains(texto))
                    .OrderByDescending(e => e.ID)
                    .ToList();
            }
        }

        #endregion
    }
}
