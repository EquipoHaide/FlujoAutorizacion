using Flujo_Autorizacion.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Aplicacion
{
    //  sealed
    public class ServicioFlujoAccionDevolver : IServicioFlujoAccionDevolver
    {
        public void Devolver(IFlujo flujo, ISolicitudCondensada Solicitud, bool esInicio = false)
        {
            throw new NotImplementedException();
        }
    }
}
