using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Microsoft.Practices.Unity;
using NLayerProject.DependancyInjection;
using NLayerProject.DAL.Data;
using NLayerProject.Core.Interface;
using NLayerProject.Core.Domain;

[assembly: OwinStartup(typeof(NLayerProject.Web.Startup))]

namespace NLayerProject.Web
{
    public partial class Startup
    {
        private IUnityContainer _container;

        public void Configuration(IAppBuilder app)
        {
            _container = UnityConfig.GetConfiguredContainer();

            _container.Resolve<IJsonRepository>();
            _container.Resolve<IFormBusiness>();
            _container.Resolve<IFormService>();
            _container.Resolve<IPriceBusiness>();
            _container.Resolve<IPriceService>();

            ConfigureAuth(app);
        }
    }
}
