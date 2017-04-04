using NLayerProject.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NLayerProject.DAL.Data
{
    /// <summary>
    /// Json repository interface
    /// </summary>
    public interface IJsonRepository
    {
        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        IEnumerable<Form> GetAll();

        /// <summary>
        /// Find a data
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<Form> FindBy(Expression<Func<Form, bool>> predicate);

        /// <summary>
        /// Add a data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        IEnumerable<Form> Add(Form entity);

        /// <summary>
        /// Delete a data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        IEnumerable<Form> Delete(Form entity);

        /// <summary>
        /// Edit a data
        /// </summary>
        /// <param name="entity"></param>
        IEnumerable<Form> Edit(Form entity);

        /// <summary>
        /// Save a data
        /// </summary>
        IEnumerable<Form> SaveJson(List<Form> entities);
    }
}
