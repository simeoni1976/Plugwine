using NLayerProject.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NLayerProject.DAL.Data
{
    /// <summary>
    /// Context
    /// </summary>
    public class PlugwineContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
    }
}