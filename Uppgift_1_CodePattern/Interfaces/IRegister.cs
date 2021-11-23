using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface IRegister
    {
        public ICustomer NewCustomer();
        public IPet NewPet(List<ICustomer> customers);
    }
}
