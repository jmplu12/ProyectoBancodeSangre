using DocumentFormat.OpenXml.Office2010.Excel;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class DonacionesBLL
    {
        #region Métodos Crear y Actualizar

        public static void Guardar(DonacionesEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(
                    nameof(entity),
                    "La donación no puede ser nula."
                );
            }

            // ==========================================
            // VALIDAR DATOS DE LA DONACIÓN
            // ==========================================

            Validar(entity);


            // ==========================================
            // OBTENER ÚLTIMA EVALUACIÓN DEL DONANTE
            // ==========================================

            EvaluacionDonanteEntity evaluacion =
                EvaluacionDonanteBLL.ObtenerUltimaEvaluacion(
                    entity.DonanteID
                );


            // ==========================================
            // VERIFICAR QUE EXISTA EVALUACIÓN
            // ==========================================

            if (evaluacion == null)
            {
                throw new Exception(
                    "El donante no tiene una evaluación registrada. " +
                    "Debe realizar la evaluación antes de registrar la donación."
                );
            }


            // ==========================================
            // VERIFICAR RESULTADO DE LA EVALUACIÓN
            // ==========================================

            if (evaluacion.Resultado != "APTO")
            {
                throw new Exception(
                    "El donante no está apto para donar. " +
                    "Resultado de la última evaluación: " +
                    evaluacion.Resultado
                );
            }


            // ==========================================
            // ASOCIAR EVALUACIÓN A LA DONACIÓN
            // ==========================================

            entity.EvaluacionDonanteID =
                evaluacion.ID;


            // ==========================================
            // GUARDAR O ACTUALIZAR
            // ==========================================

            if (entity.ID == 0)
            {
                DonacionesDAL.Crear(entity);

                BitacoraBLL.RegistrarAccion(
                    accion: "Registrar Donación",
                    detalle:
                        $"Se registró una donación del donante " +
                        $"{entity.Nombre} {entity.Apellido}. " +
                        $"Tipo de sangre: {entity.TipoDeSangre}. " +
                        $"Número de sangre: {entity.NumeroSangre}. " +
                        $"Evaluación: {evaluacion.ID}",
                    entidad: "Donación",
                    entidadId: entity.ID
                );
            }
            else
            {
                DonacionesDAL.Actualizar(entity);

                BitacoraBLL.RegistrarAccion(
                    accion: "Actualizar Donación",
                    detalle:
                        $"Se actualizó la donación del donante " +
                        $"{entity.Nombre} {entity.Apellido}. " +
                        $"Número de sangre: {entity.NumeroSangre}. " +
                        $"Evaluación: {evaluacion.ID}",
                    entidad: "Donación",
                    entidadId: entity.ID
                );
            }
        }

        #endregion


        #region Método Eliminar

        public static void Eliminar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(
                    "El ID de la donación no es válido."
                );
            }


            DonacionesEntity donacion =
                DonacionesDAL.GetById(id);


            if (donacion == null)
            {
                throw new Exception(
                    "La donación que intenta eliminar no existe."
                );
            }


            DonacionesDAL.Eliminar(id);


            BitacoraBLL.RegistrarAccion(
                accion: "Eliminar Donación",
                detalle:
                    $"Se eliminó la donación del donante " +
                    $"{donacion.Nombre} {donacion.Apellido}. " +
                    $"Número de sangre: {donacion.NumeroSangre}",
                entidad: "Donación",
                entidadId: id
            );
        }

        #endregion


        #region Métodos de Lectura

        public static DonacionesEntity ObtenerPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(
                    "El ID ingresado no es válido."
                );
            }

            return DonacionesDAL.GetById(id);
        }


        public static IEnumerable<DonacionesEntity> ObtenerTodas()
        {
            return DonacionesDAL.GetAll();
        }


        public static IEnumerable<DonacionesEntity> GetAll()
        {
            return DonacionesDAL.GetAll();
        }


        public static IEnumerable<DonacionesEntity> ObtenerPorNombre(
            string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException(
                    "El criterio de búsqueda no puede estar vacío."
                );
            }

            return DonacionesDAL.GetByNombre(nombre);
        }


        public static IEnumerable<DonacionesEntity> ObtenerPorTipoSangre(
            string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
            {
                throw new ArgumentException(
                    "Debe seleccionar un tipo de sangre."
                );
            }

            return DonacionesDAL.GetByTipoSangre(tipo);
        }


        public static IEnumerable<DonacionesEntity> ObtenerPorFecha(
            DateTime fecha)
        {
            return DonacionesDAL.GetByFecha(fecha);
        }


        public static DonacionesEntity ObtenerPorNumeroSangre(
            string numeroSangre)
        {
            if (string.IsNullOrWhiteSpace(numeroSangre))
            {
                throw new ArgumentException(
                    "El número de sangre es obligatorio."
                );
            }

            return DonacionesDAL.GetByNumeroSangre(
                numeroSangre.Trim()
            );
        }

        #endregion


        #region Validaciones

        private static void Validar(DonacionesEntity entity)
        {
            // ==========================================
            // NOMBRE
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.Nombre))
            {
                throw new ArgumentException(
                    "El nombre del donante es obligatorio."
                );
            }


            if (entity.Nombre.Length > 50)
            {
                throw new ArgumentException(
                    "El nombre no puede superar los 50 caracteres."
                );
            }


            // ==========================================
            // APELLIDO
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.Apellido))
            {
                throw new ArgumentException(
                    "El apellido del donante es obligatorio."
                );
            }


            if (entity.Apellido.Length > 50)
            {
                throw new ArgumentException(
                    "El apellido no puede superar los 50 caracteres."
                );
            }


            // ==========================================
            // TIPO DE SANGRE
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.TipoDeSangre))
            {
                throw new ArgumentException(
                    "Debe seleccionar el tipo de sangre."
                );
            }


            if (entity.TipoDeSangre.Length > 3)
            {
                throw new ArgumentException(
                    "El tipo de sangre no es válido."
                );
            }


            // ==========================================
            // CANTIDAD
            // ==========================================

            if (entity.CantidadSangre <= 0)
            {
                throw new ArgumentException(
                    "La cantidad de sangre debe ser mayor que cero."
                );
            }


            if (entity.CantidadSangre > 1000)
            {
                throw new ArgumentException(
                    "La cantidad de sangre no puede superar los 1000 ml."
                );
            }


            // ==========================================
            // ENVASE
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.Envase))
            {
                throw new ArgumentException(
                    "Debe indicar el envase."
                );
            }


            if (entity.Envase.Length > 50)
            {
                throw new ArgumentException(
                    "El envase no puede superar los 50 caracteres."
                );
            }


            // ==========================================
            // FECHA
            // ==========================================

            if (entity.FechaDonacion > DateTime.Now)
            {
                throw new ArgumentException(
                    "La fecha de donación no puede ser futura."
                );
            }


            // ==========================================
            // PROPÓSITO
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.Proposito))
            {
                throw new ArgumentException(
                    "Debe indicar el propósito de la donación."
                );
            }


            if (entity.Proposito.Length > 200)
            {
                throw new ArgumentException(
                    "El propósito no puede superar los 200 caracteres."
                );
            }


            // ==========================================
            // ANALISTA
            // ==========================================

            if (string.IsNullOrWhiteSpace(entity.Analista))
            {
                throw new ArgumentException(
                    "Debe indicar el analista responsable."
                );
            }


            if (entity.Analista.Length > 100)
            {
                throw new ArgumentException(
                    "El analista no puede superar los 100 caracteres."
                );
            }


            // ==========================================
            // DONANTE
            // ==========================================

            if (entity.DonanteID <= 0)
            {
                throw new ArgumentException(
                    "Debe asociar la donación a un donante válido."
                );
            }

        }

        #endregion
    }
}