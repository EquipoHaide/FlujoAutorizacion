using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface ISolicitudCondensada
    {
        ICreador QuienCreo { get; set; }

        string Folio { get; set; }
        
        string Concepto { get; set; }

        int Estado { get; set; }

        int IdAutorizacion { get; set; }

        int Orden { get; set; }

        int IdRol { get; set; }

    }
}
