using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class ExtraServices : IExtraServices
    {
        private IPet _pet;
        public ExtraServices(IPet pet)
        {
            _pet = pet;
        }
        public void CleanPet(List<IPet> pets)
        {
            Console.Clear();

            Guid petGuid = Guid.Empty;

            Console.WriteLine("Enter the pets id: ");
            string id = Console.ReadLine();
            try
            {
                petGuid = Guid.Parse(id);

                int index = pets.FindIndex(x => x.PetId == petGuid);
                if (index >= 0)
                {
                    _pet = pets[index];

                    if (_pet.IsPresent == "Yes")
                    {
                        _pet.DailyCost += 200;
                        Console.WriteLine($"\nPet with id {id} will be cleaned at a cost of 200 kr.");
                    }
                    else
                    {
                        Console.WriteLine($"\nPet with id {id} needs to be checked in before cleaning.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid id.");
                }
            }
            catch
            {
                Console.WriteLine("\nInvalid id.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public void TrimClaws(List<IPet> pets)
        {
            Console.Clear();

            Guid petGuid = Guid.Empty;

            Console.WriteLine("Enter the pets id: ");
            string id = Console.ReadLine();
            try
            {
                petGuid = Guid.Parse(id);

                int index = pets.FindIndex(x => x.PetId == petGuid);
                if (index >= 0)
                {
                    _pet = pets[index];

                    if (_pet.IsPresent == "Yes")
                    {
                        _pet.DailyCost += 100;
                        Console.WriteLine($"\nPet with id {id} will get its claws trimmed a cost of 100 kr.");
                    }
                    else
                    {
                        Console.WriteLine($"\nPet with id {id} needs to be checked in before claw trimming.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid id.");
                }
            }
            catch
            {
                Console.WriteLine("\nInvalid id.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
