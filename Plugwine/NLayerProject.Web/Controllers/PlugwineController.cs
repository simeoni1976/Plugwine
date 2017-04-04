using NLayerProject.BLL;
using NLayerProject.Core.Domain;
using NLayerProject.Core.Helpers;
using NLayerProject.Core.Interface;
using NLayerProject.DAL.Data;
using NLayerProject.DAL.Repository;
using NLayerProject.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NLayerProject.Web.Controllers
{
    public class PlugwineController : ApiController
    {
        private readonly IFormService _formService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        /// <param name="model"></param>
        public PlugwineController()
        {
            _formService = new FormService(new FormBusiness());
        }

        /// <summary>
        /// Get all form data
        /// </summary>
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var results = _formService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Add a form data
        /// </summary>
        /// <param name="action"></param>
        /// <param name="formTypeName"></param>
        /// <param name="formName"></param>
        /// <param name="area"></param>
        [HttpPost]
        public HttpResponseMessage Post(FormModel formModel)
        {
            try
            {
                var results = _formService.Create(MappingHelper.ToMap<FormModel, Form>(formModel));
                return Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Delete a form data
        /// </summary>
        /// <param name="action"></param>
        /// <param name="formTypeName"></param>
        /// <param name="formName"></param>
        /// <param name="area"></param>
        [HttpDelete]
        public HttpResponseMessage Delete(FormModel formModel)
        {
            try
            {
                var results = _formService.Delete(MappingHelper.ToMap<FormModel, Form>(formModel));
                return Request.CreateResponse(HttpStatusCode.OK, results);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
