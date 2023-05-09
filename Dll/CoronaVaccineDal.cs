using Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CoronaVaccineDal
    {
        public DB HMODB;
        public CoronaVaccineDal(DB HMODB)
        {
            this.HMODB = HMODB;
        }

        public void AddCoronaVaccine(CoronaVaccine coronaVaccine)
        {
            HMODB.CoronaVaccines.Add(coronaVaccine);
            HMODB.SaveChanges();
        }

        public List<CoronaVaccine> GetAllCoronaVaccines()
        {
            return HMODB.CoronaVaccines.ToList();
        }

    }
}
