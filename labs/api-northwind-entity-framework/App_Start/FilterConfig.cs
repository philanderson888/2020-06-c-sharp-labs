﻿using System.Web;
using System.Web.Mvc;

namespace api_northwind_entity_framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
