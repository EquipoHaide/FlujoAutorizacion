using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;
using Dominio = Flujo_Autorizacion.Dominio;

namespace Flujo_Autorizacion.Aplicacion
{
    public class ServicioConfiguracionFlujo<T> : IServicioConfiguracionFlujo<T> where T : Paso
    {

        Dominio.ServicioConfiguracionFlujo<T> servicio = new Dominio.ServicioConfiguracionFlujo<T>();
        Dominio.IServicioConfiguracionFlujo<T> ServicioConfing;

        public ServicioConfiguracionFlujo() {

            ServicioConfing = (Dominio.IServicioConfiguracionFlujo<T>)servicio;
        }

        /*public Respuesta<bool> Validar(IFlujo flujo)
        {
            
         
            var respuesta = ServicioConfing.ValidarFlujo(flujo);

            if (!respuesta.Contenido)
                return new Respuesta<bool>("La información de el flujo esta incomplenta", "TAG");

            return new Respuesta<bool> (true);
        }*/


        public void Consultar(IConsultaFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();
        }

        public Respuesta<bool> Crear(Flujo<T> flujo)
        {

            var respuesta = ServicioConfing.ValidarFlujo(flujo);

            if (!respuesta.Contenido)
                return new Respuesta<bool>("La información de el flujo esta incomplenta", "TAG");

            return new Respuesta<bool>(respuesta.Contenido);
        }

        public Respuesta<bool> Modificar(Flujo<T> flujo,bool esRepetido)
        {
            if (esRepetido)
                return new Respuesta<bool>("El flujo ya existe", "TAG");
            
            var respuesta = ServicioConfing.ValidarFlujo(flujo);

            if (!respuesta.Contenido)
                return new Respuesta<bool>("La información de el flujo esta incomplenta", "TAG");

            return new Respuesta<bool>(respuesta.Contenido);
        }

    }
}
