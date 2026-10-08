using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class SolicitudBLL
    {
        #region Metodos de Crear y Actualizar
        public static void Guardar(SolicitudEntity entity)
        {
            if (entity.ID == 0)
            {
                SolicitudDAL.Crear(entity);
            }

            else
            {
                SolicitudDAL.Update(entity);
            }
        }

        public static void ActualizarEstado(int SolicitudId, string nuevoEstado)
        {
            SolicitudDAL.ActualizarEstado(SolicitudId, nuevoEstado);
        }

        public static void RestarInventario(String tipoSangre, int cantidad)
        {
           SolicitudDAL.RestarInventario(tipoSangre, cantidad);
        }
        #endregion

        #region Metodos de Eliminar
        public static void Borrar(int ID)
        {
            SolicitudDAL.Delete(ID);

        }
        #endregion
        #region Metodos de Lectura
        public static SolicitudEntity obtenerID(int Id)
        {
            return SolicitudDAL.GetById(Id);
        }

        public static IEnumerable<SolicitudEntity> ObtenerNombre(string nombre)
        {
            return SolicitudDAL.GetByName(nombre);
        }

        public static IEnumerable<SolicitudEntity> ObtenerEstados()
        {
            return SolicitudDAL.EstadoSolicitud();
        }

        public static IEnumerable<SolicitudEntity> ObtenerEstadosAprovados()
        {
            return SolicitudDAL.EstadoSolicitudAprovados();
        }

        public static List<SolicitudEntity> ObtenerSolicitudesDisponibles(string filtro = "")
        {
            return SolicitudDAL.ObtenerSolicitudesSinEntrega(filtro);
        }


        public static IEnumerable<SolicitudEntity> ObtenerTodas()
        {
            return SolicitudDAL.GetAll();
        }
        #endregion
    }
}
