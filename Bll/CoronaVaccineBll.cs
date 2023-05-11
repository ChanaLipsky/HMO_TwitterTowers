using AutoMapper;
using Bll.Exceptions;
using Dal;
using Dto;
using Entity.models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bll
{
    public class CoronaVaccineBll : ICoronaVaccineBll
    {
        IMapper mapper;
        ICoronaVaccineDal coronaVaccineDal;
        IMemberDal MemberDal;
        public CoronaVaccineBll(IMapper mapper, ICoronaVaccineDal coronaVaccineDal,IMemberDal memberDal)
        {
            this.mapper = mapper;
            this.coronaVaccineDal = coronaVaccineDal;
            this.MemberDal = memberDal;
        }

        public bool AddCoronaVaccine(CoronaVaccineDto value)
        {
            try
            {
                    //var member = MemberDal.GetAllMembers().FirstOrDefault(m => m.IdCard.Equals(value.IdCard));
                    if (MemberDal.GetMemberByIdCard(value.IdCard) == null)
                    {
                        throw new MemberNotFoundException($"Could not find member with id card {value.IdCard}");
                    }
                    if (this.coronaVaccineDal.GetCoronaVaccinesByIdCard(value.IdCard).Count() >= 4)
                    {
                        throw new MemberVaccineLimitReachedException($"Member with id card {value.IdCard} has reached the maximum number of vaccines allowed");

                    }
                coronaVaccineDal.AddCoronaVaccine(this.mapper.Map<CoronaVaccine>(value));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CoronaVaccineDto> GetCoronaVaccines()
        {
            return this.mapper.Map<List<CoronaVaccineDto>>(this.coronaVaccineDal.GetAllCoronaVaccines());
        }
        public List<CoronaVaccineDto> GetCoronaVaccineByIdCard(string idCard)
        {
            return this.mapper.Map<List<CoronaVaccineDto>>(this.coronaVaccineDal.GetCoronaVaccinesByIdCard(idCard));
        }

        public List<CoronaVaccineDto> GetCoronaVaccinesByDate(DateTime date)
        {
            return this.mapper.Map<List<CoronaVaccineDto>>(this.coronaVaccineDal.GetCoronaVaccinesByDate(date));
        }

        public List<CoronaVaccineDto> GetCoronaVaccinesByManuFacturer(string ManuFacturer)
        {
            return this.mapper.Map<List<CoronaVaccineDto>>(this.coronaVaccineDal.GetCoronaVaccinesByManuFacturer(ManuFacturer));
        }
    }
}
