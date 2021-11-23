using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface IExtraServices
    {
        public void CleanPet(List<IPet> pets);
        public void TrimClaws(List<IPet> pets);
    }
}
