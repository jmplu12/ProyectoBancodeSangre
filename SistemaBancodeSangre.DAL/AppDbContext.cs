using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.DAL
{
    public class AppDbContext : DbContext
    {
        #region Conexion BD

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=GILBERT-ROSADO\\SQLEXPRESS;" +
                "Initial Catalog=BDPRUEBA1;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;"
            );
        }

        #endregion


        #region DbSet

        public DbSet<EvaluacionDonanteEntity> EvaluacionesDonantes { get; set; }
        public DbSet<DonantesEntity> Donantes { get; set; }

        public DbSet<SolicitudEntity> Solicitudes { get; set; }

        public DbSet<DonacionesEntity> Donaciones { get; set; }

        public DbSet<MuestraEntity> Muestras { get; set; }

        public DbSet<CitasEntity> Citas { get; set; }

        public DbSet<ProcesamientoDeSangreEntity> Procesamientos { get; set; }

        public DbSet<AnalisisEntity> Analisis { get; set; }

        public DbSet<EntregaEntity> Entregas { get; set; }

        public DbSet<EmpleadosEntity> Empleados { get; set; }

        public DbSet<UsuariosEntity> Usuarios { get; set; }

        public DbSet<InventarioEntity> Inventario { get; set; }

        public DbSet<PermisosEntity> Permisos { get; set; }

        public DbSet<UsuarioPermisosEntity> UsuarioPermisos { get; set; }

        public DbSet<BitacoraEntity> Bitacora { get; set; }

        #endregion


        #region Relaciones

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // =========================================================
            // USUARIO - EMPLEADO
            // Relación 1 a 1
            // =========================================================

            modelBuilder.Entity<UsuariosEntity>()
                .HasOne(u => u.Empleados)
                .WithOne(e => e.Usuarios)
                .HasForeignKey<UsuariosEntity>(u => u.EmpleadoID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // EMPLEADO - DONANTE
            // Un empleado puede registrar muchos donantes
            // =========================================================

            modelBuilder.Entity<DonantesEntity>()
                .HasOne(d => d.Empleados)
                .WithMany(e => e.Donantes)
                .HasForeignKey(d => d.EmpleadosID)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================================================
            // EVALUACIÓN - DONACIÓN
            // Una evaluación puede estar asociada a una donación
            // Una donación pertenece a una evaluación
            // =========================================================

            modelBuilder.Entity<DonacionesEntity>()
                .HasOne(d => d.EvaluacionDonante)
                .WithMany()
                .HasForeignKey(d => d.EvaluacionDonanteID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // DONACIÓN - PROCESAMIENTO
            // Una donación tiene un procesamiento
            // =========================================================

            modelBuilder.Entity<ProcesamientoDeSangreEntity>()
                .HasOne(p => p.Donaciones)
                .WithOne(d => d.ProcesamientoDeSangre)
                .HasForeignKey<ProcesamientoDeSangreEntity>(
                    p => p.DonacionesID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // PROCESAMIENTO - INVENTARIO
            // Un procesamiento puede generar un registro de inventario
            // =========================================================

            modelBuilder.Entity<InventarioEntity>()
                .HasOne(i => i.Procesamiento)
                .WithOne()
                .HasForeignKey<InventarioEntity>(
                    i => i.ProcesamientoID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // EMPLEADO - INVENTARIO
            // Un empleado puede registrar muchos inventarios
            // =========================================================

            modelBuilder.Entity<InventarioEntity>()
                .HasOne(i => i.Empleado)
                .WithMany(e => e.Inventarios)
                .HasForeignKey(i => i.EmpleadoID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // SOLICITUD - ENTREGA
            // Una solicitud puede tener muchas entregas
            // Una entrega pertenece a una solicitud
            // =========================================================

            modelBuilder.Entity<EntregaEntity>()
                .HasOne(e => e.Solicitud)
                .WithMany(s => s.Entregas)
                .HasForeignKey(e => e.SolicitudID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // INVENTARIO - ENTREGA
            // Un inventario puede ser utilizado en varias entregas
            // =========================================================

            modelBuilder.Entity<EntregaEntity>()
                .HasOne(e => e.Inventario)
                .WithMany()
                .HasForeignKey(e => e.InventarioID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // EMPLEADO - ENTREGA
            // Un empleado puede realizar muchas entregas
            // =========================================================

            modelBuilder.Entity<EntregaEntity>()
                .HasOne(e => e.Empleado)
                .WithMany()
                .HasForeignKey(e => e.EmpleadoID)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // ÍNDICE CÓDIGO DE BOLSA
            // Cada bolsa debe tener un código único
            // =========================================================

            modelBuilder.Entity<InventarioEntity>()
                .HasIndex(i => i.CodigoBolsa)
                .IsUnique();


            // =========================================================
            // ÍNDICE NÚMERO DE SANGRE
            // =========================================================

            modelBuilder.Entity<DonacionesEntity>()
                .HasIndex(d => d.NumeroSangre)
                .IsUnique();

            // =========================================================
            // PRECISIÓN DE CANTIDADES
            // =========================================================

            modelBuilder.Entity<DonacionesEntity>()
                .Property(d => d.CantidadSangre)
                .HasPrecision(10, 2);


            modelBuilder.Entity<ProcesamientoDeSangreEntity>()
                .Property(p => p.VolumenDN)
                .HasPrecision(10, 2);


            // =========================================================
            // PRECISIÓN EVALUACIÓN DEL DONANTE
            // =========================================================

            modelBuilder.Entity<EvaluacionDonanteEntity>()
                .Property(e => e.Peso)
                .HasPrecision(5, 2);


            modelBuilder.Entity<EvaluacionDonanteEntity>()
                .Property(e => e.Temperatura)
                .HasPrecision(5, 2);

            base.OnModelCreating(modelBuilder);

            // Relación opcional Donante -> Muestra
            modelBuilder.Entity<MuestraEntity>()
                .HasOne(m => m.Donante)
                .WithMany()
                .HasForeignKey(m => m.DonanteID)
                .IsRequired(false) // Indica explicitamente que no es obligatoria
                .OnDelete(DeleteBehavior.Restrict);

            // Relación obligatoria Donacion -> Muestra
            modelBuilder.Entity<MuestraEntity>()
                .HasOne(m => m.Donacion)
                .WithMany()
                .HasForeignKey(m => m.DonacionesID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        #endregion



    }


}
