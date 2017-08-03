using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookShop.WebUI.Controllers
{
    public class BasicController : IController
    {
        // GET: Basic
        public void Execute(RequestContext requestContext)
        {
            //获取控制器
            string controller = (string)requestContext.RouteData.Values["controller"];
            //获取动作
            string action = (string)requestContext.RouteData.Values["action"];

            requestContext.HttpContext.Response.Write(
                string.Format("Controller: {0}, Action: {1}", controller, action));
        }
    }
}