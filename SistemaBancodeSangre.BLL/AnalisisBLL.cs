using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class AnalisisBLL
    {
        #region Guardar / Actualizar
        public static void Guardar(AnalisisEntity entity)
        {
            if (entity.ID == 0)
            {
                AnalisisDAL.Crear(entity);
            }
            else
            {
                AnalisisDAL.Update(entity);
            }
        }
        #endregion

        #region Eliminar
        public static void Eliminar(int id)
        {
            AnalisisDAL.Eliminar(id);
        }
        #endregion

        #region Lectura
        public static AnalisisEntity ObtenerPorId(int id)
        {
            return AnalisisDAL.GetById(id);
        }

        public static IEnumerable<AnalisisEntity> ObtenerTodas()
        {
            return AnalisisDAL.GetAll();
        }

        public static IEnumerable<AnalisisEntity> BuscarPorFiltro(string criterio, string campoFiltro)
        {
            return AnalisisDAL.BuscarPorFiltro(criterio, campoFiltro);
        }
        public static IEnumerable<object> GetDonantesMuestras()
        {
            return AnalisisDAL.GetDonacionesMuestras();
        }
        #endregion
    }
}


