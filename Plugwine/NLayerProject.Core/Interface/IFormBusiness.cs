using NLayerProject.Core.Domain;
using System.Collections.Generic;

namespace NLayerProject.Core.Interface
{
    /// <summary>
    /// Form business interface
    /// </summary>
    public interface IFormBusiness : IBusiness
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        IEnumerable<Form> Create(Form entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        IEnumerable<Form> Delete(Form entity);
        
        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        IEnumerable<Form> GetAll();

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        IEnumerable<Form> Update(Form entity);
    }
}
