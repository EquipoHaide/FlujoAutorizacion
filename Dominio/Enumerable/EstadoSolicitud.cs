using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Enumerable
{
    public enum EstadoSolicitud
    {
       
        [Description("Pendiente")]
        Pendiente = 1,
        [Description("Autorizado")]
        Autorizado = 2,
        [Description("Devuelto")]
        Devuelto = 3,
        [Description("DevueltoInicio")]
        DevueltoInicio = 4,
        [Description("Cancelado")]
        Cancelado = 5,

    }
}
