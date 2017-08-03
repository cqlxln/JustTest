using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//自定义的ACTION返回结果
namespace BookShop.WebUI
{
    public class CustomRedirectResult:ActionResult
    {
        public string Url { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullUrl = UrlHelper.GenerateContentUrl(Url, context.HttpContext);
            context.HttpContext.Response.Redirect(fullUrl);
        }
    }
}