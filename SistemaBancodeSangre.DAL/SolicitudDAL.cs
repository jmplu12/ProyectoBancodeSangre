using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class SolicitudDAL
    {
        #region Metodos Crear y Actualizar
        public static void Crear(SolicitudEntity entity)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Add(entity);
                dbContext.SaveChanges();
            }
        }


        public static void Update(SolicitudEntity entity)
        {
            using (var dbContext = new AppDbContext()) 
            {
               var solicitudEncontrada = dbContext.Solicitudes.FirstOrDefault(s => s.ID == entity.ID);
               if(solicitudEncontrada != null)
                {
                    solicitudEncontrada.ID = entity.ID;
                    solicitudEncontrada.solicitante = entity.solicitante;
                    solicitudEncontrada.cantidad = entity.cantidad;
                    solicitudEncontrada.medico = entity.medico;
                    solicitudEncontrada.fechaDeSolicitud = entity.fechaDeSolicitud;
                    solicitudEncontrada.hospital = entity.hospital;
                    solicitudEncontrada.proposito = entity.proposito;
                    solicitudEncontrada.prioridad = entity.prioridad;  
                    solicitudEncontrada.tipoDeSangresolicitada = entity.tipoDeSangresolicitada;
                    solicitudEncontrada.motivo = entity.motivo;
                    solicitudEncontrada.direccion = entity.direccion;
                    solicitudEncontrada.cartaMedica = entity.cartaMedica;
                    solicitudEncontrada.estadoSolicitud = entity.estadoSolicitud;
                    solicitudEncontrada.exequatur= entity.exequatur;
                    dbContext.Add(solicitudEncontrada);
                    dbContext.SaveChanges();
                }
            }
        }


        public static void ActualizarEstado(int solicitudId, string nuevoEstado)
        {
            using (var dbContext = new AppDbContext())
            {
                var solicitud = dbContext.Solicitudes.FirstOrDefault(s => s.ID == solicitudId);

                if (solicitud != null)
                {
                    solicitud.estadoSolicitud = nuevoEstado;
                    dbContext.SaveChanges();
                }
            }
        }


        public static void RestarInventario(string tipoSangre, int cantidadSolicitada)
        {
            using (var dbContext = new AppDbContext())
            {
                var inventarios = dbContext.Inventario
                    .Where(i => i.TipoSangre == tipoSangre && i.CantidadDisponible > 0)
                    .OrderBy(i => i.FechaVencimiento)
                    .ToList();

                // Calcula el total disponible.
                int totalDisponible = inventarios.Sum(i => i.CantidadDisponible);

                if (totalDisponible >= cantidadSolicitada)
                {
                    int cantidadRestante = cantidadSolicitada;

                    foreach (var inventario in inventarios)
                    {
                        if (cantidadRestante == 0) break;

                        if (inventario.CantidadDisponible >= cantidadRestante)
                        {
                            inventario.CantidadDisponible -= cantidadRestante;
                            cantidadRestante = 0;
                        }
                        else
                        {
                            cantidadRestante -= inventario.CantidadDisponible;
                            inventario.CantidadDisponible = 0;
                        }
                    }

                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No hay suficiente cantidad en el inventario para esta solicitud.");
                }
            }
        }

        #endregion

        #region Metodo Eliminar


        public static void Delete(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var solicitudEncontrada = dbContext.Solicitudes.FirstOrDefault(x => x.ID == id);
                if (solicitudEncontrada == null)
                {

                    dbContext.Remove(solicitudEncontrada);
                    dbContext.SaveChanges();
                }
            }
        }
        #endregion

        #region Metodos de Lectura

        public static SolicitudEntity GetById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Solicitudes.FirstOrDefault(s => s.ID == id);
            }
        }

        public static IEnumerable<SolicitudEntity> GetByName(string nombreSolicitante)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Solicitudes.Where(s => s.solicitante.Contains(nombreSolicitante)).ToList();
            }
        }


        public static IEnumerable<SolicitudEntity> EstadoSolicitud()
        {
            using (var dbContext = new AppDbContext())
            {

                return dbContext.Solicitudes.
                    Where(e => e.estadoSolicitud == "Pendiente").
                    ToList();

            }
        }

        public static IEnumerable<SolicitudEntity> EstadoSolicitudAprovados()
        {
            using (var dbContext = new AppDbContext())
            {

                return dbContext.Solicitudes.
                    Where(e => e.estadoSolicitud == "Autorizada").
                    ToList();

            }
        }

        public static List<SolicitudEntity> ObtenerSolicitudesSinEntrega(string filtro = "")
        {
            using (var context = new AppDbContext())
            {

                var entregadasIds = context.Entregas
                    .Select(e => e.SolicitudID)
                    .Distinct()
                    .ToList();

                var solicitudes = context.Solicitudes
                    .Where(s => s.estadoSolicitud == "Autorizada" && !entregadasIds.Contains(s.ID));

                if (!string.IsNullOrEmpty(filtro))
                {
                    solicitudes = solicitudes.Where(s => s.solicitante.Contains(filtro));
                }

                return solicitudes.ToList();


            }
        }

        public static IEnumerable<SolicitudEntity> GetAll()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Solicitudes.ToList();  
            }
        }
        #endregion
    }
}
