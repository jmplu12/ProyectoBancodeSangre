using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class BitacoraEntity
    {
        [Key]
        public int IdBitacora { get; set; }

        [Required]
        public int UsuarioID { get; set; }

        [MaxLength(120)]
        public string NombreUsuario { get; set; }

        [MaxLength(60)]
        public string Cargo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Accion { get; set; }

        [MaxLength(60)]
        public string Entidad { get; set; }

        public int? EntidadId { get; set; }

        public string Detalle { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
