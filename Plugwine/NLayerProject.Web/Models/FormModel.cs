using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Models
{
    public class FormModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int FormId { get; set; }

        /// <summary>
        /// Type name
        /// </summary>
        public string FormTypeName { get; set; }

        /// <summary>
        /// Form name
        /// </summary>
        public string FormName { get; set; }

        /// <summary>
        /// Form area
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public FormModel()
        {
            FormId = (new Random()).Next(100, 999);
        }
    }
}
