using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.WebUI.Models;
using System.Threading.Tasks;

namespace BookShop.WebUI.Controllers
{
    //异步线程处理
    public class RemoteDataController : AsyncController
    {
        // GET: RemoteData
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Data()
        {

            string data = await new RemoteService().GetRemoteDataAsync();
            Response.Write(data);

            return View("Result", new Result
            {
                ControllerName = "RemoteData",
                ActionName = "Data"
            });
        }
    }
}