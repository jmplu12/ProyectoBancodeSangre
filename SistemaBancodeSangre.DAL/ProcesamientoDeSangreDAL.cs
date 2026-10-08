using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class ProcesamientoDeSangreDAL
    {
        #region Métodos Crear y Actualizar

        public static void Crear(ProcesamientoDeSangreEntity Entity)
        {
            using (var DbContext = new AppDbContext())
            {
                DbContext.Procesamientos.Add(Entity);

                DbContext.SaveChanges();
            }
        }


        public static void Actualizar(
            ProcesamientoDeSangreEntity Entity)
        {
            using (var DbContext = new AppDbContext())
            {
                var ProcesamientoEncontrado =
                    DbContext.Procesamientos
                    .FirstOrDefault(P => P.ID == Entity.ID);

                if (ProcesamientoEncontrado == null)
                {
                    throw new Exception(
                        "El procesamiento que desea actualizar no existe.");
                }

                ProcesamientoEncontrado.EstadoProceso =
                    Entity.EstadoProceso;

                ProcesamientoEncontrado.FechaProceso =
                    Entity.FechaProceso;

                ProcesamientoEncontrado.TipoDeSangre =
                    Entity.TipoDeSangre;

                ProcesamientoEncontrado.VolumenDN =
                    Entity.VolumenDN;

                ProcesamientoEncontrado.Almacenado =
                    Entity.Almacenado;

                ProcesamientoEncontrado.Responsable =
                    Entity.Responsable;

                ProcesamientoEncontrado.NumeroSangre =
                    Entity.NumeroSangre;

                ProcesamientoEncontrado.ConcentradoGlobulosRojos =
                    Entity.ConcentradoGlobulosRojos;

                ProcesamientoEncontrado.Plasma =
                    Entity.Plasma;

                ProcesamientoEncontrado.Plaquetas =
                    Entity.Plaquetas;

                ProcesamientoEncontrado.DonacionesID =
                    Entity.DonacionesID;

                ProcesamientoEncontrado.MuestraID =
                    Entity.MuestraID;

                ProcesamientoEncontrado.AnalisisID =
                    Entity.AnalisisID;

                DbContext.SaveChanges();
            }
        }

        #endregion


        #region Actualizar Estado del Proceso

        public static void ActualizarEstadoProceso(
            int ProcesoID,
            string NuevoEstado)
        {
            using (var DbContext = new AppDbContext())
            {
                var ProcesoEncontrado =
                    DbContext.Procesamientos
                    .FirstOrDefault(P => P.ID == ProcesoID);

                if (ProcesoEncontrado == null)
                {
                    throw new Exception(
                        "El procesamiento no existe.");
                }

                ProcesoEncontrado.EstadoProceso =
                    NuevoEstado;

                DbContext.SaveChanges();
            }
        }

        #endregion


        #region Método Eliminar

        public static void Eliminar(int ID)
        {
            using (var DbContext = new AppDbContext())
            {
                var ProcesoEncontrado =
                    DbContext.Procesamientos
                    .FirstOrDefault(P => P.ID == ID);

                if (ProcesoEncontrado == null)
                {
                    throw new Exception(
                        "El procesamiento que desea eliminar no existe.");
                }

                DbContext.Procesamientos.Remove(
                    ProcesoEncontrado);

                DbContext.SaveChanges();
            }
        }

        #endregion


        #region Métodos de Lectura

        public static ProcesamientoDeSangreEntity ObtenerPorID(
            int ID)
        {
            using (var DbContext = new AppDbContext())
            {
                return DbContext.Procesamientos
                    .Include(P => P.Donaciones)
                    .AsNoTracking()
                    .FirstOrDefault(P => P.ID == ID);
            }
        }


        public static IEnumerable<ProcesamientoDeSangreEntity>
            ObtenerTodas()
        {
            using (var DbContext = new AppDbContext())
            {
                return DbContext.Procesamientos
                    .Include(P => P.Donaciones)
                    .AsNoTracking()
                    .OrderByDescending(P => P.ID)
                    .ToList();
            }
        }


        public static IEnumerable<ProcesamientoDeSangreEntity>
            ObtenerPorNombre(
                string NombreDonante)
        {
            using (var DbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(NombreDonante))
                {
                    return new List<ProcesamientoDeSangreEntity>();
                }

                NombreDonante =
                    NombreDonante.Trim();

                return DbContext.Procesamientos
                    .Include(P => P.Donaciones)
                    .Where(P =>
                        P.Donaciones.Nombre.Contains(
                            NombreDonante)
                        ||
                        P.Donaciones.Apellido.Contains(
                            NombreDonante))
                    .AsNoTracking()
                    .OrderByDescending(P => P.ID)
                    .ToList();
            }
        }


        public static IEnumerable<ProcesamientoDeSangreEntity>
            ObtenerSegunEstado(
                string Estado = null)
        {
            using (var DbContext = new AppDbContext())
            {
                var Consulta =
                    DbContext.Procesamientos
                    .Include(P => P.Donaciones)
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(Estado))
                {
                    Estado = Estado.Trim();

                    Consulta = Consulta.Where(
                        P => P.EstadoProceso == Estado);
                }

                return Consulta
                    .AsNoTracking()
                    .OrderByDescending(P => P.ID)
                    .ToList();
            }
        }


        public static ProcesamientoDeSangreEntity
            ObtenerPorNumeroSangre(
                string NumeroSangre)
        {
            using (var DbContext = new AppDbContext())
            {
                if (string.IsNullOrWhiteSpace(NumeroSangre))
                {
                    return null;
                }

                return DbContext.Procesamientos
                    .Include(P => P.Donaciones)
                    .AsNoTracking()
                    .FirstOrDefault(
                        P => P.NumeroSangre == NumeroSangre);
            }
        }

        #endregion


        #region Validaciones

        public static bool ExisteProcesamientoPorDonacion(
            int DonacionesID)
        {
            using (var DbContext = new AppDbContext())
            {
                return DbContext.Procesamientos
                    .Any(P => P.DonacionesID == DonacionesID);
            }
        }


        public static bool ExisteProcesamientoPorDonacion(
            int DonacionesID,
            int ProcesamientoID)
        {
            using (var DbContext = new AppDbContext())
            {
                return DbContext.Procesamientos
                    .Any(P =>
                        P.DonacionesID == DonacionesID
                        &&
                        P.ID != ProcesamientoID);
            }
        }

        #endregion


        #region Obtener Donaciones Disponibles

        public static IEnumerable<object>
            ObtenerDonacionesDisponibles()
        {
            using (var DbContext = new AppDbContext())
            {
                return DbContext.Donaciones

                    .Where(D =>
                        !DbContext.Procesamientos
                        .Any(P =>
                            P.DonacionesID == D.ID))

                    .Select(D => new
                    {
                        DonacionID = D.ID,

                        NumeroSangre =
                            D.NumeroSangre,

                        Nombre =
                            D.Nombre,

                        Apellido =
                            D.Apellido,

                        TipoDeSangre =
                            D.TipoDeSangre,

                        CantidadSangre =
                            D.CantidadSangre,

                        FechaDonacion =
                            D.FechaDonacion
                    })

                    .AsNoTracking()
                    .ToList();
            }
        }

        #endregion


        #region Obtener Información de Donación

        public static IEnumerable<object>
            ObtenerInformacionDonacion(
                int DonacionesID)
        {
            using (var DbContext = new AppDbContext())
            {
                var Informacion =
                    from Donacion
                    in DbContext.Donaciones

                    join Donante
                    in DbContext.Donantes

                    on Donacion.DonanteID
                    equals Donante.ID

                    where Donacion.ID == DonacionesID

                    select new
                    {
                        DonacionID =
                            Donacion.ID,

                        NumeroSangre =
                            Donacion.NumeroSangre,

                        DonanteID =
                            Donante.ID,

                        Nombre =
                            Donante.Nombre,

                        Apellido =
                            Donante.Apellido,

                        Cedula =
                            Donante.Cedula,

                        Sexo =
                            Donante.Sexo,

                        TipoDeSangre =
                            Donacion.TipoDeSangre,

                        CantidadSangre =
                            Donacion.CantidadSangre,

                        FechaDonacion =
                            Donacion.FechaDonacion,

                        Proposito =
                            Donacion.Proposito,

                        Analista =
                            Donacion.Analista
                    };

                return Informacion
                    .AsNoTracking()
                    .ToList();
            }
        }

        #endregion


        #region Obtener Información para el Procesamiento

        public static IEnumerable<object>
            ObtenerInformacionProcesamiento()
        {
            using (var DbContext = new AppDbContext())
            {
                var Informacion =
                    from Procesamiento
                    in DbContext.Procesamientos

                    join Donacion
                    in DbContext.Donaciones

                    on Procesamiento.DonacionesID
                    equals Donacion.ID

                    join Donante
                    in DbContext.Donantes

                    on Donacion.DonanteID
                    equals Donante.ID

                    select new
                    {
                        ProcesamientoID =
                            Procesamiento.ID,

                        DonacionID =
                            Donacion.ID,

                        NumeroSangre =
                            Procesamiento.NumeroSangre,

                        DonanteID =
                            Donante.ID,

                        Nombre =
                            Donante.Nombre,

                        Apellido =
                            Donante.Apellido,

                        Cedula =
                            Donante.Cedula,

                        TipoDeSangre =
                            Procesamiento.TipoDeSangre,

                        Volumen =
                            Procesamiento.VolumenDN,

                        EstadoProceso =
                            Procesamiento.EstadoProceso,

                        Almacenado =
                            Procesamiento.Almacenado,

                        Responsable =
                            Procesamiento.Responsable,

                        FechaProceso =
                            Procesamiento.FechaProceso,

                        ConcentradoGlobulosRojos =
                            Procesamiento.ConcentradoGlobulosRojos,

                        Plasma =
                            Procesamiento.Plasma,

                        Plaquetas =
                            Procesamiento.Plaquetas
                    };

                return Informacion
                    .AsNoTracking()
                    .ToList();
            }
        }

        #endregion


        #region Obtener Donación con Procesamiento

        public static object
            ObtenerDonacionProcesamiento(
                int DonacionesID)
        {
            using (var DbContext = new AppDbContext())
            {
                var Informacion =
                    from Donacion
                    in DbContext.Donaciones

                    join Donante
                    in DbContext.Donantes

                    on Donacion.DonanteID
                    equals Donante.ID

                    join Procesamiento
                    in DbContext.Procesamientos

                    on Donacion.ID
                    equals Procesamiento.DonacionesID
                    into Procesamientos

                    from Procesamiento
                    in Procesamientos.DefaultIfEmpty()

                    where Donacion.ID == DonacionesID

                    select new
                    {
                        DonacionID =
                            Donacion.ID,

                        NumeroSangre =
                            Donacion.NumeroSangre,

                        DonanteID =
                            Donante.ID,

                        Nombre =
                            Donante.Nombre,

                        Apellido =
                            Donante.Apellido,

                        TipoDeSangre =
                            Donacion.TipoDeSangre,

                        CantidadSangre =
                            Donacion.CantidadSangre,

                        FechaDonacion =
                            Donacion.FechaDonacion,

                        ProcesamientoID =
                            Procesamiento != null
                                ? Procesamiento.ID
                                : 0,

                        EstadoProceso =
                            Procesamiento != null
                                ? Procesamiento.EstadoProceso
                                : null,

                        FechaProceso =
                            Procesamiento != null
                                ? Procesamiento.FechaProceso
                                : (DateTime?)null,

                        Responsable =
                            Procesamiento != null
                                ? Procesamiento.Responsable
                                : null
                    };

                return Informacion
                    .FirstOrDefault();
            }
        }

        #endregion


        #region Obtener Procesamientos Disponibles para Inventario

        public static IEnumerable<object> ObtenerDisponiblesParaInventario()
        {
            using (var DbContext = new AppDbContext())
            {
                var Consulta =
                    from Procesamiento in DbContext.Procesamientos

                    join Donacion in DbContext.Donaciones
                        on Procesamiento.DonacionesID equals Donacion.ID

                    where
                        Procesamiento.EstadoProceso == "Procesada"
                        &&
                        !DbContext.Inventario.Any(
                            I => I.ProcesamientoID == Procesamiento.ID)

                    select new
                    {
                        ProcesamientoID = Procesamiento.ID,

                        CodigoBolsa = Procesamiento.NumeroSangre,

                        TipoSangre = Procesamiento.TipoDeSangre,

                        CantidadInicial = Procesamiento.VolumenDN,

                        FechaDonacion = Donacion.FechaDonacion,

                        FechaProceso = Procesamiento.FechaProceso,

                        DonacionID = Donacion.ID,

                        NombreDonante = Donacion.Nombre,

                        ApellidoDonante = Donacion.Apellido,

                        EstadoProceso = Procesamiento.EstadoProceso
                    };

                return Consulta
                    .AsNoTracking()
                    .OrderByDescending(P => P.ProcesamientoID)
                    .ToList();
            }
        }

        #endregion
    }
}

