using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HundaiService.Controllers
{
    public class CarController : Controller
    {
        public CarController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCar()
        {
            return View();
        }
        public ActionResult EditCar()
        {
            return View();
        }
        public ActionResult DeleteCar()
        {
            return RedirectToAction("Index");
        }
    }
}