using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace NLayerProject.Core.Helpers
{
    public class AppConfigHelper
    {
        /// <summary>
        /// Get a json data
        /// </summary>
        public static string GetJsonData
        {
            get
            {
                return (new WebClient())
                    .DownloadString(GetJsonFilePath);
            }
        }

        /// <summary>
        /// Get a json path
        /// </summary>
        public static string GetJsonFilePath
        {
            get
            {
                return HttpContext.Current
                    .Server.MapPath("~/" + ConfigurationManager.AppSettings["JsonDataFile"].ToString());
            }
        }
    }
}