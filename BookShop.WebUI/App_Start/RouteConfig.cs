using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookShop.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //设置 RouteCollection的 RouteExistingFiles 属性值为true 让路由系统对静态文件也进行路由匹配
            //意思就是如果访问HTML的页面，也可以进行路由的匹配
            routes.RouteExistingFiles = true;

            //只要是请求Content目录下的任何html文件都能被直接返回
            routes.IgnoreRoute("Content/{filename}.html");

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
             //defaults: new { controller = "Book", action = "List", id = UrlParameter.Optional },
              //在这里添加命名空间的路由限制，比如到BOOKSHOP.WEBUI下面去找，因为AREA里面也作了相应的限制定义，如果不定义就会发生同命名的情况，而无法转到相应路由
              namespaces: new[] { "BookShop.WebUI.Controllers" }
            //routes.MapRoute("ChromeRoute", "{*catchall}",
            //  new { controller = "Home", action = "Index" },
            //  new { customConstraint = new UserAgentConstraint("Chrome") }
            );

            //自定义如果是静态路由的话-如何转到相应的ACTION里面去 DiskFile可以自己定义
            routes.MapRoute("DiskFile", "Content/Test.html",
                 new { controller = "Book", action = "List", });

        }
    }
}
