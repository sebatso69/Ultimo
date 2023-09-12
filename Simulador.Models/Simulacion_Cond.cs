using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class Simulacion_Cond : LayerSuperType
    {
        [NotMapped]
        public Condicion_Beneficio Condicion_Beneficio { get; set; }
        public bool Cumple_Condicion { get; set; }
    }
}
