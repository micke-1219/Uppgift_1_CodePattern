using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class Pet : IPet
    {
        public Guid PetId { get; set; }
        public string Name { get; set; }
        public ICustomer Owner { get; set; }
        public string IsPresent { get; set; }
        public int DailyCost { get; set; }
    }
}
