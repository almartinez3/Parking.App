using System.Collections.Generic;
using System.Linq;
using Parking.App.Dominio;


namespace Parking.App.Persistencia{

    public class Repositorio : IRepositorio

    {   
        private readonly AppContext appcox;


        public Repositorio(AppContext appContext){

            appcox = appContext;

        }


        Persona IRepositorio.AddPersona(Parking.App.Dominio.Persona perso){


            var agregarPersona = appcox.Personas.Add(perso);
            appcox.SaveChanges();

             return agregarPersona.Entity; // -----
        }

        //eliminar persona

        void IRepositorio.DeletePersona(int idpersona){
             var encontrarPersona = appcox.Personas.FirstOrDefault(p => p.Id == idpersona);

             if(encontrarPersona == null) {

                return;

             }

         appcox.Personas.Remove(encontrarPersona);
         appcox.SaveChanges();
        }

        //Llamr a todos lo datos de la tabla
        IEnumerable<Persona> IRepositorio.GetAllPersona(){

            return appcox.Personas;
        }

        //Llamar a una sola persona
        Persona IRepositorio.GetPersona(int idpersona){
            return appcox.Personas.FirstOrDefault(p => p.Id == idpersona);
        }

        //Actualizar

        Persona IRepositorio.UpdatePersona(Parking.App.Dominio.Persona perso){

            var PersonaEncontrada = appcox.Personas.FirstOrDefault(p => p.Id == perso.Id);

            if(PersonaEncontrada != null){

                PersonaEncontrada.Nombre = perso.Nombre;
                appcox.SaveChanges();
            }

            return PersonaEncontrada;
        }

        ////////////////////////////////////Vehiculo//////////////////


        Vehiculo IRepositorio.AddVehiculo(Parking.App.Dominio.Vehiculo vehic){


            var agregarVehiculo = appcox.Vehiculos.Add(vehic);
            appcox.SaveChanges();

             return agregarVehiculo.Entity; // -----
        }

        Vehiculo IRepositorio.GetVehiculo(int idvehiculo){
            return appcox.Vehiculos.FirstOrDefault(ve => ve.Id == idvehiculo);
        }

        IEnumerable<Vehiculo> IRepositorio.GetAllVehiculo(){

            return appcox.Vehiculos;
        }


///////////////////////////////Locativo///////////////////////////////





        
    
    }


}