using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.WebUI.Controllers
{
    public class HomeAjaxController : Controller
    {
        // GET: HomeAjax
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTestData()
        {
            return Json(
                new { msg = "Datetime from server：" + DateTime.Now.ToString("HH:mm:ss") }
            );
        }
    }
}