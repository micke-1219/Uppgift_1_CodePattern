using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface IPetList
    {
        public void GetPets(List<IPet> pets);
        public void GetCheckedInPets(List<IPet> pets);
    }
}
