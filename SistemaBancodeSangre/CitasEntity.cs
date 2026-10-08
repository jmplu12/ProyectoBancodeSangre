using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class CitasEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(150)]
        public string NombreDonante {  get; set; }
        public DateTime fechaCita { get; set; }
        [Required]
        [MaxLength(150)]
        public string Correo {  get; set; }
        [Required]
        [MaxLength(300)]
        public string Descripcion { get; set; }

        //Relaciones 
        public int DonantesID { get; set; }   
        public DonantesEntity DonantesEntity { get; set; }
        //fecha limite y un estado. atributos añadidos. Donde se recive esa cita. fecha de registro.
    }
}
