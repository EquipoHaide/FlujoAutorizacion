using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioAntesDeAutorizar
    {
        //PENDIENTE NO SE SI ASI DEBA DE QUEDAR.
        //CREO Q ESTE METODO DEBIERA RECIBIR UNA FUNC COMO PARAMETRO, PARA QUE POSTERIOEMENTE YO SOLO LLAME A SU METODO INVOKE.
        public void ejecutarAntesDeAutorizacion();
        
        
    }
}
