using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLayerProject.Core.Domain
{
    /// <summary>
    /// Form Json class
    /// </summary>
    public class Form
    {
        /// <summary>
        /// Get or set form id
        /// </summary>
        [JsonProperty("FormId")]
        public int FormId { get; set; }

        /// <summary>
        /// Get or set name
        /// </summary>
        [JsonProperty("FormName")]
        public string FormName { get; set; }

        /// <summary>
        /// Get or set formtype name
        /// </summary>
        [JsonProperty("FormTypeName")]
        public string FormTypeName { get; set; }

        /// <summary>
        /// Get or set area
        /// </summary>
        [JsonProperty("Area")]
        public int Area { get; set; }
    }
}