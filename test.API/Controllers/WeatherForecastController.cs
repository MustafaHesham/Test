using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using test.API.Properties.Models.Data;

namespace test.API.Controllers
{
    
    //http://localhost:5000/api/weather
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            _context = context;

        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> logger;


        // public WeatherForecastController()
        // {

        // }
        // public WeatherForecastController(ILogger<WeatherForecastController> logger)
        // {
        //     _logger = logger;
        // }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var Values = await _context.values.ToListAsync();
            return Ok(Values);
}

[HttpGet("{id}")]
public async Task<IActionResult> GetValues(int id)
        {
            var Values = await _context.values.FirstOrDefaultAsync(x => x.ID ==id);
            return Ok(Values);
}}}