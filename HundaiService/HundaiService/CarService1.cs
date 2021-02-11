using System.Collections.Generic;
using System.Threading.Tasks;
using HundaiService.Models;

namespace HundaiService
{
    public class CarService1
    {
        private readonly CarRepository _carRepository;

        public CarService1()
        {
            _carRepository = new CarRepository();
        }

        public async Task<List<Car>> GetCars()
        {
            return await _carRepository.GetCars();
        }
    }
}