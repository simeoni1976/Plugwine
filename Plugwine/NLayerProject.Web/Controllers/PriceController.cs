using NLayerProject.BLL;
using NLayerProject.Core.Interface;
using NLayerProject.DAL.Data;
using NLayerProject.DAL.Repository;
using NLayerProject.SL;
using System.Web.Http;

namespace NLayerProject.Web.Controllers
{
    public class PriceController : ApiController
    {
        private readonly IPriceService _priceService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        /// <param name="model"></param>
        public PriceController()
        {
            _priceService = new PriceService(new PriceBusiness());
        }

        /// <summary>
        /// Get all form data
        /// </summary>
        [HttpGet]
        public int Get(int area)
        {
            return _priceService.GetPrice(area);
        }

        /// <summary>
        /// Add a form data
        /// </summary>
        /// <param name="action"></param>
        /// <param name="formTypeName"></param>
        /// <param name="formName"></param>
        /// <param name="area"></param>
        [HttpGet]
        [Route("api/Price/Other")]
        public int GetOther(int area)
        {
            return _priceService.GetOtherPrice(area);
        }
    }
}
