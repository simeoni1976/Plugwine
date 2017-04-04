using NLayerProject.Core.Domain;
using NLayerProject.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Interface
{
    /// <summary>
    /// Injector interface
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
    }
}
