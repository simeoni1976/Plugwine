using NLayerProject.Core.Domain;
using NLayerProject.Core.Interface;
using NLayerProject.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace NLayerProject.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IJsonRepository _formRepository;

        /// <summary>
        /// The DbContext
        /// </summary>
        private PlugwineContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        /// <param name="context">The object context</param>
        public UnitOfWork(PlugwineContext context)
        {
            _dbContext = context;
        }

        /// <summary>
        /// FormRepository
        /// </summary>
        public IJsonRepository FormRepository
        {
            get
            {
                if (_formRepository == null)
                {
                    _formRepository = new JsonRepository();
                }
                return _formRepository;
            }
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
    }
}