using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IFlujo
    {
        int Id { get; set; }

        ITipoEntePublico TipoEntePublico { get; set; }

        INivelEmpleado NivelEmpleado { get; set; }

        List<Paso> Pasos { get; set; }

        int TipoFlujo { get; set; }
    }
}
