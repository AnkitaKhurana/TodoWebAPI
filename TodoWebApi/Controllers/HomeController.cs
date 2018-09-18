using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Data.Class1 c= new Data.Class1();
            //c.MakeAdmin();

            return View();
        }
    }
}
