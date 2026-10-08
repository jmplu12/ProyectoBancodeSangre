using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class AnalisisDAL
    {
        #region Métodos Guardar y Actualizar

        public static void Crear(AnalisisEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Analisis.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public static void Update(AnalisisEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var analisisEncontrado = dbContext.Analisis.FirstOrDefault(a => a.ID == entity.ID);
                if (analisisEncontrado != null)
                {
                    analisisEncontrado.analista = entity.analista;
                    analisisEncontrado.fechaAnalisis = entity.fechaAnalisis;
                    analisisEncontrado.Diabetes = entity.Diabetes;
                    analisisEncontrado.Vhsida = entity.Vhsida;
                    analisisEncontrado.chagas = entity.chagas;
                    analisisEncontrado.Cancer = entity.Cancer;
                    analisisEncontrado.HipertensionAlterial = entity.HipertensionAlterial;
                    analisisEncontrado.insuficienciaCardiaca = entity.insuficienciaCardiaca;
                    analisisEncontrado.Arritmias = entity.Arritmias;
                    analisisEncontrado.Hemofilia = entity.Hemofilia;
                    analisisEncontrado.estado = entity.estado;
                    analisisEncontrado.MuestraID = entity.MuestraID;
                    analisisEncontrado.hepatitisBoC = entity.hepatitisBoC;
                    analisisEncontrado.Tipodesangre = entity.Tipodesangre;

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
                var analisisEncontrado = dbContext.Analisis.FirstOrDefault(a => a.ID == id);
                if (analisisEncontrado != null)
                {
                    dbContext.Analisis.Remove(analisisEncontrado);
                    dbContext.SaveChanges();
                }
            }
        }

        #endregion

        #region Métodos de Lectura y Búsqueda

        public static AnalisisEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Analisis.FirstOrDefault(a => a.ID == id);
            }
        }

        public static IEnumerable<AnalisisEntity> GetAll()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Analisis.ToList();
            }
        }

        public static IEnumerable<AnalisisEntity> BuscarPorFiltro(string criterio, string campoFiltro)
        {
            using (var dbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(criterio))
                    return dbContext.Analisis.ToList();

                criterio = criterio.ToLower().Trim();

                var query = dbContext.Analisis.AsQueryable();

                switch (campoFiltro)
                {
                    case "Analista":
                        query = query.Where(a => a.analista.ToLower().Contains(criterio));
                        break;
                    case "Tipo de Sangre":
                        query = query.Where(a => a.Tipodesangre.ToLower().Contains(criterio));
                        break;
                    case "Estado":
                        query = query.Where(a => a.estado.ToLower().Contains(criterio));
                        break;
                    case "Todos":
                    default:
                        query = query.Where(a => a.analista.ToLower().Contains(criterio) ||
                                                 a.Tipodesangre.ToLower().Contains(criterio) ||
                                                 a.estado.ToLower().Contains(criterio));
                        break;
                }

                return query.ToList();
            }
        }

        public static IEnumerable<object> GetDonacionesMuestras()
        {
            using (var dbContext = new AppDbContext())
            {
                return (from donaciones in dbContext.Donaciones
                        join muestra in dbContext.Muestras
                        on donaciones.ID equals muestra.DonacionesID
                        select new
                        {
                            DonacionesID = donaciones.ID,
                            Nombre = donaciones.Nombre,
                            Apellido = donaciones.Apellido,
                            MuestraID = muestra.ID,
                            CodigoMuestra = muestra.CodigoMuestra,
                        }).ToList();
            }
        }

        #endregion
    }
}


    

