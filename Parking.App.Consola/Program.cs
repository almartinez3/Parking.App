using System;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Consola
{
    class Program
    {
        
        private static IRepositorio _repoPersona = new Repositorio(new Parking.App.Persistencia.AppContext());
        
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");
            AddPerson();
            AddVehiculo();
            buscarPersona(9);

        }

        private static void AddPerson(){
            var pers = new Persona{
                Nombre =" Nestor",
                Apellidos = "Ramirez",
                Genero = Genero.masculino,
                NumeroTelefono = 5798053


            };


            _repoPersona.AddPersona(pers);



        }

        private static void buscarPersona(int idp){
            var person = _repoPersona.GetPersona(idp);

            if( person != null){
                Console.WriteLine("Nombre: "+person.Nombre+" "+person.Apellidos+"\n Genero: "+person.Genero+"\n Telefono: "+person.NumeroTelefono);
            }



        }




        ////////////////////////Vehiculo/////////////

        private static void AddVehiculo(){
            var vehi = new Vehiculo{
                Placa =" SCB-183",
                Tipo = TipoVehiculo.automovil

            };


            _repoPersona.AddVehiculo(vehi);



        }

    

    //////////////////////LOCATIVO//////////////////////////
    }
}
