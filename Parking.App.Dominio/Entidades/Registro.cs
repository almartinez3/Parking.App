using System;
namespace Parking.App.Dominio
{
    public class Registro
    {
        public int Id {get;set;}
        public DateTime HoraIngreso {get;set;}
        public DateTime HoraSalida {get;set;}
        public string Placa {get;set;}
        public TipoVehiculo TipoVehiculo {get;set;}
        public string NumeroPuesto {get;set;}
        public string Observaciones {get;set;}
    }
}