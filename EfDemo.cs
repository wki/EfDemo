using System;
using System.Linq;

namespace EfDemo
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello dnx!");
            
            using (var db = new Db())
            {
                foreach (var person in db.Persons.ToList())
                {
                    Console.WriteLine("{0}: {1}",
                        person.PersonId, person.Name
                    );
                }
            }
        }
    }
}