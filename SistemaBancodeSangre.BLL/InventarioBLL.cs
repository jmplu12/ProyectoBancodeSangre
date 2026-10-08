using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{

    public class InventarioBLL
    {
        #region Determinar estado

        private static string DeterminarEstado(InventarioEntity entity)
        {
            // ==========================================
            // VENCIMIENTO
            // ==========================================

            if (entity.FechaVencimiento.Date < DateTime.Today)
            {
                return "Vencida";
            }


            // ==========================================
            // AGOTADA
            // ==========================================

            if (entity.CantidadDisponible <= 0)
            {
                return "Agotada";
            }


            // ==========================================
            // AGOTÁNDOSE
            // ==========================================
            // Se considera agotándose cuando queda
            // 20% o menos de la cantidad inicial.

            double porcentajeDisponible =
                ((double)entity.CantidadDisponible /
                entity.CantidadInicial) * 100;

            if (porcentajeDisponible <= 20)
            {
                return "Agotándose";
            }


            // ==========================================
            // DISPONIBLE
            // ==========================================

            return "Disponible";
        }

        #endregion


        #region Guardar

        public static void Guardar(InventarioEntity entity)
        {
            if (entity == null)
            {
                throw new Exception(
                    "El registro de inventario no puede ser nulo.");
            }


            // ==========================================
            // CÓDIGO DE BOLSA
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.CodigoBolsa))
            {
                throw new Exception(
                    "El código de bolsa es obligatorio.");
            }

            entity.CodigoBolsa =
                entity.CodigoBolsa.Trim();


            // ==========================================
            // TIPO DE SANGRE
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.TipoSangre))
            {
                throw new Exception(
                    "El tipo de sangre es obligatorio.");
            }

            entity.TipoSangre =
                entity.TipoSangre.Trim();


            // ==========================================
            // CANTIDAD INICIAL
            // ==========================================

            if (entity.CantidadInicial <= 0)
            {
                throw new Exception(
                    "La cantidad inicial debe ser mayor que cero.");
            }


            // ==========================================
            // CANTIDAD DISPONIBLE
            // ==========================================

            if (entity.CantidadDisponible < 0)
            {
                throw new Exception(
                    "La cantidad disponible no puede ser negativa.");
            }


            if (entity.CantidadDisponible >
                entity.CantidadInicial)
            {
                throw new Exception(
                    "La cantidad disponible no puede ser mayor que la cantidad inicial.");
            }


            // ==========================================
            // FECHA DE DONACIÓN
            // ==========================================

            if (entity.FechaDonacion.Date >
                DateTime.Today)
            {
                throw new Exception(
                    "La fecha de donación no puede ser futura.");
            }


            // ==========================================
            // FECHA DE VENCIMIENTO
            // ==========================================

            if (entity.FechaVencimiento.Date <=
                entity.FechaDonacion.Date)
            {
                throw new Exception(
                    "La fecha de vencimiento debe ser posterior a la fecha de donación.");
            }


            // ==========================================
            // PROCESAMIENTO
            // ==========================================

            if (entity.ProcesamientoID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un procesamiento.");
            }


            // ==========================================
            // EMPLEADO
            // ==========================================

            if (!entity.EmpleadoID.HasValue ||
                entity.EmpleadoID.Value <= 0)
            {
                throw new Exception(
                    "Debe seleccionar el empleado responsable.");
            }


            // ==========================================
            // CÓDIGO DE BOLSA DUPLICADO
            // ==========================================

            if (InventarioDAL.ExisteCodigoBolsa(
                entity.CodigoBolsa,
                entity.ID))
            {
                throw new Exception(
                    "Ya existe un inventario con ese código de bolsa.");
            }


            // ==========================================
            // PROCESAMIENTO DUPLICADO
            // ==========================================

            if (InventarioDAL.ExisteProcesamiento(
                entity.ProcesamientoID,
                entity.ID))
            {
                throw new Exception(
                    "Este procesamiento ya se encuentra registrado en el inventario.");
            }


            // ==========================================
            // DETERMINAR ESTADO AUTOMÁTICAMENTE
            // ==========================================

            /*
             * No permitimos que el formulario decida
             * si la bolsa está disponible o agotada.
             *
             * El sistema lo calcula según:
             *
             * CantidadDisponible
             * CantidadInicial
             * FechaVencimiento
             */

            string estadoAnterior = entity.Estado;

            // Estados que deben conservarse manualmente
            if (estadoAnterior == "Reservada" ||
                estadoAnterior == "Utilizada" ||
                estadoAnterior == "Descartada")
            {
                entity.Estado = estadoAnterior;
            }
            else
            {
                entity.Estado =
                    DeterminarEstado(entity);
            }


            // ==========================================
            // CREAR / ACTUALIZAR
            // ==========================================

            if (entity.ID == 0)
            {
                entity.FechaRegistro =
                    DateTime.Now;

                InventarioDAL.Crear(entity);
            }
            else
            {
                InventarioDAL.Actualizar(entity);
            }
        }

        #endregion


        #region Eliminar

        public static void Borrar(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "El ID del inventario no es válido.");
            }

            InventarioDAL.Eliminar(id);
        }

        #endregion


        #region Obtener por ID

        public static InventarioEntity ObtenerPorID(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "El ID del inventario no es válido.");
            }

            return InventarioDAL.ObtenerPorId(id);
        }

        #endregion


        #region Obtener todos

        public static IEnumerable<InventarioEntity>
            ObtenerTodas()
        {
            InventarioDAL.ActualizarVencidos();

            return InventarioDAL.ObtenerTodos();
        }

        #endregion


        #region Buscar

        public static IEnumerable<InventarioEntity>
            Buscar(string texto)
        {
            InventarioDAL.ActualizarVencidos();

            return InventarioDAL.Buscar(texto);
        }

        #endregion


        #region Inventario disponible

        public static IEnumerable<InventarioEntity>
            ObtenerDisponibles()
        {
            InventarioDAL.ActualizarVencidos();

            return InventarioDAL.ObtenerDisponibles();
        }

        #endregion
    }
}