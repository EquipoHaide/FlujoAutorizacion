using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioNivelEmpleado
    {

        public List<INivelEmpleado> obtenerNiveles(string subjectId);


    }
}
