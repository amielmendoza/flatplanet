using FlatPlanet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlatPlanet.Controllers
{
    public class HomeController : Controller
    {
        private ICounterService _counterService;
        public HomeController()
        {
            _counterService = new CounterService();
        }
        public ActionResult Index()
        {
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

        [HttpPost]
        public int AddCount()
        {
            return _counterService.IncreaseCount();
        }
    }
}