﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HomeNewController : Controller
    {
        // GET: HomeNew
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult MakeBooking(Appointment appt)
        {
            return Json(appt, JsonRequestBehavior.AllowGet);
        }


        //public ViewResult MakeBooking()
        //{
        //    return View(new Appointment { Date = DateTime.Now });
        //}

        //[HttpPost]
        //public ViewResult MakeBooking(Appointment appt)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        return View("Completed", appt);
        //            }
        //    else{
        //        return View();
        //    }

            ////return View("Completed", appt);
            //if (string.IsNullOrEmpty(appt.ClientName))
            //{
            //    ModelState.AddModelError("ClientName", "Please enter your name");
            //}
            //if (ModelState.IsValidField("Date") && DateTime.Now > appt.Date)
            //{
            //    ModelState.AddModelError("Date", "Please enter a date in the future");
            //}
            //if (!appt.TermsAccepted)
            //{
            //    ModelState.AddModelError("TermsAccepted", "You must accept the terms");
            //}
            //if (ModelState.IsValid)
            //{
            //    return View("Completed", appt);
            //}
            //else
            //{
            //    return View();
            //}
        //}
    }
}