using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class Register : IRegister
    {
        private IFactory _factory;
        public Register(IFactory factory)
        {
            _factory = factory;
        }
        public ICustomer NewCustomer()
        {
            Console.Clear();

            var customer = _factory.CreateCustomer();

            while (string.IsNullOrEmpty(customer.FirstName))
            {
                Console.WriteLine("Enter the customers first name: ");
                customer.FirstName = Console.ReadLine();
                Console.Clear();
            }

            while (string.IsNullOrEmpty(customer.LastName))
            {
                Console.WriteLine("Enter the customers Last name: ");
                customer.LastName = Console.ReadLine();
                Console.Clear();
            }

            customer.CustomerId = Guid.NewGuid();

            Console.WriteLine("Customer successfully registered! Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            return customer;
        }

        public IPet NewPet(List<ICustomer> customers)
        {
            Console.Clear();

            var pet = _factory.CreatePet();
            Guid customerGuid = Guid.Empty;

            while (string.IsNullOrEmpty(pet.Name))
            {
                Console.WriteLine("MAKE SURE THE OWNER IS REGISTERED BEFORE YOU REGISTER THE PET!");
                Console.WriteLine("\nEnter the pets name: ");
                pet.Name = Console.ReadLine();
                Console.Clear();
            }

            pet.PetId = Guid.NewGuid();
            pet.IsPresent = "No";
            pet.DailyCost = 0;
            Console.WriteLine("Enter the owners customer id: ");
            string id = Console.ReadLine();
            Console.Clear();

            try
            {
                customerGuid = Guid.Parse(id);

                int index = customers.FindIndex(x => x.CustomerId == customerGuid);
                if (index >= 0)
                {
                    pet.Owner = customers[index];

                    Console.WriteLine("Pet successfully registered! Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    return pet;
                }
                else
                {
                    Console.WriteLine("Invalid customer id. Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    return null;
                }
            }
            catch
            {
                Console.WriteLine("Invalid customer id. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return null;
            }
        }
    }
}
