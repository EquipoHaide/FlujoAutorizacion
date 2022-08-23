using System;
using System.Collections.Generic;
using System.Text;

namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IPerfilEmpleado
    {
        int Id { get; set; }

        string Nombre { get; set; }
        string ApellidoPaterno { get; set; }
        string ApellidoMaterno { get; set; }

        INivelEmpleado NivelEmpleado { get; set; }

    }
}
