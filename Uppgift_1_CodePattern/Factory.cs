using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    public class Factory : IFactory
    {
        public ICustomer CreateCustomer()
        {
            ICustomer customer = new Customer();
            return customer;
        }

        public IPet CreatePet()
        {
            IPet pet = new Pet();
            return pet;
        }
    }
}
