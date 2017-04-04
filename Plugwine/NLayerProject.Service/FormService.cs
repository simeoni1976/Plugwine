using NLayerProject.Core.Domain;
using NLayerProject.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerProject.BLL
{
    public class FormService : IFormService
    {
        IFormBusiness _business;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="business"></param>
        public FormService(IFormBusiness business)
        {
            _business = business;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        public virtual IEnumerable<Form> Create(Form entity)
        {
            return _business.Create(entity);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        public virtual IEnumerable<Form> Update(Form entity)
        {
            return _business.Update(entity);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual IEnumerable<Form> Delete(Form entity)
        {
            return _business.Delete(entity);
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<Form> GetAll()
        {
            return _business.GetAll();
        }
    }
}