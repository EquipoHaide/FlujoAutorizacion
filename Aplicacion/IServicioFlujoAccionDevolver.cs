using Flujo_Autorizacion.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioFlujoAccionDevolver
    {

        void Devolver(IFlujo flujo, ISolicitudCondensada Solicitud,  bool esInicio=false);

    }
}
