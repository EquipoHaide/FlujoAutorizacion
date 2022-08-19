using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IPaso
    {

        int Id { get; set; }

        int Orden { get; set; }

        int Rol { get; set; }

        int TipoRol { get; set; }

        bool EsFirma { get; set; }
    }
}
