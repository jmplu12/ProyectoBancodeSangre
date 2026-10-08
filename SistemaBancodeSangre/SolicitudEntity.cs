
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class SolicitudEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string solicitante { get; set; }

        [Required]
        public int cantidad { get; set; }

        [Required]
        [MaxLength(50)]
        public string medico { get; set; }

        [Required]
        public DateTime fechaDeSolicitud { get; set; }

        [MaxLength(100)]
        public string hospital { get; set; }

        [MaxLength(50)]
        public string exequatur { get; set; }

        [MaxLength(30)]
        public string prioridad { get; set; }

        [Required]
        [MaxLength(200)]
        public string proposito { get; set; }

        [MaxLength(300)]
        public string direccion { get; set; }

        [MaxLength(300)]
        public string motivo { get; set; }

        [Required]
        [MaxLength(5)]
        public string tipoDeSangresolicitada { get; set; }

        public string cartaMedica { get; set; }

        [MaxLength(30)]
        public string estadoSolicitud { get; set; }

        // Relaciones
        public ICollection<EntregaEntity> Entregas { get; set; }
    }
}
