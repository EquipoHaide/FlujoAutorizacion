using System;
namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IEntePublico
    {
        int Id { get; set; }

        string Nombre { get; set; }

        ITipoEntePublico TipoEntePublico { get; set; }
    }

}
