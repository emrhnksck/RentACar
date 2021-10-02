using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    //IoC tanımlamadım
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        IRentalService rentalServcie;

        public RentalController(IRentalService rentalServcie)
        {
            this.rentalServcie = rentalServcie;
        }

        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = rentalServcie.getAllRentals();
            if (result.success)
            {
                return Ok(result.data);
            }
            return BadRequest(result.message);
        }

        [HttpPost("add")]
        public IActionResult addRental(Rental rental)
        {
            var result = rentalServcie.add(rental);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult deleteRental(Rental rental)
        {
            var result = rentalServcie.delete(rental);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult updateRental(Rental rental)
        {
            var result = rentalServcie.update(rental);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
