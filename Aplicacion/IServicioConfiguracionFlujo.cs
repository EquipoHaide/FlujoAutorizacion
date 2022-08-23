using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioConfiguracionFlujo
    {
        //Flujo Flujo { get; set; }

        void Consultar(IConsultaFlujo flujo, string subjectId);

        Respuesta<bool> Crear(IFlujo flujo);

        Respuesta<bool> Test(IFlujo flujo);


        Respuesta<bool> Modificar(IFlujo flujo, bool esRepetido);

    }
}
