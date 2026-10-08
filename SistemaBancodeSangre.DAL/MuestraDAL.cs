using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class MuestraDAL
    {
        #region Crear

        public static void Crear(MuestraEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Muestras.Add(entity);
                dbContext.SaveChanges();
            }
        }

        #endregion

        #region Actualizar

        public static void Update(MuestraEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var muestraEncontrada = dbContext.Muestras
                    .FirstOrDefault(x => x.ID == entity.ID);

                if (muestraEncontrada != null)
                {
                    muestraEncontrada.NombreDonante = entity.NombreDonante;
                    muestraEncontrada.ApellidoDonante = entity.ApellidoDonante;
                    muestraEncontrada.TipoSangre = entity.TipoSangre;
                    muestraEncontrada.FechaToma = entity.FechaToma;
                    muestraEncontrada.FechaDonacion = entity.FechaDonacion;
                    muestraEncontrada.CantidadM = entity.CantidadM;
                    muestraEncontrada.Estado = entity.Estado;
                    muestraEncontrada.Observacion = entity.Observacion;
                    muestraEncontrada.Responsable = entity.Responsable;
                    muestraEncontrada.CodigoMuestra = entity.CodigoMuestra;
                    muestraEncontrada.Donacion = entity.Donacion;
                    muestraEncontrada.DonanteID = entity.DonanteID;

                    dbContext.SaveChanges();
                }
            }
        }

        #endregion

        #region Eliminar

        public static void Delete(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var muestraEncontrada = dbContext.Muestras
                    .FirstOrDefault(x => x.ID == id);

                if (muestraEncontrada != null)
                {
                    dbContext.Muestras.Remove(muestraEncontrada);
                    dbContext.SaveChanges();
                }
            }
        }

        #endregion

        #region Métodos de Lectura

        public static MuestraEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Muestras
                    .FirstOrDefault(x => x.ID == id);
            }
        }

        public static IEnumerable<MuestraEntity> GetByTipoSangre(string tipoSangre)
        {
            using (var dbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(tipoSangre))
                    return dbContext.Muestras.ToList();

                return dbContext.Muestras
                    .Where(x => x.TipoSangre.Contains(tipoSangre))
                    .ToList();
            }
        }

        public static IEnumerable<MuestraEntity> GetByFiltro(string criterio)
        {
            using (var dbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(criterio))
                    return dbContext.Muestras.ToList();

                criterio = criterio.ToLower();

                return dbContext.Muestras
                    .Where(x =>
                        x.NombreDonante.ToLower().Contains(criterio) ||
                        x.ApellidoDonante.ToLower().Contains(criterio) ||
                        x.CodigoMuestra.ToLower().Contains(criterio) ||
                        x.TipoSangre.ToLower().Contains(criterio) ||
                        x.Estado.ToLower().Contains(criterio))
                    .ToList();
            }
        }

        public static IEnumerable<MuestraEntity> GetAll()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Muestras.ToList();
            }
        }

        #endregion
    }
}
