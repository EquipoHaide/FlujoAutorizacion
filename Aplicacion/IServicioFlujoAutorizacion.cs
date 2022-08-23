using Flujo_Autorizacion.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioFlujoAutorizacion
    {


        void Autorizar(IFlujo flujo, ISolicitudCondensada Solicitud, string subjectId);

        void Devolver(bool esInicio=false);

        void Cancelar();

    }
}
