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
    }
}
