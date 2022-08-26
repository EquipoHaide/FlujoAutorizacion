using Flujo_Autorizacion.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Flujo_Autorizacion.Dominio.Enumerable;

namespace Flujo_Autorizacion.Aplicacion
{
    public class ServicioFlujoAutorizacion : IServicioFlujoAccionAutorizar
    {
        

        public void Autorizar(IFlujo flujo, ISolicitudCondensada Solicitud, string subjectId)
        {
            //Aplicar las validaciones basicas

            //Aplicar las validaciones respecto a los permisos sobre los roles

            var pasos = flujo.Pasos;

            var pasoAutorizar = pasos.Find(p=>p.Orden == Solicitud.Orden);

            int ultimoPaso = pasos.OrderByDescending(p => p.Orden).FirstOrDefault().Orden;
            
            //si es el ultimo paso
            if (ultimoPaso == pasoAutorizar.Orden) {
                Solicitud.Estado = (int)EstadoSolicitud.Autorizado;
                
            }
            else
            {
                var pasoSiguiente = pasos.Find(p => p.Orden == Solicitud.Orden+1);
                Solicitud.Estado = (int)EstadoSolicitud.Pendiente;
                Solicitud.IdRol = pasoSiguiente.Rol;
                Solicitud.Orden = pasoSiguiente.Orden;

            }


        }

        /*
        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Devolver(bool esInicio = false)
        {
            throw new NotImplementedException();
        }

        */
    }
}
