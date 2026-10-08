using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class CitasBLL
    {
        #region Metodos Crear y Actualizar  
        public static void Guardar(CitasEntity entity)
        {
            if (entity.ID == 0)
            {
                CitasDAL.Crear(entity);
            }

            else
            {
                CitasDAL.Actualizar(entity);
            }
        }
        #endregion|

        #region Metodo Eliminar
        public static void Borrar(int ID)
        {
            CitasDAL.Eliminar(ID);

        }
        #endregion
        #region Metodos de Lectura
        public static CitasEntity obtenerID(int Id)
        {
            return CitasDAL.GetById(Id);
        }

        //public static IEnumerable<CitasEntity> MetodoDeLectura(string nombre)
        //{
        //    return CitasDAL.(nombre);
        //}

        public static IEnumerable<CitasEntity> ObtenerTodas()
        {
            return CitasDAL.GetAll();
        }
        #endregion
    }
}
