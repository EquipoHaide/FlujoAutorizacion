using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Enumerable
{
    public enum TipoFlujo
    {
        [Description("Predeterminado")]
        Predeterminado = 1,
        [Description("Particular")]
        Particular = 2,
       
    }
}
