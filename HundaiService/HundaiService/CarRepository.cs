using HundaiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace HundaiService
{
    public class CarRepository
    {
        private static List<Car> _cars;

        public CarRepository()
        {
            _cars = new List<Car> { new Car { IdCar = 1, Brand = "Hundai", Model = "S", BodyModel = "SEDAN", Distance = 4500, Drive = true, Helm = true, New = false, Power = 400, Year = 2004, DateTime DateStart = {new DateTime(2015, 7, 20, 18, 30, 25)}} };
        }

        public async Task<List<Car>> GetCars()
        {
            return await Task.Run(() => _cars);
        }

        public async Task<Car> GetCar(int id)
        {
            return await Task.Run(() => _cars.FirstOrDefault(f => f.IdCar == id));
        }
    }
}