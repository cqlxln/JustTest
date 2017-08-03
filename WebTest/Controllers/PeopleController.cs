using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class PeopleController : Controller
    {
        private Person[] personData = {
            new Person {ID = "ZhangSan", Name = "张三", Role = Role.Admin},
            new Person {ID = "LiSi", Name = "李四", Role = Role.User},
            new Person {ID = "WangWu", Name = "王五", Role = Role.User},
            new Person {ID = "MaLiu", Name = "马六", Role = Role.Guest}
        };
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }

        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }
    }
}