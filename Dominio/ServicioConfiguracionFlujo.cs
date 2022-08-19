using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Dominio.Enumerable;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Dominio
{
    public class ServicioConfiguracionFlujo : IServicioConfiguracionFlujo
    {
        const string TAG = "Flujo_Autorizacion.Dominio";
        public Respuesta<bool> ValidarFlujo(IFlujo flujo)
        {
            //Valida que el objeto no este vacio
            if (flujo == null)
                return new Respuesta<bool>("El flujo de autorizacion es requerido", TAG);


            if (flujo.TipoEntePublico == null)
                return new Respuesta<bool>("El ente publico es requerido", "TAG");

            if (flujo.TipoFlujo == (int)TipoFlujo.Particular) {
                if (flujo.NivelEmpleado == null)
                    return new Respuesta<bool>("El nivel del empleado es requerido para un flujo particular.", "TAG");
            }

            //Aplicamos la validacion con respecto a los pasos.
            if (flujo.Pasos == null || flujo.Pasos.Count() <= 0)
                return new Respuesta<bool>("La lista de pasos es requerida.", "TAG");

            foreach (var item in flujo.Pasos)
             {
                 var respuestaPaso = this.ValidarPaso(item);

                 if(!respuestaPaso.Contenido)
                     return new Respuesta<bool>("La información de los pasos esta incompleta", "TAG");
             }

            if (!this.EsRepetido(flujo.Pasos))
                return new Respuesta<bool>("La lista de pasos del flujo No deben de repetirse", TAG);

            if (!this.EsConsecutivo(flujo.Pasos))
                return new Respuesta<bool>("La lista de pasos del flujo debe ser consecutivo.", TAG);


            return new Respuesta<bool>(true);
        }

        public Respuesta<bool> ValidarPaso(IPaso paso) {

            if(paso.Orden <= 0)
                return new Respuesta<bool>("El orden debe ser mayor a 0", "");

            if (paso.Rol <= 0)
                return new Respuesta<bool>("El rol es requerido", "");

            if (paso.TipoRol <= 0)
                return new Respuesta<bool>("El tipo rol es requerido", "");

            return new Respuesta<bool>(true);
        }


        private bool EsRepetido(List<Paso> paso)
        {
            return paso.GroupBy(x => x.Orden).Any(g => g.Count() > 1);
        }

        private bool EsConsecutivo(List<Paso> paso) {

            int index = 1;
            var pasosOrdenados = paso.OrderBy(x => x.Orden);
            foreach (var item in pasosOrdenados) 
            {
                if (item.Orden != index)
                {
                    return false;
                }

                index++;
            }
            return true;
        }

     
       
    }
}
