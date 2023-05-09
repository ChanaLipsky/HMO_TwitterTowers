using AutoMapper;
using Dal;
using Dto;
using Entity.models;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CoronaVaccineBll : ICoronaVaccineBll
    {
        IMapper mapper;
        ICoronaVaccineDal CoronaVaccineDal;
        IMemberDal MemberDal;
        Member Member;

        public CoronaVaccineBll(Member Member, IMapper mapper, ICoronaVaccineDal coronaVaccineDal, IMemberDal MemberDal)
        {
            this.mapper = mapper;
            this.CoronaVaccineDal = coronaVaccineDal;
            this.MemberDal = MemberDal;
            this.Member= Member;
        }

        public void Add(CoronaVaccineDto coronaVaccine)
        {
            string id = coronaVaccine.IdCard;
            var vaccine = mapper.Map<CoronaVaccine>(coronaVaccine);
            int flag = 0;
            List<Member> members = MemberDal.GetAllMembers();
            foreach (Member member in members) { 
                if(member.IdCard == id) {
                    if(member.CoronaVaccinesList.Count > 4)
                    {
                        throw new Exception("cannot get more than 4 corona vaccines");
                    }
                    Member.CoronaVaccinesList.Add(vaccine);
                    flag = 1;
                } 

            }
            if(flag == 0)
            {
                throw new Exception("member is undefind");
            }
        }

        public List<CoronaVaccineDto> GetAllVaccines()
        {
            throw new NotImplementedException();
        }

        public List<CoronaVaccineDto> GetVaccinesByMemberId(string MemberId)
        {
            List<CoronaVaccine> vaccines = CoronaVaccineDal.GetAllCoronaVaccines();
            List <CoronaVaccineDto> vaccinesDto= mapper.Map<CoronaVaccineDto>(vaccines);
            List<CoronaVaccineDto> VaccinesByMember= vaccinesDto.Where(x=>x.IdCard== MemberId).ToList();
        }
    }
}
