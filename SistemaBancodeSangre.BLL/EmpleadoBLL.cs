using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.BLL
{
    
    public class EmpleadoBLL
    {
        #region Metodos de Crear y Eliminar
        public static void Guardar(EmpleadosEntity entity)
        {
            if (entity.ID == 0)
            {
                EmpleadosDAL.Crear(entity);

                BitacoraBLL.RegistrarAccion(
                    accion: "Registrar Empleado",
                    detalle: $"Se registró el empleado {entity.nombre} {entity.Apellido}. Cédula: {entity.cedula}. Cargo: {entity.cargo}",
                    entidad: "Empleado",
                    entidadId: entity.ID);
            }
            else
            {
                EmpleadosDAL.Actualizar(entity);

                BitacoraBLL.RegistrarAccion(
                    accion: "Actualizar Empleado",
                    detalle: $"Se actualizó el empleado {entity.nombre} {entity.Apellido}. Cédula: {entity.cedula}. Cargo: {entity.cargo}",
                    entidad: "Empleado",
                    entidadId: entity.ID);
            }
        }
        #endregion

        #region Metodo Eliminar
        public static void Borrar(int id)
        {
            EmpleadosEntity empleado = EmpleadosDAL.GetById(id);

            EmpleadosDAL.Eliminar(id);

            if (empleado != null)
            {
                BitacoraBLL.RegistrarAccion(
                    accion: "Eliminar Empleado",
                    detalle: $"Se eliminó el empleado {empleado.nombre} {empleado.Apellido}. Cédula: {empleado.cedula}",
                    entidad: "Empleado",
                    entidadId: id);
            }
        }
        #endregion

        #region Metodos de Lectura
        public static EmpleadosEntity obtenerID(int Id)
        {
            return EmpleadosDAL.GetById(Id);
        }


        public static IEnumerable<EmpleadosEntity> ObtenerTodas()
        {
            return EmpleadosDAL.GetAll();

        }

        public static bool CedulaExiste(string cedula, int id)
        {
            return EmpleadosDAL.ExisteCedula(cedula, id);
        }


        public static IEnumerable<EmpleadosEntity> BuscarEmpleado(
        string campo,
         string texto,
         string estado)
           {

            return EmpleadosDAL.Buscar(
            campo,
            texto,
            estado);

        }

        public static object BuscarEmpleado(string campo, string texto)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
