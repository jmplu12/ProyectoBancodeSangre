using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class EntregaBLL
    {
        #region Guardar

        public static void Guardar(EntregaEntity entity)
        {
            if (entity == null)
            {
                throw new Exception(
                    "La entrega no puede ser nula.");
            }

            if (entity.SolicitudID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una solicitud.");
            }

            if (entity.InventarioID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una unidad de sangre.");
            }

            if (entity.CantidadEntregada <= 0)
            {
                throw new Exception(
                    "La cantidad entregada debe ser mayor que cero.");
            }

            if (entity.EmpleadoID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar el empleado responsable.");
            }

            if (entity.FechaEntrega == DateTime.MinValue)
            {
                entity.FechaEntrega = DateTime.Now;
            }

            EntregaDAL.Crear(entity);
        }

        #endregion


        #region Eliminar

        public static void Borrar(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "El ID de la entrega no es válido.");
            }

            EntregaDAL.Eliminar(id);
        }

        #endregion


        #region Obtener por ID

        public static EntregaEntity ObtenerPorID(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "El ID de la entrega no es válido.");
            }

            return EntregaDAL.ObtenerPorId(id);
        }

        #endregion


        #region Obtener todas

        public static IEnumerable<EntregaEntity> ObtenerTodas()
        {
            return EntregaDAL.ObtenerTodas();
        }

        #endregion


        #region Buscar

        public static IEnumerable<EntregaEntity> Buscar(string texto)
        {
            return EntregaDAL.Buscar(texto);
        }

        #endregion
    }
}