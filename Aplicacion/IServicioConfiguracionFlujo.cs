using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioConfiguracionFlujo
    {


        Respuesta<bool> Validar(List<IFlujo> flujo);

        public void Consultar(IConsulta flujo, string subjectId);


        public Respuesta<List<IFlujo>> Crear(List<IFlujo> flujos, string subjectId);

        public void Modificar(IFlujo flujo, string subjectId);

        public void Eliminar(IFlujo flujo, string subjectId);
    }
}
