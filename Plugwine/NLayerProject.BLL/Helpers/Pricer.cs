using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.BLL.Helpers
{
    /// <summary>
    /// Get a price with area
    /// </summary>
    public class Pricer : IPricer
    {
        public int Price(int area)
        {
            return area * 2;
        }
    }
}
