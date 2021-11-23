using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class CustomerList : ICustomerList
    {
        public void GetCustomers(List<ICustomer> customers)
        {
            Console.Clear();
            Console.WriteLine("List of customers:\n");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.FirstName} {customer.LastName} | Customer ID: {customer.CustomerId}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
