using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
         
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("multipart/form-data"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Routes.MapHttpRoute("API Default", "api/{controller}/{action}/{id}/{name}",
              new { id = RouteParameter.Optional, name = RouteParameter.Optional });

        }
    }
}
