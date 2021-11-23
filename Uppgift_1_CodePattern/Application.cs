using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class Application : IApplication
    {
        private IRegister _register;
        private ICustomerList _customerList;
        private IPetList _petList;
        private IAttendance _attendance;
        private IExtraServices _extraServices;

        public Application(IRegister register, ICustomerList customerList, IPetList petList, IAttendance attendance, IExtraServices extraServices)
        {
            _register = register;
            _customerList = customerList;
            _petList = petList;
            _attendance = attendance;
            _extraServices = extraServices;
        }

        ICustomer newCustomer;
        IPet newPet;

        List<ICustomer> customers = new List<ICustomer>();
        List<IPet> pets = new List<IPet>();

        public void ShowMenu()
        {
            Console.WriteLine("1. Register new customer\n" +
                "2. Register new pet\n" +
                "3. Get a list of all customers\n" +
                "4. Get a list of all pets\n" +
                "5. Get a list of currently checked in pets\n" +
                "6. Check in pet\n" +
                "7. Check out pet\n" +
                "8. Order pet cleaning\n" +
                "9. Order claw trimming\n");
            Console.WriteLine("Enter a number (1-9):");
        }

        public void MenuChoice()
        {
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    newCustomer = _register.NewCustomer();
                    if (newCustomer != null)
                    {
                        customers.Add(newCustomer);
                    }
                    break;

                case "2":
                    newPet = _register.NewPet(customers);
                    if (newPet != null)
                    {
                        pets.Add(newPet);
                    }
                    break;

                case "3":
                    _customerList.GetCustomers(customers);
                    break;

                case "4":
                    _petList.GetPets(pets);
                    break;
                case "5":
                    _petList.GetCheckedInPets(pets);
                    break;

                case "6":
                    _attendance.CheckInPet(pets);
                    break;

                case "7":
                    _attendance.CheckOutPet(pets);
                    break;
                case "8":
                    _extraServices.CleanPet(pets);
                    break;
                case "9":
                    _extraServices.TrimClaws(pets);
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }

        public void Run()
        {
            //MOCK DATA
            customers.Add(new Customer { CustomerId = Guid.NewGuid(), FirstName = "Anders", LastName = "Andersson" });
            customers.Add(new Customer { CustomerId = Guid.NewGuid(), FirstName = "Sven", LastName = "Svensson" });
            pets.Add(new Pet { PetId = Guid.NewGuid(), Name = "Lua", Owner = customers[0], IsPresent = "Yes", DailyCost = 300 });
            pets.Add(new Pet { PetId = Guid.NewGuid(), Name = "Hedda", Owner = customers[1], IsPresent = "No", DailyCost = 300 });

            while (true)
            {
                ShowMenu();
                MenuChoice();
            }
        }
    }
}
