using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolAPI
{
    public static class WebApiConfig
    {
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(cors);
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute("API Default", "api/{controller}/{action}/{id}/{name}",
			  new { id = RouteParameter.Optional, name = RouteParameter.Optional });

		}
	}
}
