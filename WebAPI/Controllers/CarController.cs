using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = carService.getAll();
            if (result.success)
            {
                return Ok(result.data);
            }
            return BadRequest(result.message);
        }

        [HttpPost("add")]
        public IActionResult addCar(Car car)
        {
            var result = carService.add(car);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult getById(int id)
        {
            var result = carService.getById(id);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult update(Car car)
        {
            var result = carService.update(car);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult delete(Car car)
        {
            var result = carService.delete(car);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
