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

        public Respuesta<bool> Validar(IFlujo flujo)
        {


            var respuesta = ServicioConfing.ValidarFlujo(flujo);

            if (!respuesta.Contenido)
                return new Respuesta<bool>("La información de el flujo esta incomplenta", "TAG");

            return new Respuesta<bool>(true);
        }


        public void Crear(IFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();
        }

        public void Modificar(IFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();

        }


        public void Eliminar(IFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();
        }


        public void Consultar(IConsultaFlujo flujo, string subjectId)
        {
            throw new NotImplementedException();
        }

        public List<ITipoEntePublico> obtenerEntesPublicos(int anioFiscal, string subjectId)
        {
            throw new NotImplementedException();
        }

        public List<INivelEmpleado> obtenerNiveles(string subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
