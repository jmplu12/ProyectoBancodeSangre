using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class ProcesamientoDeSangreEntity
    {
        [Key]
        public int ID { get; set; }


        // ============================================
        // DATOS DEL PROCESAMIENTO
        // ============================================

        [Required]
        [MaxLength(50)]
        public string EstadoProceso { get; set; }


        [Required]
        public DateTime FechaProceso { get; set; }


        [Required]
        [MaxLength(10)]
        public string TipoDeSangre { get; set; }


        [Required]
        [Range(0.01, 10000)]
        public double VolumenDN { get; set; }


        [MaxLength(50)]
        public string Almacenado { get; set; }


        [Required]
        [MaxLength(150)]
        public string Responsable { get; set; }


        [Required]
        [MaxLength(50)]
        public string NumeroSangre { get; set; }



        // ============================================
        // COMPONENTES SANGUÍNEOS
        // ============================================

        public bool ConcentradoGlobulosRojos { get; set; }

        public bool Plasma { get; set; }

        public bool Plaquetas { get; set; }



        // ============================================
        // RELACIÓN CON DONACIÓN
        // ============================================

        [Required]
        public int DonacionesID { get; set; }


        [ForeignKey(nameof(DonacionesID))]
        public virtual DonacionesEntity Donaciones { get; set; }



        // ============================================
        // RELACIÓN CON MUESTRA
        // ============================================

        public int? MuestraID { get; set; }


        [ForeignKey(nameof(MuestraID))]
        public virtual MuestraEntity Muestra { get; set; }



        // ============================================
        // RELACIÓN CON ANÁLISIS
        // ============================================

        public int? AnalisisID { get; set; }


        [ForeignKey(nameof(AnalisisID))]
        public virtual AnalisisEntity Analisis { get; set; }

    }
}