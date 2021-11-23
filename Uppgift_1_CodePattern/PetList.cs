using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class PetList : IPetList
    {
        public void GetPets(List<IPet> pets)
        {
            Console.Clear();
            Console.WriteLine("List of pets:\n");
            foreach (var pet in pets)
            {
                Console.WriteLine($"Name: {pet.Name} | Pet ID: {pet.PetId} | Owner: {pet.Owner.FirstName} {pet.Owner.LastName} | Is currently checked in: {pet.IsPresent}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public void GetCheckedInPets(List<IPet> pets)
        {
            var checkedInPets = pets.Where(x => x.IsPresent == "Yes");
            Console.Clear();
            Console.WriteLine("List of currently checked in pets:\n");
            foreach (var pet in checkedInPets)
            {
                Console.WriteLine($"Name: {pet.Name} | Pet ID: {pet.PetId} | Owner: {pet.Owner.FirstName} {pet.Owner.LastName}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
