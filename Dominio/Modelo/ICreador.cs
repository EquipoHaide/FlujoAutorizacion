using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface ICreador
    {
        ITipoEntePublico TipoEntePublico { get; set; }

        IEntePublico EntePublico { get; set; }

        IPerfilEmpleado PerfilEmpleado { get; set; }

        

    }
}
