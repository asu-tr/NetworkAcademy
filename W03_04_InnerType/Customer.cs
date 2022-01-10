using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_04_InnerType
{
    public class Customer
    {
        public int CustomerID;
        public string Name;
        public List<CustomerAddress> CustomerAddresses = new List<CustomerAddress>(); 
        public List<CustomerContact> CustomerContacts = new List<CustomerContact>();


        public static void ShowCustomerDetails(Customer customer)
        {
            Console.WriteLine("CUSTOMER DETAILS: ");
            Console.WriteLine($"Customer ID: {customer.CustomerID}");
            Console.WriteLine($"Name: {customer.Name}");

            foreach (CustomerAddress address in customer.CustomerAddresses)
            {
                Console.WriteLine($"{address.AddressType}: {address.Address}");
            }

            foreach (CustomerContact contact in customer.CustomerContacts)
            {
                Console.WriteLine($"{contact.ContactType}: {contact.ContactInfo}");
            }
        }
    }
}
