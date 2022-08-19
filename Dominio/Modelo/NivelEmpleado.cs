using System;
namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class NivelEmpleado : INivelEmpleado
    {
        public int Id { get; set; }

        public double Nivel { get; set; }
    }     
}
