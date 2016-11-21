using System;
using System.Data.Entity;
using EduSim.Core.ModelInterfaces;
using EduSim.Core.Models;
using EduSim.Core.Contexts;
using EduSim.Core.Repository;
using EduSim.Core.Services;
using EduSim.Web.Models;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace EduSim.Web.App_Start
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
			container.RegisterType<DbContext, EduSimContext>(new HierarchicalLifetimeManager());
			// Repositories
			container.RegisterType<IRepository<Type>, Repository<Type>>();
			container.RegisterType<IRepository<AccountType>, Repository<AccountType>>();
			container.RegisterType<IRepository<Role>, Repository<Role>>();

			container.RegisterType<IProfile, Profile>();

			// Lookup models
			container.RegisterType<ILookupService, LookupService>();
			container.RegisterType<IAccountType, AccountType>();
			container.RegisterType<IRole, Role>();

			// Application models
			container.RegisterType<IAccount, Account>();
			container.RegisterType<ISchool, School>();
			container.RegisterType<IEduSimContext, EduSimContext>();

			//Register service interfaces
			container.RegisterType<IProfileService, ProfileService>();
			container.RegisterType<IAccountService, AccountService>();
        }
    }
}
