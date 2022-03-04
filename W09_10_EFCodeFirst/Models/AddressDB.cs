using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace W09_10_EFCodeFirst.Models
{
    public class AddressDB : DbContext
    {
        public AddressDB()
        {
            CreateDB cdb = new CreateDB();
            Database.SetInitializer(cdb);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> Persons { get; set; }



        public class CreateDB : CreateDatabaseIfNotExists<AddressDB>
        {
            protected override void Seed(AddressDB context)
            {
                for (int i = 0; i < 10; i++)
                {
                    Person person = new Person();
                    person.Name = FakeData.NameData.GetFullName();
                    person.Age = FakeData.NumberData.GetNumber(15, 70);
                    context.Persons.Add(person);

                    Random rnd = new Random();
                    int addressCount = rnd.Next(1,10);

                    for (int j = 0; j < addressCount; j++)
                    {
                        Address address = new Address();
                        address.Description = FakeData.PlaceData.GetAddress();
                        address.Person = person;
                        context.Addresses.Add(address);
                    }
                }

                context.SaveChanges();
            }
        }
    }
}