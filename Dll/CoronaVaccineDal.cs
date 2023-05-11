using Entities;
using Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CoronaVaccineDal:ICoronaVaccineDal
    {
        public HMODB HMODB;
        public CoronaVaccineDal(HMODB HMODB)
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

        public List<CoronaVaccine> GetCoronaVaccinesByDate(DateTime Date)
        {
            return this.HMODB.CoronaVaccines.Where(x => x.Date == Date).ToList();
        }

        public List<CoronaVaccine> GetCoronaVaccinesByIdCard(string IdCard)
        {
            return this.HMODB.CoronaVaccines.Where(x=>x.IdCard== IdCard).ToList();
        }

        public List<CoronaVaccine> GetCoronaVaccinesByManuFacturer(string ManuFacturer)
        {
            return this.HMODB.CoronaVaccines.Where(x => x.ManuFacturer == ManuFacturer).ToList();
        }
    }
}
