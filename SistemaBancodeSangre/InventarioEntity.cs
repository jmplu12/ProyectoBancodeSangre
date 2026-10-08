using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class InventarioEntity
    {
        public int ID { get; set; }

        // Código único de la bolsa o unidad de sangre
        public string CodigoBolsa { get; set; }

        // Tipo de sangre: A+, A-, B+, B-, AB+, AB-, O+, O-
        public string TipoSangre { get; set; }

        // Cantidad original recibida en ml
        public int CantidadInicial { get; set; }

        // Cantidad que todavía está disponible en ml
        public int CantidadDisponible { get; set; }

        // Fecha en que se realizó la donación
        public DateTime FechaDonacion { get; set; }

        // Fecha en que vence la sangre
        public DateTime FechaVencimiento { get; set; }

        // Disponible, Reservada, Utilizada, Vencida, Descartada
        public string Estado { get; set; }

        // Fecha en que fue registrada en inventario
        public DateTime FechaRegistro { get; set; }

        // Relación con proceamiento de sangre
        public int ProcesamientoID { get; set; }

        public virtual ProcesamientoDeSangreEntity Procesamiento { get; set; }

        // Empleado que registró el ingreso (ahora opcional)
        public int? EmpleadoID { get; set; }
        public virtual EmpleadosEntity Empleado { get; set; }


    }
}
