using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class ProcesamientoDeSangreBLL
    {
        #region Métodos Crear y Actualizar

        public static void Guardar(
            ProcesamientoDeSangreEntity Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException(
                    nameof(Entity),
                    "El procesamiento no puede ser nulo.");
            }

            Validar(Entity);

            // =====================================================
            // NUEVO PROCESAMIENTO
            // =====================================================

            if (Entity.ID == 0)
            {
                // Verificar que la donación no tenga
                // otro procesamiento registrado.

                if (ProcesamientoDeSangreDAL
                    .ExisteProcesamientoPorDonacion(
                        Entity.DonacionesID))
                {
                    throw new Exception(
                        "Esta donación ya tiene un procesamiento registrado.");
                }

                // Verificar que el número de sangre
                // no esté repetido.

                ProcesamientoDeSangreEntity
                    ProcesamientoExistente =
                    ProcesamientoDeSangreDAL
                    .ObtenerPorNumeroSangre(
                        Entity.NumeroSangre);

                if (ProcesamientoExistente != null)
                {
                    throw new Exception(
                        "El número de sangre ya está registrado en otro procesamiento.");
                }

                ProcesamientoDeSangreDAL.Crear(Entity);
            }

            // =====================================================
            // ACTUALIZAR PROCESAMIENTO
            // =====================================================

            else
            {
                // Verificar que la donación no esté
                // relacionada con otro procesamiento.

                if (ProcesamientoDeSangreDAL
                    .ExisteProcesamientoPorDonacion(
                        Entity.DonacionesID,
                        Entity.ID))
                {
                    throw new Exception(
                        "La donación seleccionada ya está asociada a otro procesamiento.");
                }

                // Buscar si el número de sangre pertenece
                // a otro procesamiento.

                ProcesamientoDeSangreEntity
                    ProcesamientoExistente =
                    ProcesamientoDeSangreDAL
                    .ObtenerPorNumeroSangre(
                        Entity.NumeroSangre);

                if (ProcesamientoExistente != null &&
                    ProcesamientoExistente.ID != Entity.ID)
                {
                    throw new Exception(
                        "El número de sangre ya pertenece a otro procesamiento.");
                }

                ProcesamientoDeSangreDAL.Actualizar(Entity);
            }
        }

        #endregion


        #region Validaciones

        private static void Validar(
            ProcesamientoDeSangreEntity Entity)
        {
            // =====================================================
            // DONACIÓN
            // =====================================================

            if (Entity.DonacionesID <= 0)
            {
                throw new Exception(
                    "Debe seleccionar una donación válida.");
            }


            // =====================================================
            // NÚMERO DE SANGRE
            // =====================================================

            if (string.IsNullOrWhiteSpace(
                Entity.NumeroSangre))
            {
                throw new Exception(
                    "El número de sangre es obligatorio.");
            }

            Entity.NumeroSangre =
                Entity.NumeroSangre.Trim();

            if (Entity.NumeroSangre.Length > 50)
            {
                throw new Exception(
                    "El número de sangre no puede superar los 50 caracteres.");
            }


            // =====================================================
            // ESTADO
            // =====================================================

            if (string.IsNullOrWhiteSpace(
                Entity.EstadoProceso))
            {
                throw new Exception(
                    "El estado del proceso es obligatorio.");
            }

            Entity.EstadoProceso =
                Entity.EstadoProceso.Trim();

            if (!EstadoValido(
                Entity.EstadoProceso))
            {
                throw new Exception(
                    "El estado seleccionado no es válido.");
            }


            // =====================================================
            // TIPO DE SANGRE
            // =====================================================

            if (string.IsNullOrWhiteSpace(
                Entity.TipoDeSangre))
            {
                throw new Exception(
                    "El tipo de sangre es obligatorio.");
            }

            Entity.TipoDeSangre =
                Entity.TipoDeSangre.Trim();


            // =====================================================
            // VOLUMEN
            // =====================================================

            if (Entity.VolumenDN <= 0)
            {
                throw new Exception(
                    "El volumen de sangre debe ser mayor que cero.");
            }

            if (Entity.VolumenDN > 10000)
            {
                throw new Exception(
                    "El volumen de sangre no puede superar los 10,000 ml.");
            }


            // =====================================================
            // ALMACENAMIENTO
            // =====================================================

            if (string.IsNullOrWhiteSpace(
                Entity.Almacenado))
            {
                throw new Exception(
                    "Debe indicar dónde será almacenada la sangre.");
            }

            Entity.Almacenado =
                Entity.Almacenado.Trim();


            // =====================================================
            // RESPONSABLE
            // =====================================================

            if (string.IsNullOrWhiteSpace(
                Entity.Responsable))
            {
                throw new Exception(
                    "El responsable del procesamiento es obligatorio.");
            }

            Entity.Responsable =
                Entity.Responsable.Trim();

            if (Entity.Responsable.Length > 150)
            {
                throw new Exception(
                    "El responsable no puede superar los 150 caracteres.");
            }


            // =====================================================
            // FECHA
            // =====================================================

            if (Entity.FechaProceso.Date >
                DateTime.Today)
            {
                throw new Exception(
                    "La fecha de procesamiento no puede ser futura.");
            }


            // =====================================================
            // COMPONENTES
            // =====================================================

            if (!Entity.ConcentradoGlobulosRojos &&
                !Entity.Plasma &&
                !Entity.Plaquetas)
            {
                throw new Exception(
                    "Debe seleccionar al menos un componente sanguíneo.");
            }
        }

        #endregion


        #region Validar Estado

        private static bool EstadoValido(
            string Estado)
        {
            if (string.IsNullOrWhiteSpace(Estado))
            {
                return false;
            }

            switch (Estado.Trim())
            {
                case "Pendiente":
                    return true;

                case "En procesamiento":
                    return true;

                case "Procesada":
                    return true;

                case "No apta":
                    return true;

                case "Almacenada":
                    return true;

                default:
                    return false;
            }
        }

        #endregion


        #region Actualizar Estado

        public static void ActualizarEstadoProceso(
            int ProcesoID,
            string Estado)
        {
            if (ProcesoID <= 0)
            {
                throw new Exception(
                    "El ID del procesamiento no es válido.");
            }

            if (string.IsNullOrWhiteSpace(Estado))
            {
                throw new Exception(
                    "Debe seleccionar un estado.");
            }

            Estado = Estado.Trim();

            if (!EstadoValido(Estado))
            {
                throw new Exception(
                    "El estado seleccionado no es válido.");
            }

            ProcesamientoDeSangreDAL
                .ActualizarEstadoProceso(
                    ProcesoID,
                    Estado);
        }

        #endregion


        #region Método Eliminar

        public static void Borrar(int ID)
        {
            if (ID <= 0)
            {
                throw new Exception(
                    "El ID del procesamiento no es válido.");
            }

            ProcesamientoDeSangreDAL
                .Eliminar(ID);
        }

        #endregion


        #region Métodos de Lectura

        public static ProcesamientoDeSangreEntity
            ObtenerPorID(int ID)
        {
            if (ID <= 0)
            {
                return null;
            }

            return ProcesamientoDeSangreDAL
                .ObtenerPorID(ID);
        }


        public static IEnumerable<ProcesamientoDeSangreEntity>
            ObtenerTodas()
        {
            return ProcesamientoDeSangreDAL
                .ObtenerTodas();
        }


        public static IEnumerable<ProcesamientoDeSangreEntity>
            ObtenerPorNombre(
                string NombreDonante)
        {
            if (string.IsNullOrWhiteSpace(
                NombreDonante))
            {
                return new List<ProcesamientoDeSangreEntity>();
            }

            return ProcesamientoDeSangreDAL
                .ObtenerPorNombre(
                    NombreDonante);
        }


        public static ProcesamientoDeSangreEntity
            ObtenerPorNumeroSangre(
                string NumeroSangre)
        {
            if (string.IsNullOrWhiteSpace(
                NumeroSangre))
            {
                return null;
            }

            return ProcesamientoDeSangreDAL
                .ObtenerPorNumeroSangre(
                    NumeroSangre.Trim());
        }


        public static IEnumerable<ProcesamientoDeSangreEntity>
            ObtenerSegunEstado(
                string Estado = null)
        {
            return ProcesamientoDeSangreDAL
                .ObtenerSegunEstado(
                    Estado);
        }

        #endregion


        #region Validaciones de Donación

        public static bool ExisteProcesamientoPorDonacion(
            int DonacionesID)
        {
            if (DonacionesID <= 0)
            {
                return false;
            }

            return ProcesamientoDeSangreDAL
                .ExisteProcesamientoPorDonacion(
                    DonacionesID);
        }


        public static bool ExisteProcesamientoPorDonacion(
            int DonacionesID,
            int ProcesamientoID)
        {
            if (DonacionesID <= 0 ||
                ProcesamientoID <= 0)
            {
                return false;
            }

            return ProcesamientoDeSangreDAL
                .ExisteProcesamientoPorDonacion(
                    DonacionesID,
                    ProcesamientoID);
        }

        #endregion


        #region Validaciones Número de Sangre

        public static bool ExisteNumeroSangre(
            string NumeroSangre)
        {
            if (string.IsNullOrWhiteSpace(
                NumeroSangre))
            {
                return false;
            }

            ProcesamientoDeSangreEntity
                Procesamiento =
                ProcesamientoDeSangreDAL
                .ObtenerPorNumeroSangre(
                    NumeroSangre.Trim());

            return Procesamiento != null;
        }


        public static bool ExisteNumeroSangre(
            string NumeroSangre,
            int ProcesamientoID)
        {
            if (string.IsNullOrWhiteSpace(
                NumeroSangre) ||
                ProcesamientoID <= 0)
            {
                return false;
            }

            ProcesamientoDeSangreEntity
                Procesamiento =
                ProcesamientoDeSangreDAL
                .ObtenerPorNumeroSangre(
                    NumeroSangre.Trim());

            if (Procesamiento == null)
            {
                return false;
            }

            return Procesamiento.ID != ProcesamientoID;
        }

        #endregion


        #region Donaciones Disponibles

        public static IEnumerable<object>
            ObtenerDonacionesDisponibles()
        {
            return ProcesamientoDeSangreDAL
                .ObtenerDonacionesDisponibles();
        }

        #endregion


        #region Información de Donación

        public static IEnumerable<object>
            ObtenerInformacionDonacion(
                int DonacionesID)
        {
            if (DonacionesID <= 0)
            {
                return new List<object>();
            }

            return ProcesamientoDeSangreDAL
                .ObtenerInformacionDonacion(
                    DonacionesID);
        }

        #endregion


        #region Información de Procesamiento

        public static IEnumerable<object>
            ObtenerInformacionProcesamiento()
        {
            return ProcesamientoDeSangreDAL
                .ObtenerInformacionProcesamiento();
        }


        public static object
            ObtenerDonacionProcesamiento(
                int DonacionesID)
        {
            if (DonacionesID <= 0)
            {
                return null;
            }

            return ProcesamientoDeSangreDAL
                .ObtenerDonacionProcesamiento(
                    DonacionesID);
        }

        #endregion
    }
}