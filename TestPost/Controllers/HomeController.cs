using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPost.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public System.Web.Mvc.ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public System.Web.Mvc.ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [System.Web.Mvc.HttpPost]
        public System.Web.Mvc.ActionResult Index([FromBody]Values values)
        {
            return View();
        }
    }

    public class Values
    {
        public string test1 { get; set; }
        public string test2 { get; set; }
    }
}