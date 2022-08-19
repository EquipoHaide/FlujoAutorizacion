using System;
namespace Flujo_Autorizacion.Dominio.Modelo
{
    public class Paso : IPaso
    {
        public int Id { get; set;}

        public int Orden { get; set; }

        public int Rol { get; set; }

        public int TipoRol { get; set; }

        public bool EsFirma { get; set; }
    }
}
