using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class CitasDAL
    {

        #region Metodos de Creacion y actualizar
        public static void Crear(CitasEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Citas.Add(entity);
                dbContext.SaveChanges();
            }

        } 
        
        public static void Actualizar(CitasEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                var citaEncontrada = dbContext.Citas.FirstOrDefault(x => x.ID == entity.ID);
                if (citaEncontrada != null)
                {
                    citaEncontrada.NombreDonante = entity.NombreDonante;
                    citaEncontrada.DonantesID = entity.DonantesID;
                    citaEncontrada.NombreDonante = entity.NombreDonante;
                    citaEncontrada.fechaCita = entity.fechaCita;
                    citaEncontrada.Descripcion = entity.Descripcion;
                    citaEncontrada.Correo = entity.Correo;

                    dbContext.Update(citaEncontrada);
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
                var citaEncontrada = dbContext.Citas.FirstOrDefault(c => c.ID == id);
                if (citaEncontrada != null)
                {
                    dbContext.Remove(citaEncontrada);
                    dbContext.SaveChanges();
                }
            }
      }
        #endregion

        #region Metodos de Lectura
        public static CitasEntity GetById(int id)
      {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Citas.FirstOrDefault(c => c.ID == id);
            } 
      }

      public static IEnumerable<CitasEntity> GetAll()
      {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Citas.ToList();
            }
      }
        #endregion
    }
}
