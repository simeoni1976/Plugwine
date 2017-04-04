using NLayerProject.BLL;
using NLayerProject.Core.Domain;
using NLayerProject.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerProject.SL
{
    /// <summary>
    /// Service
    /// </summary>
    public class PriceService : IPriceService
    {
        IPriceBusiness _business;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="business"></param>
        public PriceService(IPriceBusiness business)
          : base()
        {
            _business = business;
        }

        /// <summary>
        /// Get a price for an area
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public int GetPrice(int area)
        {
            return _business.GetPrice(area);
        }

        /// <summary>
        /// Get another price for an area
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public int GetOtherPrice(int area)
        {
            return _business.GetOtherPrice(area);
        }
    }
}