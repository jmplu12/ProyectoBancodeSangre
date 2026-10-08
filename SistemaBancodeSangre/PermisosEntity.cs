using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class PermisosEntity
    {
       
            [Key]
            public int ID { get; set; }

            [Required]
            [StringLength(100)]
            public string NombrePermiso { get; set; }

            public virtual ICollection<UsuarioPermisosEntity> UsuarioPermisos { get; set; }
        
    }
}
