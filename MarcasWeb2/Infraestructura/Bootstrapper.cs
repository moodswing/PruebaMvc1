using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace MarcasWeb2.Infraestructura
{
    public static class Bootstrapper
    {
        public static void ConfigureUnityContainer()
        {
            var container = GetUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static IUnityContainer GetUnityContainer()
        {
            var container = new UnityContainer()
                .RegisterType<IControllerActivator, UnityControllerFactory>();   

            return container;
        }

    }
}