using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class EntregaEntity
    {
        [Key]
        public int ID { get; set; }

        // Solicitud relacionada
        [Required]
        public int SolicitudID { get; set; }

        public virtual SolicitudEntity Solicitud { get; set; }

        // Inventario / bolsa que será entregada
        [Required]
        public int InventarioID { get; set; }

        public virtual InventarioEntity Inventario { get; set; }

        // Cantidad entregada en ml
        [Required]
        public int CantidadEntregada { get; set; }

        // Tipo de sangre
        [Required]
        [MaxLength(5)]
        public string TipoDeSangre { get; set; }

        // Fecha y hora de entrega
        [Required]
        public DateTime FechaEntrega { get; set; }

        // Empleado responsable
        [Required]
        public int EmpleadoID { get; set; }

        public virtual EmpleadosEntity Empleado { get; set; }
    }
}

