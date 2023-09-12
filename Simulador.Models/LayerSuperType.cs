using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class LayerSuperType
    {
        public int Id { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Activo { get; set; }
    }
}
