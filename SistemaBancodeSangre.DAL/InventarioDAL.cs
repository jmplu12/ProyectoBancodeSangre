using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaBancodeSangre.DAL
{
    public class InventarioDAL
    {
        #region Crear

        public static void Crear(InventarioEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Inventario.Add(entity);
                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Actualizar

        public static void Actualizar(InventarioEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var inventarioEncontrado =
                    dbContext.Inventario
                    .FirstOrDefault(i => i.ID == entity.ID);

                if (inventarioEncontrado == null)
                {
                    throw new Exception(
                        "El registro de inventario no existe.");
                }

                inventarioEncontrado.CodigoBolsa =
                    entity.CodigoBolsa;

                inventarioEncontrado.TipoSangre =
                    entity.TipoSangre;

                inventarioEncontrado.CantidadInicial =
                    entity.CantidadInicial;

                inventarioEncontrado.CantidadDisponible =
                    entity.CantidadDisponible;

                inventarioEncontrado.FechaDonacion =
                    entity.FechaDonacion;

                inventarioEncontrado.FechaVencimiento =
                    entity.FechaVencimiento;

                inventarioEncontrado.Estado =
                    entity.Estado;

                inventarioEncontrado.FechaRegistro =
                    entity.FechaRegistro;

                inventarioEncontrado.ProcesamientoID =
                    entity.ProcesamientoID;

                inventarioEncontrado.EmpleadoID =
                    entity.EmpleadoID;

                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Eliminar

        public static void Eliminar(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var inventarioEncontrado =
                    dbContext.Inventario
                    .FirstOrDefault(i => i.ID == id);

                if (inventarioEncontrado == null)
                {
                    throw new Exception(
                        "El registro de inventario no existe.");
                }

                dbContext.Inventario.Remove(
                    inventarioEncontrado);

                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Obtener por ID

        public static InventarioEntity ObtenerPorId(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Inventario
                    .FirstOrDefault(i => i.ID == id);
            }
        }

        #endregion


        #region Obtener todos

        public static IEnumerable<InventarioEntity>
            ObtenerTodos()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Inventario
                    .OrderByDescending(i => i.ID)
                    .ToList();
            }
        }

        #endregion


        #region Buscar

        public static IEnumerable<InventarioEntity>
            Buscar(string texto)
        {
            using (var dbContext = new AppDbContext())
            {
                texto = texto ?? "";

                texto = texto.Trim();

                return dbContext.Inventario
                    .Where(i =>
                        i.CodigoBolsa.Contains(texto) ||
                        i.TipoSangre.Contains(texto) ||
                        i.Estado.Contains(texto))
                    .OrderByDescending(i => i.ID)
                    .ToList();
            }
        }

        #endregion


        #region Buscar disponibles

        public static IEnumerable<InventarioEntity>
            ObtenerDisponibles()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Inventario
                    .Where(i =>
                        i.CantidadDisponible > 0 &&
                        i.FechaVencimiento >= DateTime.Today &&
                        (
                            i.Estado == "Disponible" ||
                            i.Estado == "Agotándose"
                        ))
                    .OrderBy(i => i.FechaVencimiento)
                    .ToList();
            }
        }

        #endregion


        #region Verificar código de bolsa

        public static bool ExisteCodigoBolsa(
            string codigoBolsa,
            int id = 0)
        {
            using (var dbContext = new AppDbContext())
            {
                codigoBolsa = codigoBolsa ?? "";

                codigoBolsa = codigoBolsa.Trim();

                return dbContext.Inventario.Any(i =>
                    i.CodigoBolsa == codigoBolsa &&
                    i.ID != id);
            }
        }

        #endregion


        #region Actualizar estados del inventario

        public static void ActualizarEstados()
        {
            using (var dbContext = new AppDbContext())
            {
                var registros =
                    dbContext.Inventario.ToList();

                foreach (var item in registros)
                {
                    // ==========================================
                    // VENCIDA
                    // ==========================================

                    if (item.FechaVencimiento.Date <
                        DateTime.Today)
                    {
                        item.Estado = "Vencida";

                        continue;
                    }


                    // ==========================================
                    // AGOTADA
                    // ==========================================

                    if (item.CantidadDisponible <= 0)
                    {
                        item.Estado = "Agotada";

                        continue;
                    }


                    // ==========================================
                    // NO MODIFICAR ESTADOS ESPECIALES
                    // ==========================================

                    if (item.Estado == "Reservada" ||
                        item.Estado == "Utilizada" ||
                        item.Estado == "Descartada")
                    {
                        continue;
                    }


                    // ==========================================
                    // PORCENTAJE DISPONIBLE
                    // ==========================================

                    double porcentajeDisponible =
                        ((double)item.CantidadDisponible /
                        item.CantidadInicial) * 100;


                    // ==========================================
                    // AGOTÁNDOSE
                    // ==========================================

                    if (porcentajeDisponible <= 20)
                    {
                        item.Estado = "Agotándose";
                    }
                    else
                    {
                        // ======================================
                        // DISPONIBLE
                        // ======================================

                        item.Estado = "Disponible";
                    }
                }

                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Actualizar estados vencidos

        public static void ActualizarVencidos()
        {
            using (var dbContext = new AppDbContext())
            {
                var registros =
                    dbContext.Inventario
                    .Where(i =>
                        i.FechaVencimiento.Date <
                        DateTime.Today &&
                        i.Estado != "Utilizada" &&
                        i.Estado != "Descartada")
                    .ToList();

                foreach (var item in registros)
                {
                    item.Estado = "Vencida";
                }

                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Verificar procesamiento

        public static bool ExisteProcesamiento(
            int procesamientoID,
            int id = 0)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Inventario.Any(i =>
                    i.ProcesamientoID == procesamientoID &&
                    i.ID != id);
            }
        }

        #endregion
    }
}
