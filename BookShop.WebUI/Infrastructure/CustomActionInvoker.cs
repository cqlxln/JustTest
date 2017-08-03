using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.WebUI
{
    //自定义调用的action
    public class CustomActionInvoker:IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            if (actionName == "Index")
            {
                controllerContext.HttpContext.Response.Write("This is output from the Index action");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}