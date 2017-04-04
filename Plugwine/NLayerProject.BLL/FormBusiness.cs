using NLayerProject.Core.Domain;
using NLayerProject.Core.Interface;
using NLayerProject.DAL.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using NLayerProject.DAL.Repository;
using Newtonsoft.Json;

namespace NLayerProject.BLL
{
    public class FormBusiness : IFormBusiness
    {
        private readonly UnitOfWork _unitOfWork;

        public FormBusiness()
        {
            _unitOfWork = new UnitOfWork(new PlugwineContext());
        }
        
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IEnumerable<Form> Create(Form entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            return this.SaveJson(_unitOfWork.FormRepository.Add(entity).ToList());
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IEnumerable<Form> Update(Form entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            return this.SaveJson(_unitOfWork.FormRepository.Edit(entity).ToList());
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IEnumerable<Form> Delete(Form entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            return this.SaveJson(_unitOfWork.FormRepository.Delete(entity).ToList());

        }

        /// <summary>
        /// Get all forms
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<Form> GetAll()
        {
            return _unitOfWork.FormRepository.GetAll();
        }

        /// <summary>
        /// Save to a json file
        /// </summary>
        /// <param name="results"></param>
        /// <returns></returns>
        private IEnumerable<Form> SaveJson(List<Form> results)
        {
            return _unitOfWork.FormRepository.SaveJson(results);
        }
    }
}