using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{

    public class MuestraBLL
    {
        #region Métodos de Guardar y Actualizar

        public static void Guardar(MuestraEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(
                    nameof(entity),
                    "La muestra no puede ser nula.");

            // Validar Donante
            if (entity.DonacionesID <= 0)
                throw new ArgumentException(
                    "Debe seleccionar una donacion válido.");

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(entity.NombreDonante))
                throw new ArgumentException(
                    "El nombre del donante es obligatorio.");

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(entity.ApellidoDonante))
                throw new ArgumentException(
                    "El apellido del donante es obligatorio.");

            // Validar Tipo de Sangre
            if (string.IsNullOrWhiteSpace(entity.TipoSangre))
                throw new ArgumentException(
                    "El tipo de sangre es obligatorio.");

            // Validar Código de Muestra
            if (string.IsNullOrWhiteSpace(entity.CodigoMuestra))
                throw new ArgumentException(
                    "El código de muestra es obligatorio.");

            // Validar Fecha de Toma
            if (entity.FechaToma == default(DateTime))
                throw new ArgumentException(
                    "La fecha de toma es obligatoria.");

            // Validar Relación entre Fechas
            if (entity.FechaToma < entity.FechaDonacion)
                throw new ArgumentException(
                    "La fecha de toma no puede ser anterior a la fecha de donación.");

            // Validar Estado
            if (string.IsNullOrWhiteSpace(entity.Estado))
                throw new ArgumentException(
                    "Debe seleccionar un estado para la muestra.");

            // Validaciones de Cantidad
            if (entity.CantidadM <= 0)
                throw new ArgumentException(
                    "La cantidad de muestra debe ser mayor a cero.");

            if (entity.CantidadM > 100)
                throw new ArgumentException(
                    "La cantidad de muestra no puede ser mayor de 100 ml.");

            // Crear o Actualizar según el ID
            if (entity.ID == 0)
            {
                MuestraDAL.Crear(entity);
            }
            else
            {
                MuestraDAL.Update(entity);
            }
        }

        #endregion

        #region Método Eliminar

        public static void Borrar(int id)
        {
            if (id <= 0)
                throw new ArgumentException(
                    "El ID de la muestra no es válido.");

            MuestraDAL.Delete(id);
        }

        #endregion

        #region Métodos de Lectura

        public static MuestraEntity ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException(
                    "El ID de la muestra no es válido.");

            return MuestraDAL.GetById(id);
        }

        public static IEnumerable<MuestraEntity> ObtenerPorTipoSangre(string tipoSangre)
        {
            return MuestraDAL.GetByTipoSangre(tipoSangre);
        }

        public static IEnumerable<MuestraEntity> Buscar(string criterio)
        {
            return MuestraDAL.GetByFiltro(criterio);
        }

        public static IEnumerable<MuestraEntity> ObtenerTodas()
        {
            return MuestraDAL.GetAll();
        }

        #endregion
    }
}



