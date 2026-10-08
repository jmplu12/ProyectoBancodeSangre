using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class DonantesEntity
    {
       
            [Key] 
            public int ID { get; set; }

            [Required] 
            [StringLength(50)] // Limita la longitud máxima del campo
            public string Nombre { get; set; }

            [Required]
            [StringLength(50)]
            public string Apellido { get; set; }

            [StringLength(int.MaxValue)] // Permite longitud variable
            public string Sexo { get; set; }

            [Required]
            [StringLength(11)]
            public string Cedula { get; set; }

            [Required]
            [StringLength(10)]
            public string Telefono { get; set; }

            [StringLength(3)]
            public string Edad { get; set; }

            [Required]
            public double PesoKlg { get; set; }

            [StringLength(int.MaxValue)]
            public string TipoDeSangre { get; set; }

            [StringLength(int.MaxValue)]
            public string TipodeDonante { get; set; }

            [Required]
            public DateTime FechaNacimiento { get; set; }

            [Required]
            [StringLength(100)]
            public string Correo { get; set; }

            
            public string Provincia { get; set; }
            public string Municipio { get; set; }
            [Required]
            [StringLength(300)]
            public string Direccion { get; set; }

            //Relaciones entre las entidades. 
            public virtual ICollection<DonacionesEntity> Donaciones { get; set; }

            public virtual ICollection<CitasEntity> Citas { get; set; }

            public virtual ICollection<MuestraEntity> Muestra { get; set; }
            
            public int EmpleadosID { get; set; }
            public virtual  EmpleadosEntity Empleados { get; set; }

        public virtual ICollection<EvaluacionDonanteEntity> EvaluacionesDonantes { get; set; }


    }
}

