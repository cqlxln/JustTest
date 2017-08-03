using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.WebUI.Controllers
{
    public class ActionInvokerController : Controller
    {
        //在构造函数中制定调用的ACTION  INVOKER
        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    // GET: ActionInvoker
    }
}