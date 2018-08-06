[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApresentation.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WebApresentation.App_Start.NinjectWebCommon), "Stop")]

namespace WebApresentation.App_Start
{
    using System;
    using System.Web;
	using AppClass.AppServi�os;
	using AppClass.IAppServi�os;
	using DataAccess.Reposit�rios;
	using DomainClass.Interfaces.Reposit�rios;
	using DomainClass.Interfaces.Servi�os;
	using DomainClass.Servi�os;
	using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
		{
			//service application
			kernel.Bind<IAppServ>().To<AppServUser>();

			//service domain
			kernel.Bind<IServUser>().To<ServUser>();

			//repositorio
			kernel.Bind<iRepos>().To<ReposUser>();


		}
	}
}
