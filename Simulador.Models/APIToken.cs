using System;

namespace Simulador.Models
{
    public class APIToken : LayerSuperType
    {
        public Guid ApiKey { get; set; }
        public string Descripcion { get; set; }
    }
}