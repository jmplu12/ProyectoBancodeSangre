using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class EvaluacionDonanteDAL
    {
        #region Crear

        public static void Crear(EvaluacionDonanteEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.EvaluacionesDonantes.Add(entity);

                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Actualizar

        public static void Actualizar(EvaluacionDonanteEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var evaluacionEncontrada =
                    dbContext.EvaluacionesDonantes
                    .FirstOrDefault(e => e.ID == entity.ID);

                if (evaluacionEncontrada == null)
                {
                    throw new Exception(
                        "La evaluación del donante no existe.");
                }


                evaluacionEncontrada.DonanteID =
                    entity.DonanteID;

                evaluacionEncontrada.EmpleadoID =
                    entity.EmpleadoID;

                evaluacionEncontrada.FechaEvaluacion =
                    entity.FechaEvaluacion;

                evaluacionEncontrada.Peso =
                    entity.Peso;

                evaluacionEncontrada.PresionArterial =
                    entity.PresionArterial;

                evaluacionEncontrada.Temperatura =
                    entity.Temperatura;

                evaluacionEncontrada.TieneEnfermedad =
                    entity.TieneEnfermedad;

                evaluacionEncontrada.TomaMedicamentos =
                    entity.TomaMedicamentos;

                evaluacionEncontrada.TieneSintomas =
                    entity.TieneSintomas;

                evaluacionEncontrada.HaTenidoCirugia =
                    entity.HaTenidoCirugia;

                evaluacionEncontrada.HaDonadoAnteriormente =
                    entity.HaDonadoAnteriormente;

                evaluacionEncontrada.Observaciones =
                    entity.Observaciones;

                evaluacionEncontrada.Resultado =
                    entity.Resultado;

                evaluacionEncontrada.Estado =
                    entity.Estado;


                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Eliminar

        public static void Eliminar(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var evaluacionEncontrada =
                    dbContext.EvaluacionesDonantes
                    .FirstOrDefault(e => e.ID == id);

                if (evaluacionEncontrada == null)
                {
                    throw new Exception(
                        "La evaluación del donante no existe.");
                }


                dbContext.EvaluacionesDonantes
                    .Remove(evaluacionEncontrada);

                dbContext.SaveChanges();
            }
        }

        #endregion


        #region Obtener por ID

        public static EvaluacionDonanteEntity
            ObtenerPorId(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.EvaluacionesDonantes
                    .FirstOrDefault(e => e.ID == id);
            }
        }

        #endregion


        #region Obtener todas

        public static IEnumerable<EvaluacionDonanteEntity>
            ObtenerTodas()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.EvaluacionesDonantes
                    .OrderByDescending(e => e.ID)
                    .ToList();
            }
        }

        #endregion


        #region Obtener por donante

        public static IEnumerable<EvaluacionDonanteEntity>
            ObtenerPorDonante(int donanteID)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.EvaluacionesDonantes
                    .Where(e => e.DonanteID == donanteID)
                    .OrderByDescending(e => e.FechaEvaluacion)
                    .ToList();
            }
        }

        #endregion


        #region Obtener última evaluación del donante

        public static EvaluacionDonanteEntity
            ObtenerUltimaEvaluacion(int donanteID)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.EvaluacionesDonantes
                    .Where(e => e.DonanteID == donanteID)
                    .OrderByDescending(e => e.FechaEvaluacion)
                    .FirstOrDefault();
            }
        }

        #endregion


        #region Buscar

        public static IEnumerable<EvaluacionDonanteEntity>
            Buscar(string texto)
        {
            using (var dbContext = new AppDbContext())
            {
                texto = texto ?? "";

                texto = texto.Trim();

                return dbContext.EvaluacionesDonantes
                    .Where(e =>
                        e.Resultado.Contains(texto) ||
                        e.Estado.Contains(texto) ||
                        e.Observaciones.Contains(texto))
                    .OrderByDescending(e => e.ID)
                    .ToList();
            }
        }

        #endregion
    }
}
