using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCars.DTO;
using MyCars.Entities;
using MyCars.Interfaces;
using System.Collections.Generic;

namespace MyCars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCarController : ControllerBase
    {
        private readonly IMyCarRepository _myCarRepository;
        public MyCarController(IMyCarRepository myCarRepository)
        {
            _myCarRepository = myCarRepository;
        }
        [HttpPost("Create")]
        public IActionResult Create(CreateCarDto carDto)
        {
            _myCarRepository.Create(carDto);
            return Ok(carDto);
        }
        [HttpGet("GetCar")]
        public IActionResult GetCar(int id)
        {
            GetCarDto carDto = _myCarRepository.GetCar(id);
            return Ok(carDto);
        }
        [HttpGet("GetAllCars")]
        public IActionResult GetAllCars()
        {
            List<GetAllCarsDto> carList = _myCarRepository.GetAllCars();
            return Ok(carList);
        }
        [HttpPut("EditCar")]
        public IActionResult EditCar(CarEditDto editedCardto)
        {
            _myCarRepository.Edit(editedCardto);
            return Ok(editedCardto);
        }
        [HttpDelete("RemoveCar")]
        public IActionResult RemoveCar(int id)
        {
            _myCarRepository.Remove(id);
            return Ok();
        }
    }
}

