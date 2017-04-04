using Newtonsoft.Json;
using NLayerProject.Core.Domain;
using NLayerProject.Core.Helpers;
using NLayerProject.DAL.Data;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Linq.Expressions;

namespace NLayerProject.DAL.Repository
{
    public class JsonRepository : IJsonRepository
    {
        private readonly string _jsonData;
        private readonly string _jsonFile;

        /// <summary>
        /// Constructor
        /// </summary>
        public JsonRepository()
        {
            _jsonData = AppConfigHelper.GetJsonData;
            _jsonFile = AppConfigHelper.GetJsonFilePath;
        }

        /// <summary>
        /// Get all datas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Form> GetAll()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Form>>(_jsonData);
        }

        /// <summary>
        /// Find a list
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Form> FindBy(Expression<Func<Form, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add an object
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public IEnumerable<Form> Add(Form entity)
        {
            List<Form> list = JsonConvert.DeserializeObject<List<Form>>(_jsonData) ?? new List<Form>();
            list.Add(entity);
            var results = JsonConvert.SerializeObject(list, Formatting.Indented);
            return JsonConvert.DeserializeObject<List<Form>>(results);
        }

        /// <summary>
        /// Delete an object
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public IEnumerable<Form> Delete(Form entity)
        {
            List<Form> list = JsonConvert.DeserializeObject<List<Form>>(_jsonData) ?? new List<Form>();
            list.Remove(entity);
            var results = JsonConvert.SerializeObject(list, Formatting.Indented);
            return JsonConvert.DeserializeObject<List<Form>>(results);
        }

        /// <summary>
        /// Edit an object
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public IEnumerable<Form> Edit(Form entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save to a json file
        /// </summary>
        /// <param name="results"></param>
        /// <returns></returns>
        public IEnumerable<Form> SaveJson(List<Form> results)
        {
             System.IO.File.WriteAllText(@"" + _jsonFile,  
                JsonConvert.SerializeObject(results.ToArray()));

            return results;
        }
    }
}