using System;
using System.Collections.Generic;
using Flujo_Autorizacion.Aplicacion;
using Flujo_Autorizacion.Dominio.Enumerable;
using Flujo_Autorizacion.Dominio.Modelo;

namespace Flujo_Autorizacion
{
   
    class Program 
    {
        static void Main(string[] args)
        {

            IServicioConfiguracionFlujo servicioConfigFlujo = new ServicioConfiguracionFlujo();
            List<IFlujo> misFlujos = new List<IFlujo>();
            //Mis flujos a crear 
            var flujoPredeterminado = new Flujo() {
                NivelEmpleado = new NivelEmpleado() { Nivel = 7.2 },
                Nombre = "Mi flujo predeterminado",
                TipoEntePublico = new TipoEntePublico() { Nombre ="Organismos Centralizados"},
                TipoFlujo = (int)TipoFlujo.Predeterminado       

            };

            flujoPredeterminado.Pasos = new List<IPaso>();
            flujoPredeterminado.Pasos.Add(new Paso() { Orden=1, Descripcion="paso1", EsFirma=true, Rol = 1, TipoRol=(int)TipoRol.General});
            flujoPredeterminado.Pasos.Add(new Paso() { Orden = 2, Descripcion = "paso1", EsFirma = true, Rol = 1, TipoRol = (int)TipoRol.General });

            misFlujos.Add(flujoPredeterminado);
            misFlujos.Add(flujoPredeterminado);
            //var respuesta = servicioConfigFlujo.Crear(misFlujos, "mi usuario");

            ServicioFlujoAutorizacionViaticos sfv = new ServicioFlujoAutorizacionViaticos();
            //sfv.Autorizar(flujoPredeterminado, new SolicitudCondensada(), "mi usuario");
            


            //if (respuesta.EsError)
            //    Console.WriteLine(respuesta.Mensaje);


        }

       

    }

  
   
}
