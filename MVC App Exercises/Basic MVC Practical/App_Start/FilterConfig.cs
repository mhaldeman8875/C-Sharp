﻿using System.Web;
using System.Web.Mvc;

namespace Basic_MVC_Practical
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
