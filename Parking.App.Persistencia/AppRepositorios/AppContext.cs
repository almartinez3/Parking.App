using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;


namespace Parking.App.Persistencia
{
	public class AppContext : DbContext
	{
		public DbSet<Persona> Personas {get;set;}
		public DbSet<Administrador> Administradores {get;set;}
		public DbSet<Vigilante> Vigilantes {get;set;}
		public DbSet<Cliente> Clientes {get;set;}
		public DbSet<Locativo> Locativos {get;set;}
		public DbSet<Puesto> Puestos {get;set;}
		public DbSet<Vehiculo> Vehiculos {get;set;}
		public DbSet<Ticket> Tickets {get;set;}
		public DbSet<Factura> Facturas {get;set;}
		public DbSet<Registro> Registros {get;set;}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; initial catalog =ParkingData");
			}
		}
	}

}
