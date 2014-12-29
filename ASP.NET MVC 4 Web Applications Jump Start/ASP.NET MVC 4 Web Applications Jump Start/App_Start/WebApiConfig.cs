﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ASP.NET_MVC_4_Web_Applications_Jump_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}