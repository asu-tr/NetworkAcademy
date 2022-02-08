using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_03_LINQ
{
    public class DataSource
    {

        public List<Customer> Get100CustomerList()
        {
            List<Customer> list = new List<Customer>();

            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.FirstName = FakeData.NameData.GetFirstName();
                customer.LastName = FakeData.NameData.GetSurname();
                customer.Country = FakeData.PlaceData.GetCountry();
                customer.BirthDate = FakeData.DateTimeData.GetDatetime();
                customer.Phone = FakeData.PhoneNumberData.GetPhoneNumber();

                list.Add(customer);
            }

            return list;
        }
    }
}
