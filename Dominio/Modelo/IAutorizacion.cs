using System;
namespace Flujo_Autorizacion.Dominio.Modelo
{
    public interface IAutorizacion
    {
        int Id { get; set; }

        int IdConfiguracionFlujo { get; set; }

        int Orden { get; set; }
        int IdRol { get; set; }

        //Se refiere al seguimiento, de momento comentado por que los apps de deberan de aplicar el seguimiento
        //IdUsuarioOperacion
        //FechaOperacio

        string Sello { get; set; }

        int Estado { get; set; }
    }

}
