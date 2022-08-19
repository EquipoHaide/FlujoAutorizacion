using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    class TipoEntePublico : ITipoEntePublico
    {
        public int Id { get; set ; }
        public string Nombre { get; set; }
    }
}
