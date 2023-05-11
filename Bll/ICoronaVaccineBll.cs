using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ICoronaVaccineBll
    {
        public List<CoronaVaccineDto> GetCoronaVaccines();
        public bool AddCoronaVaccine(CoronaVaccineDto coronaVaccineDto);
        public List<CoronaVaccineDto> GetCoronaVaccineByIdCard(string IdCard);
        public List<CoronaVaccineDto> GetCoronaVaccinesByDate(DateTime date);
        public List<CoronaVaccineDto> GetCoronaVaccinesByManuFacturer(string ManuFacturer);
    }
}
