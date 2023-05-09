using Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ICoronaVaccineDal
    {
        public List<CoronaVaccine> GetAllCoronaVaccines();
        public void AddCoronaVaccine(CoronaVaccine coronaVaccine);
    }
}
