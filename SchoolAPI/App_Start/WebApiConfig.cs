using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SchoolAPI
{
    public static class WebApiConfig
    {
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute("API Default", "api/{controller}/{action}/{id}/{name}",
			  new { id = RouteParameter.Optional, name = RouteParameter.Optional });

		}
	}
}
