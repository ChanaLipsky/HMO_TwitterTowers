using Bll;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectHmo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaVaccineController : ControllerBase

    {
        ICoronaVaccineBll CoronaVaccineBll;

        // GET: api/<CoronaVaccineController>
        public CoronaVaccineController(ICoronaVaccineBll coronaVaccineBll)
        {
            CoronaVaccineBll = coronaVaccineBll;
        }
        [HttpGet]
        public List<CoronaVaccineDto> Get()
        {
            return this.CoronaVaccineBll.Get();
        }

        // POST api/<CoronaVaccineController>
        [HttpPost]
        public void Post([FromBody] CoronaVaccineDto value)
        {
            this.CoronaVaccineBll.Add(value);
        }

    }
}