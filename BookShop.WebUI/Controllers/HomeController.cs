using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.WebUI.Infrastructure;

namespace BookShop.WebUI.Controllers
{
    public class HomeController : Controller
    {

        //public ActionResult Index()
        //{
        //   return View();
        //}

        //定义过滤器 做页面的限制
        [CustomAuth(true)]
        //[Authorize(Users = "jim, steve, jack", Roles = "admin")]
        public string Index()
        {
            //return View();
            return "This is the Index action on the Home controller";
        }

        //调用Partial
        public ActionResult List()
        {
            return View();
        }

        //调用ChildAction
        [ChildActionOnly]
       public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProduceOutput()
        {
            if (Server.MachineName == "MondayZha-PC")
            {
                //使用自定义的CONTROLLER
                return new CustomRedirectResult { Url = "/Basic/Index" };
            }
            else
            {
                Response.Write("Controller: Derived, Action: ProduceOutput");
                return null;
            }
        }
    }
}