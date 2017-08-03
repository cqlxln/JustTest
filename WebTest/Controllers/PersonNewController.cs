using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class PersonNewController : Controller
    {
        // GET: PersonNew
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatePerson(PersonNew model)
        {
            return View(model);
        }

        public ActionResult DisplayAddress([Bind(Prefix= "HomeAddress",Exclude = "Country")]Address address)
        {
            return View(address);
        }
    }
}