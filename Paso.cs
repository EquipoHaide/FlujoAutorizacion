using System;
using Flujo_Autorizacion.Dominio.Modelo;

namespace Flujo_Autorizacion
{
    public class Paso : IPaso
    {
        public int Id { get; set; }
        public int Orden { get; set; }
        public int Rol { get; set; }
        public int TipoRol { get; set; }
        public bool EsFirma { get; set; }

        public string Descripcion { get; set; }


        public bool IsValid()
        {
            if (Descripcion is null)
                return false;

            return true;
        }
    }
}
