using System;
using Microsoft.AspNetCore.Mvc;
using SampleIOC.Domain.Entities.DTOs;
using SampleIOC.Domain.Interfaces;

namespace SampleIOC.API.Controllers
{
    public class ClubController : ControllerBase
    {
        [HttpGet]
        [Route("CalculatePercentage")]
        public IActionResult CalculatePercentage([FromQuery] ClubDTO dto, [FromServices] IServiceClub _serviceClub)
        {
            try
            {
                var data = _serviceClub.CalculatePercentage(dto);

                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}