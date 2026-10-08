using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBancodeSangre.Entities
{
    public class MuestraEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreDonante { get; set; }

        [Required]
        [MaxLength(50)]
        public string ApellidoDonante { get; set; }

        [Required]
        [MaxLength(10)]
        public string TipoSangre { get; set; }

        [Required]
        public DateTime FechaToma { get; set; }

        [Required]
        public DateTime FechaDonacion { get; set; }

        [Required]
        public double CantidadM { get; set; }

        [Required]
        [MaxLength(30)]
        public string Estado { get; set; }

        [Required]
        [MaxLength(300)]
        public string Observacion { get; set; }

        [MaxLength(100)]
        public string Responsable { get; set; }

        [Required]
        [MaxLength(50)]
        public string CodigoMuestra { get; set; }


        // Relación obligatoria con Donación
        [Required]
        public int DonacionesID { get; set; }

        [ForeignKey("DonacionesID")]
        public DonacionesEntity Donacion { get; set; }


        // Relación opcional con Donante (int? permite NULL)
        public int? DonanteID { get; set; }

        [ForeignKey("DonanteID")]
        public DonantesEntity Donante { get; set; }


        // Relación con Análisis
        public ICollection<AnalisisEntity> Analisis { get; set; }
            = new List<AnalisisEntity>();
    }
}

    


