using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class UsuariosEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(150)]
        public string correo { get; set; }

        [Required]
        [MaxLength(10)]
        public string telefono { get; set; }

        public string nombreUsuario { get; set; }

        [StringLength(100)]
        public string clave { get; set; }
        [Required]
        [StringLength(255)]

        public string Cargo { get; set; }

        [Required]
        public int EmpleadoID { get; set; }

        public EmpleadosEntity Empleados { get; set; }

        /* NUEVO */
        public int IntentosFallidos { get; set; }

        public bool Bloqueado { get; set; }

    }
}
