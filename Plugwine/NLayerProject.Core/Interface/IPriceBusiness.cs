using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Interface
{
    public interface IPriceBusiness
    {
        int GetPrice(int area);
        int GetOtherPrice(int area);
    }
}
