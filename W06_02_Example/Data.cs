using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_02_Example
{
    public class Data
    {
        public List<Person> GetPerson()
        {
            List<Person> list = new List<Person>();

            for (int i = 0; i < 100; i++)
            {
                Person p = new Person();
                p.Id = i;
                p.FirstName = FakeData.NameData.GetFirstName();
                p.LastName = FakeData.NameData.GetSurname();
                p.Country = FakeData.PlaceData.GetCountry();
                list.Add(p);
            }

            return list;
        }
    }
}
