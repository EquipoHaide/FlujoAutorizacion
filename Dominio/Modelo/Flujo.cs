using System;
using System.Collections.Generic;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class Flujo : IFlujo, IModel
    {
        public int Id { get; set; }

        public ITipoEntePublico TipoEntePublico { get; set; }

        public INivelEmpleado NivelEmpleado {get ; set ;}

        public int TipoFlujo { get; set; }

        public List<IPaso> Pasos { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }

   
}
