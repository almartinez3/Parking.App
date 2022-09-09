using System.Collections.Generic;
using Parking.App.Dominio;


namespace Parking.App.Persistencia

{

public interface IRepositorio{


    IEnumerable<Persona> GetAllPersona();

    Persona AddPersona(Persona perso);

    Persona UpdatePersona (Persona perso);
    void DeletePersona(int idpersona);

    Persona GetPersona (int idpersona);


    IEnumerable<Vehiculo> GetAllVehiculo();

    Vehiculo AddVehiculo(Vehiculo vehic);

    //Persona UpdatePersona (Persona vehic);
   // void DeletePersona(int idvehiculo);

    Vehiculo GetVehiculo (int idvehiculo);




}


}