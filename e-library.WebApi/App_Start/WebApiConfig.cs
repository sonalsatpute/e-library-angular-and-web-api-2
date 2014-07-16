﻿using System.Web.Http;
using System.Web.Http.Cors;

namespace e_library.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
        }
    }
}