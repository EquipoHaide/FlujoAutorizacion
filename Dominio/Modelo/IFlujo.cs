using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IFlujo
    {

        ITipoEntePublico TipoEntePublico { get; set; }

        INivelEmpleado NivelEmpleado { get; set; }

        List<IPaso> Pasos { get; set; }

        int TipoFlujo { get; set; }

        bool IsValid();
     
    }
}
