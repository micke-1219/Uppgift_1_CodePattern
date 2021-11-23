using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface ICustomerList
    {
        public void GetCustomers(List<ICustomer> customers);
    }
}
