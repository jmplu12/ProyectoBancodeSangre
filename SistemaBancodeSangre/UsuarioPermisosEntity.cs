using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class UsuarioPermisosEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]
        public virtual UsuariosEntity Usuario { get; set; }

        [Required]
        public int PermisoID { get; set; }

        [ForeignKey("PermisoID")]
        public virtual PermisosEntity Permiso { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
