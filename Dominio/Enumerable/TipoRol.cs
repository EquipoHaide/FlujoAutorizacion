using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Enumerable
{
    public enum TipoRol
    {
        [Description("General")]
        General = 1,
        [Description("Especifico")]
        Especifico = 2,
       
    }
}
