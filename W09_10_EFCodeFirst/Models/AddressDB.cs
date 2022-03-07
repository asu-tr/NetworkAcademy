using System;
using System.Data.Entity;
using System.Threading;

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
        public DbSet<Person> People { get; set; }


        public class CreateDB : CreateDatabaseIfNotExists<AddressDB>
        {
            protected override void Seed(AddressDB context)
            {
                for (int i = 0; i < 10; i++)
                {
                    Person person = new Person
                    {
                        Name = FakeData.NameData.GetFullName(),
                        Age = FakeData.NumberData.GetNumber(15, 70)
                    };

                    context.People.Add(person);

                    Random rnd = new Random();
                    Thread.Sleep(10);
                    int addressCount = rnd.Next(1,5);

                    for (int j = 0; j < addressCount; j++)
                    {
                        Address address = new Address
                        {
                            Description = FakeData.PlaceData.GetAddress(),
                            Person = person
                        };
                        context.Addresses.Add(address);
                    }
                }

                context.SaveChanges();
            }
        }
    }
}