using Microsoft.Practices.Unity;
using NLayerProject.BLL;
using NLayerProject.Core.Domain;
using NLayerProject.Core.Interface;
using NLayerProject.DAL.Data;
using NLayerProject.DAL.Repository;
using NLayerProject.SL;
using System;

namespace NLayerProject.DependancyInjection
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container
                .RegisterType<IUnitOfWork, UnitOfWork>()
                .RegisterType<IJsonRepository, JsonRepository>()
                .RegisterType<IFormBusiness, FormBusiness>()
                .RegisterType<IFormService, FormService>()
                .RegisterType<IPriceBusiness, PriceBusiness>()
                .RegisterType<IPriceService, PriceService>();
        }
    }
}