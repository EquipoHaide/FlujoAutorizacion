using Flujo_Autorizacion.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioFlujoAccionCancelar
    {


        void Cacenlar(IFlujo flujo, ISolicitudCondensada Solicitud, string subjectId);

      

    }
}
