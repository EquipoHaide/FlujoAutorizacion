using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class SolicitudCondensada : ISolicitudCondensada
    {
        public ICreador QuienCreo { get; set ; }
        public string Folio { get; set; }
        public string Concepto { get; set; }
        public int Estado { get; set; }
        public int IdAutorizacion { get; set; }
        public int Orden { get; set; }
        public int IdRol { get; set; }
    }
}
