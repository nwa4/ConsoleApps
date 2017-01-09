using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using WebMVCAppIoC.Models;
using System.Web.Configuration;

namespace WebMVCAppIoC.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
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
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();


            //My Custom codes
            container.RegisterTypes(
                                    AllClasses.FromLoadedAssemblies(),
                                    WithMappings.FromMatchingInterface,
                                    WithName.Default);
            //container.RegisterType<IProteinRepository, ProteinRepository>(new InjectionConstructor("test.data.source"));
            //container.RegisterInstance(typeof(IProteinRepository), new ProteinRepository("data.source"));

            container.RegisterType<IProteinRepository, ProteinRepository>("StandardRepository", new InjectionConstructor("std.data.source"));
            container.RegisterType<IProteinRepository, DebugProteinRepository>("DebugRepository", new InjectionConstructor("debug.data.source"));

            var repositoryType = WebConfigurationManager.AppSettings["RepositoryType"];
            container.RegisterType<IProteinTrackingService, ProteinTrackingService>(
                new InjectionConstructor(container.Resolve<IProteinRepository>(repositoryType)));

            //container.RegisterType<IProteinTrackingService, ProteinTrackingService>();
            //container.RegisterType<IProteinRepository, ProteinRepository>();
        }
    }
}
