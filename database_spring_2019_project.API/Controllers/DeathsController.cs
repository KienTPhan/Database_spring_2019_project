using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using USVisual.API.Data;
using System.Linq;

namespace USVisual.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeathsController : ControllerBase
    {
        private readonly DataContext _context;

            public DeathsController(DataContext context)
            {
                _context = context;
            }
        public async Task<IActionResult> GetDeaths()
        {
            var deaths = await _context.Deaths.ToListAsync();

            return Ok(deaths);
        }

        // GET api/deaths/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeath(int id)
        {
            var death = await _context.Deaths.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(death);
        }

        // GET api/deaths/2000/2001
        [HttpGet("{year1}/{year2}")]
        public async Task<IActionResult>  GetValue(int year1, int year2)
        {
            var dataByYearRange = await _context.Deaths.Where(x => Int32.Parse(x.iyear) >= year1
                            && Int32.Parse(x.iyear) <= year2).OrderBy(x => x.iyear).ToListAsync();
            return Ok(dataByYearRange);
        }

        // GET api/deaths/5/6
        [HttpGet("{year1}/{year2}/{countryName}")]
        public async Task<IActionResult>  getDataByCountry(int year1, int year2,string countryName)
        {
            var dataByYearRangeAndCountry = await _context.Deaths.Where(x => Int32.Parse(x.iyear) >= year1
                            && Int32.Parse(x.iyear) <= year2 && x.country_txt.ToLower() == countryName.ToLower()).OrderBy(x => x.iyear).ToListAsync();
            return Ok(dataByYearRangeAndCountry);
        }

         // GET api/deaths/deathCountMoreThan/#deathcount
        [HttpGet("deathCountMoreThan{deathCount}")]
        public async Task<IActionResult>  GetDataByDeathCountMoreThan(int deathCount)
        {
            var dataByDeathCountMoreThan = await _context.Deaths.Where(x => Int32.Parse(x.nkill) >= deathCount).OrderBy(x => x.iyear).ToListAsync();
            return Ok(dataByDeathCountMoreThan);
        }

        // GET api/deaths/deathCountMoreThan/2005/2006/United States/#deathcount
        [HttpGet("{year1}/{year2}/{countryName}/{deathCount}")]
        public async Task<IActionResult>  GetDataByDateCountryDeathCount(int year1, int year2,string countryName,int deathCount)
        {
            var dataByDateCountryDeathCount = await _context.Deaths.Where(x => Int32.Parse(x.nkill) >= deathCount 
                                                && Int32.Parse(x.iyear) >= year1 && Int32.Parse(x.iyear) <= year2 
                                                && x.country_txt.ToLower() == countryName.ToLower())
                                                .OrderBy(x => x.iyear).ToListAsync();
            return Ok(dataByDateCountryDeathCount);
        }


    }
    
}