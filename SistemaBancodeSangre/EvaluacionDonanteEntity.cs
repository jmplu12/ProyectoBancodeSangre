using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancodeSangre.Entities
{
    public class EvaluacionDonanteEntity
    {
        public int ID { get; set; }

        // Donante que está siendo evaluado
        public int DonanteID { get; set; }

        public virtual DonantesEntity Donante { get; set; }


        // Empleado que realiza la evaluación
        public int EmpleadoID { get; set; }

        public virtual EmpleadosEntity Empleado { get; set; }


        // Fecha de la evaluación
        public DateTime FechaEvaluacion { get; set; }


        // Datos de evaluación
        public decimal Peso { get; set; }

        public string PresionArterial { get; set; }

        public decimal Temperatura { get; set; }


        // Cuestionario
        public bool TieneEnfermedad { get; set; }

        public bool TomaMedicamentos { get; set; }

        public bool TieneSintomas { get; set; }

        public bool HaTenidoCirugia { get; set; }

        public bool HaDonadoAnteriormente { get; set; }


        // Observaciones del empleado
        public string Observaciones { get; set; }


        // APTO / NO APTO / PENDIENTE
        public string Resultado { get; set; }


        // Activa / Finalizada
        public string Estado { get; set; }
    }
}
