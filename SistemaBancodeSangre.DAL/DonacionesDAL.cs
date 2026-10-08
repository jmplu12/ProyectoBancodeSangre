using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class DonacionesDAL
    {
        #region Métodos de Crear y Actualizar

        public static void Crear(DonacionesEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                // Guardamos primero la donación
                dbContext.Donaciones.Add(entity);
                dbContext.SaveChanges();

                // Generamos automáticamente el número de sangre
                entity.NumeroSangre =
                    "SANG-" +
                    entity.FechaDonacion.ToString("yyyyMMdd") +
                    "-" +
                    entity.ID.ToString("D5");

                // Guardamos el número generado
                dbContext.Donaciones.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public static void Actualizar(DonacionesEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var donacionEncontrada = dbContext.Donaciones
                    .FirstOrDefault(x => x.ID == entity.ID);

                if (donacionEncontrada != null)
                {
                    donacionEncontrada.Nombre =
                        entity.Nombre;

                    donacionEncontrada.Apellido =
                        entity.Apellido;

                    donacionEncontrada.CantidadSangre =
                        entity.CantidadSangre;

                    donacionEncontrada.Envase =
                        entity.Envase;

                    donacionEncontrada.FechaDonacion =
                        entity.FechaDonacion;

                    donacionEncontrada.TipoDeSangre =
                        entity.TipoDeSangre;

                    donacionEncontrada.Proposito =
                        entity.Proposito;

                    donacionEncontrada.Analista =
                        entity.Analista;

                    donacionEncontrada.DonanteID =
                        entity.DonanteID;

                    // Nueva relación con Evaluación
                    donacionEncontrada.EvaluacionDonanteID =
                        entity.EvaluacionDonanteID;

                    // IMPORTANTE:
                    // NumeroSangre no se modifica al editar.
                    // El código pertenece a la unidad original.

                    dbContext.SaveChanges();
                }
            }
        }

        #endregion


        #region Método Eliminar

        public static void Eliminar(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var donacionEncontrada = dbContext.Donaciones
                    .FirstOrDefault(x => x.ID == id);

                if (donacionEncontrada != null)
                {
                    dbContext.Donaciones.Remove(donacionEncontrada);

                    dbContext.SaveChanges();
                }
            }
        }

        #endregion


        #region Métodos de Lectura

        public static DonacionesEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donaciones
                    .Include(x => x.Donante)
                    .Include(x => x.EvaluacionDonante)
                    .FirstOrDefault(x => x.ID == id);
            }
        }


        public static IEnumerable<DonacionesEntity> GetByNombre(
            string nombre)
        {
            using (var dbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    return dbContext.Donaciones
                        .Include(x => x.Donante)
                        .Include(x => x.EvaluacionDonante)
                        .OrderByDescending(x => x.ID)
                        .ToList();
                }

                return dbContext.Donaciones
                    .Include(x => x.Donante)
                    .Include(x => x.EvaluacionDonante)
                    .Where(x =>
                        x.Nombre.Contains(nombre) ||
                        x.Apellido.Contains(nombre))
                    .OrderByDescending(x => x.ID)
                    .ToList();
            }
        }


        public static IEnumerable<DonacionesEntity> GetAll()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donaciones
                    .Include(x => x.Donante)
                    .Include(x => x.EvaluacionDonante)
                    .OrderByDescending(x => x.ID)
                    .ToList();
            }
        }


        public static IEnumerable<DonacionesEntity> GetByTipoSangre(
            string tipo)
        {
            using (var dbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(tipo))
                {
                    return dbContext.Donaciones
                        .Include(x => x.Donante)
                        .Include(x => x.EvaluacionDonante)
                        .OrderByDescending(x => x.ID)
                        .ToList();
                }

                return dbContext.Donaciones
                    .Include(x => x.Donante)
                    .Include(x => x.EvaluacionDonante)
                    .Where(x => x.TipoDeSangre == tipo)
                    .OrderByDescending(x => x.ID)
                    .ToList();
            }
        }


        public static IEnumerable<DonacionesEntity> GetByFecha(
            DateTime fecha)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donaciones
                    .Include(x => x.Donante)
                    .Include(x => x.EvaluacionDonante)
                    .Where(x =>
                        x.FechaDonacion.Date == fecha.Date)
                    .OrderByDescending(x => x.ID)
                    .ToList();
            }
        }


        public static DonacionesEntity GetByNumeroSangre(
            string numeroSangre)
        {
            using (var dbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(numeroSangre))
                {
                    return null;
                }

                return dbContext.Donaciones
                    .Include(x => x.Donante)
                    .Include(x => x.EvaluacionDonante)
                    .FirstOrDefault(x =>
                        x.NumeroSangre == numeroSangre);
            }
        }

        #endregion
    }
}