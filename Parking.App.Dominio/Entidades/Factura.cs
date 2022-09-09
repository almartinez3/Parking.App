using System;
namespace Parking.App.Dominio
{
    public class Factura
    {
        public int Id {get;set;}
        public DateTime Fecha {get;set;}
        public string Placa {get;set;}
        public TipoVehiculo TipoVehiculo {get;set;}
        public DateTime HoraIngreso {get;set;}
        public DateTime HoraSalida {get;set;}
        public string NumeroPuesto {get;set;}
        public int MontoPagar {get;set;}
        public string Observaciones {get;set;}
    }
}