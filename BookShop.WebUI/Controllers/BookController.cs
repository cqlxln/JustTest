using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Domain;

namespace BookShop.WebUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository respository;
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        
        //依赖注入
        public BookController(IBookRepository bookRespository)
        {
            respository = bookRespository;
        }

        public ViewResult List()
        {
            //return View(respository.Books);
            //利用linq进行排序查询
            //价格在50元以下的前10条记录，并且按价格从低到高显示
            return View(respository.Books
            .OrderBy(ab => ab.Price)
            .Where(ab => ab.Price < 60)
            .Take(10));
        }
    }
}