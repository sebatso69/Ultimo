using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class Condicion_Beneficio :LayerSuperType
    {
        public Beneficio Beneficio { get; set; }
        public Condicion Condicion { get; set; }
        public List<Simulacion_Cond> Simulacion_Conds { get; set; }
    }
}
