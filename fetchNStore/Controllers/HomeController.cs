using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fetchNStore.DAL;
using fetchNStore.Models;

namespace fetchNStore.Controllers
{
    
    public class HomeController : Controller
    {
        //ActionResult is a combination of data and ...
        public ActionResult Index()
        {
            ResponseRepository repo = new ResponseRepository();
            ViewBag.getResponse = repo.GetResponse();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}