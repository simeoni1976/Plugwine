using NLayerProject.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NLayerProject.Helpers
{
    public class HttpRequestProvider : HttpRequestMessage
    {
        private readonly HttpClient _httpClient;

        public HttpRequestProvider()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _httpClient.BaseAddress = new Uri("http://localhost:56776/"); 
        }

        /// <summary>
        /// Get all forms
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<FormModel>> GetForms()
        {
            List<FormModel> list = null;
            HttpResponseMessage response = await _httpClient.GetAsync("api/plugwine");
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<FormModel>>();
            }
            return list;
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="formModel"></param>
        /// <returns></returns>
        public async Task<IEnumerable<FormModel>> Post(FormModel formModel)
        {
            List<FormModel> list = null;
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/plugwine", formModel);
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<FormModel>>();
            }

            return list;
        }

        /// <summary>
        /// Get price
        /// </summary>
        /// <param name="formModel"></param>
        /// <returns></returns>
        public async Task<int> GetPrice(int area)
        {
            int value = 0;
            HttpResponseMessage response = await _httpClient.GetAsync("api/price?area=" + area);
            if (response.IsSuccessStatusCode)
            {
                value = await response.Content.ReadAsAsync<int>();
            }
            return value;
        }

        /// <summary>
        /// Get other price
        /// </summary>
        /// <param name="formModel"></param>
        /// <returns></returns>
        public async Task<int> GetOtherPrice(int area)
        {
            int value = 0;
            HttpResponseMessage response = await _httpClient.GetAsync("api/price/other?area=" + area);
            if (response.IsSuccessStatusCode)
            {
                value = await response.Content.ReadAsAsync<int>();
            }
            return value;
        }
    }
}
