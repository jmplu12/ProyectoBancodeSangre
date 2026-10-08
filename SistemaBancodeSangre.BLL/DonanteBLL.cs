using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    public class DonanteBLL
    {
        #region Metodos Crear y Actualizar
        public static void CrearDonante(DonantesEntity entity)
            {
            if (entity.ID == 0)
            {
                DonantesDAL.Crear(entity);

                BitacoraBLL.RegistrarAccion(
                    accion: "Registrar Donante",
                    detalle: $"Se registró el donante {entity.Nombre} {entity.Apellido}. Cédula: {entity.Cedula}",
                    entidad: "Donante",
                    entidadId: entity.ID);
            }
            else
            {
                DonantesDAL.Actualizar(entity);

                BitacoraBLL.RegistrarAccion(
                    accion: "Actualizar Donante",
                    detalle: $"Se actualizó el donante {entity.Nombre} {entity.Apellido}. Cédula: {entity.Cedula}",
                    entidad: "Donante",
                    entidadId: entity.ID);
            }

        }
        #endregion
        #region Metodo Eliminar
        public static void EliminarDonante(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID del donante es inválido.");
            }

            DonantesEntity donante = DonantesDAL.GetById(id);

            DonantesDAL.Eliminar(id);

            if (donante != null)
            {
                BitacoraBLL.RegistrarAccion(
                    accion: "Eliminar Donante",
                    detalle: $"Se eliminó el donante {donante.Nombre} {donante.Apellido}. Cédula: {donante.Cedula}",
                    entidad: "Donante",
                    entidadId: id);
            }
        }
        #endregion

        #region Metodos de Lectura
        public static DonantesEntity ObtenerDonantePorId(int id)
            {
                if (id <= 0)
                {
                    throw new ArgumentException("ID del donante es inválido.");
                }

                return DonantesDAL.GetById(id);
            }

        public static  DonantesEntity ObtenerDonanteCedula(string cedula)
        {
            
            if (string.IsNullOrEmpty(cedula))
            {
                throw new ArgumentException("La cédula es inválida.");
            }

            return DonantesDAL.GetByCedula(cedula);
        }
    

            public static IEnumerable<DonantesEntity> ObtenerDonantesPorNombre(string nombre)
            {
                
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }

                return DonantesDAL.GetByNombre(nombre);
            }

        public static IEnumerable<DonantesEntity> GetAll()
        {
            return DonantesDAL.GetTall();
        }

        public static bool ExisteCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
            {
                throw new ArgumentException("La cédula es obligatoria.");
            }

            return DonantesDAL.ExisteCedula(cedula);
        }

        public static bool ExisteCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                return false;
            }

            return DonantesDAL.ExisteCorreo(correo);
        }
        public static bool ExisteTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
            {
                return false;
            }

            return DonantesDAL.ExisteTelefono(telefono);
        }

        public static DonantesEntity ObtenerDonanteTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El teléfono es inválido.");
            }

            return DonantesDAL.GetByTelefono(telefono);
        }

        public static IEnumerable<DonantesEntity> ObtenerDonantesPorTipoSangre(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
            {
                throw new ArgumentException("Seleccione un tipo de sangre.");
            }

            return DonantesDAL.GetByTipoSangre(tipo);
        }


        #endregion
    }
}
