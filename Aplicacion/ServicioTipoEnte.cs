using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Aplicacion
{
    public class ServicioTipoEnte : IServicioTipoEnte
    {
        public List<ITipoEntePublico> obtenerEntesPublicos(int anioFiscal, string subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
