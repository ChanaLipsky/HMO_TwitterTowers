using Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ICoronaVaccineDal
    {
        public List<CoronaVaccine> GetAllCoronaVaccines();
        public void AddCoronaVaccine(CoronaVaccine coronaVaccine);
        public List<CoronaVaccine> GetCoronaVaccinesByIdCard(string IdCard);
        public List<CoronaVaccine> GetCoronaVaccinesByDate(DateTime date);
        public List<CoronaVaccine> GetCoronaVaccinesByManuFacturer(string MenuFactor);
    }
}
