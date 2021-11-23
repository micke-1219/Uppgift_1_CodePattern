using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface IPet
    {
        public Guid PetId { get; set; }
        public string Name { get; set; }
        public ICustomer Owner { get; set; }
        public string IsPresent { get; set; }
        public int DailyCost { get; set; }
    }
}
