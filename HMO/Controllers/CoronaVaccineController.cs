using Bll;
using Dto;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectHmo.Controllers
{
    [Route("api/coronaVaccineController")]
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
        public List<CoronaVaccineDto> GetAll()
        {
            return this.CoronaVaccineBll.GetCoronaVaccines();
        }
        [HttpGet("{IdCard}")]
        public List<CoronaVaccineDto> GetByIdCard(string IdCard)
        {
            return this.CoronaVaccineBll.GetCoronaVaccineByIdCard(IdCard);
        }
        [HttpGet("date/{date}")]
        public List<CoronaVaccineDto> GetByDate(DateTime date)
        {
            return this.CoronaVaccineBll.GetCoronaVaccinesByDate(date);
        }
        [HttpGet("manufacturer/{manuFacturer}")]
        public List<CoronaVaccineDto> GetByManuFacturer(string manuFacturer)
        {
            return this.CoronaVaccineBll.GetCoronaVaccinesByManuFacturer(manuFacturer);
        }

        // POST api/<CoronaVaccineController>
        [HttpPost]
        //this function returns boolean result for the user to know weather the vaccine was added succesfuly
        //or not due to the constraints (more than 4 || member doesnt exist)
        public bool Post([FromBody] CoronaVaccineDto value)
        {
            return this.CoronaVaccineBll.AddCoronaVaccine(value);
        }

    }
}