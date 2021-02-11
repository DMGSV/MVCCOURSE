using System.Threading.Tasks;
using System.Web.Mvc;

namespace HundaiService.Controllers
{
    public class CarController : Controller
    {
        private readonly CarService1 _carservice;
        public CarController()
        {

        }
        public async Task<ActionResult> Index()
        {
            var cars = await _carservice.GetCars();
            return View(cars);
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