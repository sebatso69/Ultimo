using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class Simulacion : LayerSuperType
    {
        [NotMapped]
        public int Rut { get; set; }
        public bool Cumple { get; set; }
        public DateTime Fecha_Consulta { get; set; }
    }
}
