using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class AnalisisEntity
    {
        [Key]
        public int ID { get; set; }

        public bool Vhsida { get; set; }
        public bool Diabetes { get; set; }

        public bool hepatitisBoC { get; set; }

        public bool HipertensionAlterial { get; set; }

        public bool insuficienciaCardiaca { get; set; }

        public bool Cancer { get; set; }

        public bool Arritmias { get; set; }

        public bool Hemofilia { get; set; }

        public bool chagas { get; set; }
        public DateTime fechaAnalisis { get; set; }
        public string estado { get; set; }
        [Required]
        [MaxLength(50)]

        public string Tipodesangre { get; set; }

        [Required]
        [MaxLength(50)]
        public string analista { get; set; }

        //Relaciones 
        public int MuestraID { get; set; }
        public MuestraEntity Muestra { get; set; }

       
       //public virtual ProcesamientoDeSangreEntity Proceso { get; set; }

    }
}
