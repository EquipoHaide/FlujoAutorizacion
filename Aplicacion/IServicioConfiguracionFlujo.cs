using System;
using System.Collections.Generic;
using System.Text;
using Flujo_Autorizacion.Dominio.Modelo;
using Flujo_Autorizacion.Transversal;

namespace Flujo_Autorizacion.Aplicacion
{
    public interface IServicioConfiguracionFlujo
    {


        Respuesta<bool> Validar(IFlujo flujo);

        public void Consultar(IConsultaFlujo flujo, string subjectId);


        public void Crear(IFlujo flujo, string subjectId);

        public void Modificar(IFlujo flujo, string subjectId);

        public void Eliminar(IFlujo flujo, string subjectId);

        public List<ITipoEntePublico> obtenerEntesPublicos(int anioFiscal, string subjectId);

        public List<INivelEmpleado> obtenerNiveles(string subjectId);


    }
}
