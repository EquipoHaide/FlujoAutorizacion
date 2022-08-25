using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;
using Dominio = Flujo_Autorizacion.Dominio;

namespace Flujo_Autorizacion.Aplicacion
{
    public class ServicioConfiguracionFlujo : IServicioConfiguracionFlujo
    {

        Dominio.ServicioConfiguracionFlujo servicio = new Dominio.ServicioConfiguracionFlujo();
        Dominio.IServicioConfiguracionFlujo ServicioConfing;

        public ServicioConfiguracionFlujo()
        {

            ServicioConfing = servicio;
        }

        public Respuesta<bool> Validar(List<IFlujo> flujo)
        {


            var respuesta = ServicioConfing.ValidarFlujo(flujo);

            if (!respuesta.Contenido)
                return new Respuesta<bool>(respuesta.Mensaje, "TAG");

            return new Respuesta<bool>(true);
        }


        public Respuesta<List<IFlujo>> Crear(List<IFlujo> flujos, string subjectId)
        {
           
            var respuesta = this.Validar(flujos);

            if (respuesta.EsError)
                return new Respuesta<List<IFlujo>>(respuesta.Mensaje, respuesta.TAG);

            return new Respuesta<List<IFlujo>>(flujos);
        }

        public void Modificar(IFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();

        }


        public void Eliminar(IFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();
        }


        public void Consultar(IConsulta flujo, string subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
