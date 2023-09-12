using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class Beneficio : LayerSuperType
    {
        public List<Condicion_Beneficio> Id_Condicion_Beneficios { get; set; }
    }
}
