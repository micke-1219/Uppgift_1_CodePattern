using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface IFactory
    {
        public ICustomer CreateCustomer();
        public IPet CreatePet();
    }
}
