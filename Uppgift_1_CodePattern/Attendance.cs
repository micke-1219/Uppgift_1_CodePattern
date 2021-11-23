using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class Attendance : IAttendance
    {
        private IPet _pet;
        public Attendance(IPet pet)
        {
            _pet = pet;
        }
        public void CheckInPet(List<IPet> pets)
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
                        Console.WriteLine($"\nPet with id {id} is already checked in.");
                    }
                    else
                    {
                        _pet.IsPresent = "Yes";
                        _pet.DailyCost = 300;

                        Console.WriteLine($"\nPet with id {id} has been checked in.");
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
        public void CheckOutPet(List<IPet> pets)
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

                    if (_pet.IsPresent == "No")
                    {
                        Console.WriteLine($"\nPet with id {id} is already checked out.");
                    }
                    else
                    {
                        Console.WriteLine($"\nPet with id {id} has been checked out.");
                        Console.WriteLine($"\nTotal cost: {_pet.DailyCost} kr");

                        _pet.IsPresent = "No";
                        _pet.DailyCost = 0;
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
