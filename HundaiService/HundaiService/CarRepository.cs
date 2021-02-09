using HundaiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HundaiService
{
    public class CarRepository
    {
        private static List<Car> _cars;

        public CarRepository()
        {
            _cars = new List<Car> { new Car { IDCar = 1, Brand = "Hundai", Model = "S", BodyModel = "SEDAN" } };
        }

        public async Task<List<Car>> GetCars()
        {
            return await Task.Run(() => _cars);
        }

        public async Task<Car> GetCar(int id)
        {
            return await Task.Run(() => _cars.FirstOrDefault(f => f.IDCar == id));
        }
    }
}