using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class EvaluacionDonanteBLL
    {
        #region Guardar

        public static void Guardar(
            EvaluacionDonanteEntity entity)
        {
            if (entity == null)
            {
                throw new Exception(
                    "La evaluación del donante no puede ser nula.");
            }


            // ==========================================
            // DONANTE
            // ==========================================

            if (entity.DonanteID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar un donante.");
            }


            // ==========================================
            // EMPLEADO
            // ==========================================

            if (entity.EmpleadoID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar el empleado responsable.");
            }


            // ==========================================
            // FECHA
            // ==========================================

            if (entity.FechaEvaluacion.Date >
                DateTime.Today)
            {
                throw new Exception(
                    "La fecha de evaluación no puede ser futura.");
            }


            // ==========================================
            // PESO
            // ==========================================

            if (entity.Peso <= 0)
            {
                throw new Exception(
                    "El peso debe ser mayor que cero.");
            }


            // ==========================================
            // PRESIÓN ARTERIAL
            // ==========================================

            if (string.IsNullOrWhiteSpace(
                entity.PresionArterial))
            {
                throw new Exception(
                    "La presión arterial es obligatoria.");
            }


            // ==========================================
            // TEMPERATURA
            // ==========================================

            if (entity.Temperatura <= 0)
            {
                throw new Exception(
                    "La temperatura debe ser mayor que cero.");
            }


            // ==========================================
            // RESULTADO
            // ==========================================

            if (string.IsNullOrWhiteSpace(
                entity.Resultado))
            {
                throw new Exception(
                    "Debe indicar el resultado de la evaluación.");
            }


            if (entity.Resultado != "APTO" &&
                entity.Resultado != "NO APTO" &&
                entity.Resultado != "PENDIENTE")
            {
                throw new Exception(
                    "El resultado de la evaluación no es válido.");
            }


            // ==========================================
            // ESTADO
            // ==========================================

            if (string.IsNullOrWhiteSpace(
                entity.Estado))
            {
                entity.Estado = "Finalizada";
            }


            // ==========================================
            // GUARDAR
            // ==========================================

            if (entity.ID == 0)
            {
                EvaluacionDonanteDAL.Crear(entity);
            }
            else
            {
                EvaluacionDonanteDAL.Actualizar(entity);
            }
        }

        #endregion


        #region Eliminar

        public static void Borrar(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "El ID de la evaluación no es válido.");
            }

            EvaluacionDonanteDAL.Eliminar(id);
        }

        #endregion


        #region Obtener por ID

        public static EvaluacionDonanteEntity
            ObtenerPorID(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "El ID de la evaluación no es válido.");
            }

            return EvaluacionDonanteDAL
                .ObtenerPorId(id);
        }

        #endregion


        #region Obtener todas

        public static IEnumerable<EvaluacionDonanteEntity>
            ObtenerTodas()
        {
            return EvaluacionDonanteDAL
                .ObtenerTodas();
        }

        #endregion


        #region Obtener por donante

        public static IEnumerable<EvaluacionDonanteEntity>
            ObtenerPorDonante(int donanteID)
        {
            if (donanteID <= 0)
            {
                throw new Exception(
                    "El ID del donante no es válido.");
            }

            return EvaluacionDonanteDAL
                .ObtenerPorDonante(donanteID);
        }

        #endregion


        #region Obtener última evaluación

        public static EvaluacionDonanteEntity
            ObtenerUltimaEvaluacion(int donanteID)
        {
            if (donanteID <= 0)
            {
                throw new Exception(
                    "El ID del donante no es válido.");
            }

            return EvaluacionDonanteDAL
                .ObtenerUltimaEvaluacion(donanteID);
        }

        #endregion


        #region Buscar

        public static IEnumerable<EvaluacionDonanteEntity>
            Buscar(string texto)
        {
            return EvaluacionDonanteDAL
                .Buscar(texto);
        }

        #endregion
    }
}