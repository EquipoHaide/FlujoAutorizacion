using System;
using System.Collections.Generic;
using Flujo_Autorizacion.Dominio.Modelo;

namespace Flujo_Autorizacion
{
    public class Flujo : IFlujo, IModel
    {
        public int Id { get; set; }
        public ITipoEntePublico TipoEntePublico { get; set; }
        public INivelEmpleado NivelEmpleado { get; set; }
        public List<Dominio.Modelo.IPaso> Pasos { get; set; }
        public int TipoFlujo { get; set; }


        public string Nombre { get; set; }
     
        public bool IsValid()
        {
            if (Nombre is null)
               return false;
            
            return true;
        }
    }
}
