using System;
using System.Collections.Generic;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class Flujo : IFlujo
    {
        public int Id { get; set; }

        public ITipoEntePublico TipoEntePublico { get; set; }

        public INivelEmpleado NivelEmpleado {get ; set ;}

        public List<Paso> Pasos { get; set; }
        public int TipoFlujo { get; set; }
        
    }
}
