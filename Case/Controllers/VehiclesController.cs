using Case.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IBusRepository _busRepository;
        private readonly IBoatRepository _boatRepository;

        public VehiclesController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("{color}")]
        public IActionResult GetColorOfCars(string color)
        {
            var cars= _carRepository.GetQuery().Where(x => x.Color == color).ToList();
            if (cars.Count() == 0)
            {
                return NotFound();
            }
            return Ok(cars);
        }
        [HttpGet("{color}")]
        public IActionResult GetColorOfBuses(string color)
        {
            var buses = _busRepository.GetQuery().Where(x => x.Color == color).ToList();
            if (buses.Count() == 0)
            {
                return NotFound();
            }
            return Ok(buses);
        }
        [HttpGet("{color}")]
        public IActionResult GetColorOfBoats(string color)
        {
            var boats = _boatRepository.GetQuery().Where(x => x.Color == color).ToList();
            if (boats.Count() == 0)
            {
                return NotFound();
            }
            return Ok(boats);
        }
        [HttpPost("{id}")]
        public IActionResult ChangeHeadlights(int id)
        {
            var car= _carRepository.Find(id);

            if (car == null)
            {
                return NotFound("Boyle bi araç bulunamadı");
            }
            car.Headlight = car.Headlight ? false : true;
            _carRepository.Save();
            return Ok(car);
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveCar(int id)
        {
            var car = _carRepository.Find(id);

            if (car == null)
            {
                return NotFound("Boyle bi araç bulunamadı");
            }
            _carRepository.Remove(car.Id);
            _carRepository.Save();
            return Ok("Silme islemi basarili");
        }
    }
}
