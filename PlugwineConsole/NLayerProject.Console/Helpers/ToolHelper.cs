using System;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using NLayerProject.Models;
using Newtonsoft.Json;

namespace NLayerProject.Helpers
{
    public static class ToolHelper
    {
        private static HttpRequestProvider _helper = new HttpRequestProvider();

        public static string[] GetData(string form)
        {
            return form.Split(' ');
        }

        /// <summary>
        /// Check if all is correct
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsCorrect(string[] data)
        {
            bool isCorrect = false;

            if (Regex.IsMatch(data[1].ToLower(), "triangle|carre|cercle"))
            {
                if (Regex.IsMatch(data[2], "[0-9]+"))
                {
                    isCorrect = true;
                }
            }

            return isCorrect;
        }
    }
}
