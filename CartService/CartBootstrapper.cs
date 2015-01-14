using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace CartService
{
	public class CartBootstrapper: DefaultNancyBootstrapper	
	{
		protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
		{
			base.ConfigureApplicationContainer(container);
			
			container.Register<ICartRepository, InMemoryCartRepository>();
			
			//var exceptionHandler = container.Resolve<IHandleNancyExceptions>();
			//ApplicationPipelines.OnError.AddItemToEndOfPipeline(exceptionHandler.HandleException);
		}
	}
}