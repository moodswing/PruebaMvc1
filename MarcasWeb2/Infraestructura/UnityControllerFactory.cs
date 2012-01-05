using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Microsoft.Practices.Unity;

namespace MarcasWeb2.Infraestructura
{
    public class UnityControllerFactory : IControllerActivator
    {
        private readonly IUnityContainer _container;
        private readonly IControllerFactory _innerFactory;

        public UnityControllerFactory(IUnityContainer container) : this(container, new DefaultControllerFactory())
        {
        }

        protected UnityControllerFactory(IUnityContainer container, IControllerFactory innerFactory)
        {
            _container = container;
            _innerFactory = innerFactory;
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            try
            {
                return _container.Resolve<IController>(controllerName.ToLowerInvariant());
            }
            catch (Exception)
            {
                return _innerFactory.CreateController(requestContext, controllerName);
            }
        }

        public void ReleaseController(IController controller)
        {
            _container.Teardown(controller);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        IController IControllerActivator.Create(RequestContext requestContext, Type controllerType)
        {
            return DependencyResolver.Current.GetService(controllerType) as IController;
        }
    }
}