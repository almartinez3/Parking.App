using System;
namespace Parking.App.Dominio
{
    public class Ticket
    {
        public int Id {get;set;}
        public DateTime Fecha {get;set;}
        public string Placa {get;set;}
        public TipoVehiculo TipoVehiculo {get;set;}
        public DateTime HoraIngreso {get;set;}
        public string Observaciones {get;set;}
    }
}