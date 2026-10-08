using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class DonantesDAL
    {
        #region Metodos de Crear y Actualizar
        public static void Crear(DonantesEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Donantes.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public static void Actualizar(DonantesEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var donanteEncontrado = dbContext.Donantes.FirstOrDefault(x => x.ID == entity.ID);
                if (donanteEncontrado != null)
                {
                    donanteEncontrado.Nombre = entity.  Nombre;
                    donanteEncontrado.Apellido = entity.    Apellido;
                    donanteEncontrado.Sexo = entity.Sexo;
                    donanteEncontrado.Cedula = entity.Cedula;
                    donanteEncontrado.Telefono = entity.Telefono;
                    donanteEncontrado.Edad = entity.Edad;
                    donanteEncontrado.PesoKlg = entity.PesoKlg;
                    donanteEncontrado.TipoDeSangre = entity.TipoDeSangre;
                    donanteEncontrado.TipodeDonante = entity.TipodeDonante;
                    donanteEncontrado.FechaNacimiento = entity.FechaNacimiento;
                    donanteEncontrado.Correo = entity.Correo;
                    donanteEncontrado.Municipio= entity.Municipio;
                    donanteEncontrado.Provincia = entity.Provincia;
                    donanteEncontrado.Direccion = entity.Direccion;
                    donanteEncontrado.EmpleadosID = entity.EmpleadosID;

                    dbContext.Update(donanteEncontrado);
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
                var donanteEncontrado = dbContext.Donantes.FirstOrDefault(x => x.ID == id);
                if (donanteEncontrado != null)
                {
                    dbContext.Remove(donanteEncontrado);
                    dbContext.SaveChanges();
                }
            }
        }

        #endregion


        #region Metodos de Lectura
        public static DonantesEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.FirstOrDefault(x => x.ID == id);
            }
        }
        public static DonantesEntity GetByCedula(string cedula)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.FirstOrDefault(d => d.Cedula == cedula);
            }
        }

        public static bool ExisteCedula(string cedula)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.Any(x => x.Cedula == cedula);
            }
        }
        public static IEnumerable<DonantesEntity> GetByNombre(string nombre)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.Where(x => x.Nombre.Contains(nombre)).ToList();
            }
        }

        public static IEnumerable<DonantesEntity> GetTall()
        {

            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.ToList();

            }
        }

        public static bool ExisteCorreo(string correo)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.Any(x => x.Correo == correo);
            }
        }


        public static bool ExisteTelefono(string telefono)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes.Any(x => x.Telefono == telefono);
            }
        }

        public static IEnumerable<DonantesEntity> GetByTipoSangre(string tipo)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes
                    .Where(x => x.TipoDeSangre == tipo)
                    .ToList();
            }
        }

        public static DonantesEntity GetByTelefono(string telefono)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Donantes
                    .FirstOrDefault(x => x.Telefono == telefono);
            }
        }

        #endregion
    }
}