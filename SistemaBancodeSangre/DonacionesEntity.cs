using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class DonacionesEntity
    {
        [Key]
        public int ID { get; set; }


        // ==========================================
        // DATOS DEL DONANTE
        // ==========================================

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(3)]
        public string TipoDeSangre { get; set; }


        // ==========================================
        // DATOS DE LA DONACIÓN
        // ==========================================

        [Required]
        public int CantidadSangre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Envase { get; set; }

        [Required]
        public DateTime FechaDonacion { get; set; }

        [Required]
        [MaxLength(200)]
        public string Proposito { get; set; }

        [Required]
        [MaxLength(100)]
        public string Analista { get; set; }

        [Required]
        [MaxLength(50)]
        public string NumeroSangre { get; set; }


        // ==========================================
        // RELACIÓN CON DONANTE
        // ==========================================

        [Required]
        public int DonanteID { get; set; }

        [ForeignKey("DonanteID")]
        public virtual DonantesEntity Donante { get; set; }


        // ==========================================
        // RELACIÓN CON EVALUACIÓN DEL DONANTE
        // ==========================================
        public int? EvaluacionDonanteID { get; set; }

        [ForeignKey("EvaluacionDonanteID")]
        public virtual EvaluacionDonanteEntity EvaluacionDonante { get; set; }

        // ==========================================
        // RELACIÓN CON PROCESAMIENTO
        // ==========================================

        public virtual ProcesamientoDeSangreEntity ProcesamientoDeSangre { get; set; }
    }
}