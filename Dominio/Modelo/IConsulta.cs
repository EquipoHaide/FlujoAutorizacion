using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IConsulta
    {
        //filtro de busqueda de una configuracion de flujo, que pueder ser por el nombre del Tipo Ente o el Nivel del Empleado
        public string Query { get; set; }
       
        public int Pagina { get; set; }
        public int ElementosPorPagina { get; set; }

    }
}
