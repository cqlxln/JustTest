using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id=0)
        {
            return View((object)new object[] { "apple", "orange", "peach" } [id>2?0:id]);
        }

        public ActionResult Name(string[] names)
        {
            names = names ?? new string[0];
            return View(names);
        }

        public JsonResult GetTestData()
        {
            return Json(
                new { msg = "Datetime from server：" + DateTime.Now.ToString("HH:mm:ss") },
                JsonRequestBehavior.AllowGet
            );
        }

        public ActionResult Address()
        {
            IList<Address> addresses = new List<Address>();
            UpdateModel(addresses, new FormValueProvider(ControllerContext));
            return View(addresses);
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
    }
}