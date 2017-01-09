using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using WebMVCAppIoC.Controllers;
using WebMVCAppIoC.Models;

namespace WebMVCAppIoC.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            var defaultFactory = new DefaultControllerFactory();
            if (controllerName.ToLower().StartsWith("proteintracker"))
            {
                var repository = new ProteinRepository("yoo");
                var service = new ProteinTrackingService(repository);
                var controller = new ProteinTrackerController(service);
                return controller;
            }

            return defaultFactory.CreateController(requestContext, controllerName);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            var disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}