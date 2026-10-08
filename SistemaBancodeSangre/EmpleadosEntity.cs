using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
     public class EmpleadosEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }
        
        public DateTime FechaNac {  get; set; }

        public string Edad {  get; set; }
        public string sexo { get; set; }
        public string cedula { get; set; }
        [Required]
        [MaxLength(10)]
        public string telefono { get; set; }
        [Required]
        [MaxLength(100)]
        public string email { get; set; }
        public bool estado { get; set; }
        [Required]
        [MaxLength(60)]
        public string cargo { get; set;}
        [Required]
        [MaxLength(30)]
        public string provincia { get; set; }
        [Required]
        [MaxLength(300)]
        public string Municipio { get; set; }   
        public string dirreccion { get; set; }
     
        //public DateTime fecha_ingreso {  get; set; }
        public virtual UsuariosEntity Usuarios { get; set; }
        public ICollection<EntregaEntity> Entregas { get; set; }

        public virtual ICollection<DonantesEntity> Donantes { get; set; }

        public virtual ICollection<InventarioEntity> Inventarios { get; set; }
        public virtual ICollection<EvaluacionDonanteEntity> EvaluacionesDonantes { get; set; }
    }

}
