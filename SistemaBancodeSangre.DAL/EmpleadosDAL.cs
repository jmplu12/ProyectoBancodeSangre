using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    #region Metodos Crear y Actualizar
    public class EmpleadosDAL
    {
        public static void Crear(EmpleadosEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Empleados.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public static void Actualizar(EmpleadosEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var empleadosEncontrado = dbContext.Empleados.FirstOrDefault(x => x.ID == entity.ID);
                if (empleadosEncontrado != null)
                {
                    empleadosEncontrado.nombre = entity.nombre;
                    empleadosEncontrado.Apellido = entity.Apellido;
                    empleadosEncontrado.sexo = entity.sexo;
                    empleadosEncontrado.cedula = entity.cedula;
                    empleadosEncontrado.telefono = entity.telefono;
                    empleadosEncontrado.estado = entity.estado;
                    empleadosEncontrado.cargo = entity.cargo;
                    empleadosEncontrado.FechaNac = entity.FechaNac;
                    empleadosEncontrado.email = entity.email;
                    empleadosEncontrado.provincia = entity.provincia;
                    empleadosEncontrado.dirreccion = entity.dirreccion;
                    

                    dbContext.Update(empleadosEncontrado);
                    dbContext.SaveChanges();
                }
            }
        }
        #endregion

        #region Metodo Eliminar 

        public static void Eliminar(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var empleadoEncontrado = dbContext.Empleados
                    .FirstOrDefault(x => x.ID == id);

                if (empleadoEncontrado != null)
                {
                    dbContext.Empleados.Remove(empleadoEncontrado);
                    dbContext.SaveChanges();
                }
            }
        }

        #endregion

        #region Metodos de Lectura
        public static EmpleadosEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Empleados.FirstOrDefault(x => x.ID == id);
            }
        }

        public static IEnumerable<EmpleadosEntity> GetByNombre(string nombre)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Empleados.Where(x => x.nombre.Contains(nombre)).ToList();
            }
        }

        public static IEnumerable<EmpleadosEntity> GetAll()
        {

            using (var dbContext = new AppDbContext())
            {
                return dbContext.Empleados.ToList();

            }
        }
        public static bool ExisteCedula(string cedula, int idActual = 0)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Empleados
                    .Any(x => x.cedula == cedula && x.ID != idActual);
            }
        }

        public static IEnumerable<EmpleadosEntity> Buscar(
 string campo,
 string texto,
 string estado)
        {

            using (var dbContext = new AppDbContext())
            {


                var consulta =
                dbContext.Empleados.AsQueryable();



                if (!string.IsNullOrEmpty(texto))
                {

                    switch (campo)
                    {

                        case "Nombre":

                            consulta =
                            consulta.Where(
                            x => x.nombre.Contains(texto));

                            break;


                        case "Cédula":

                            consulta =
                            consulta.Where(
                            x => x.cedula.Contains(texto));

                            break;


                        case "Cargo":

                            consulta =
                            consulta.Where(
                            x => x.cargo.Contains(texto));

                            break;


                        case "Teléfono":

                            consulta =
                            consulta.Where(
                            x => x.telefono.Contains(texto));

                            break;

                    }

                }



                if (estado == "Activo")
                {
                    consulta =
                    consulta.Where(x => x.estado == true);
                }



                if (estado == "Inactivo")
                {
                    consulta =
                    consulta.Where(x => x.estado == false);
                }



                return consulta.ToList();

            }

        }


        #endregion
    }
}
