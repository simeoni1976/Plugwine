using NLayerProject.BLL.Helpers;
using NLayerProject.Core.Domain;
using NLayerProject.Core.Interface;
using NLayerProject.DAL.Data;
using NLayerProject.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerProject.BLL
{
    /// <summary>
    /// Business
    /// </summary>
    public class PriceBusiness : IPriceBusiness
    {
        public PriceBusiness()
          : base()
        {
        }

        /// <summary>
        /// Get a price for an area
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public int GetPrice(int area)
        {
            var pricer = new Pricer();
            return pricer.Price(area);
        }

        /// <summary>
        /// Get a price for an other area
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public int GetOtherPrice(int area)
        {
            var pricer = new OtherPricer();
            return pricer.Price(area);
        }
    }
}