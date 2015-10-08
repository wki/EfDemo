// using System.Reflection;
using Microsoft.Data.Entity;
// using System.Collections.Generic;

namespace EfDemo
{
    public class Db : DbContext
	{
		//  public Db()
		//  {
		//  }
		
		public DbSet<Person> Persons { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;User Id=postgres;Password=;Database=testdb");
		}
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Anpassunge so möglich, aber derzeit noch nicht viel drin...
			// modelBuilder.* ...
			
			// das ist die umständliche Version
			var person = modelBuilder.Entity<Person>();
			person.ToTable("person");
			person.Property(p => p.PersonId).HasColumnName("personid");
			person.Property(p => p.Name).HasColumnName("name");
			

			// REFLECTION GEHT NICHT SO EINFACH
			// WEIL SO NICHTS ZUR COMPILE-ZEIT BEKANNT IST
						
			//  var entityNames = new [] { "Person" };
			//  
			//  foreach (var entityName in entityNames)
			//  {
			//  	var entity = modelBuilder.Entity(entityName);
			//  	
			//  	System.Console.WriteLine("Entity {0} -> {1}", entityName, entityName.ToLower());
			//  	entity.ToTable(entityName.ToLower());
			//  	
			//  	foreach (var propertyInfo in entity.GetType().GetProperties())
			//  	{
			//  		string propertyName = propertyInfo.Name;
			//  		entity.Property(propertyName);
			//          // hier geht's nicht weiter...
			//  	}
			//  }
		}
	}
	
	public class Person
	{
		public int PersonId { get; set; }
		
		public string Name { get; set; }
	}
}
