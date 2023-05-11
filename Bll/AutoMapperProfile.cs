using AutoMapper;
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
   public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Member, MemberDto>();
        CreateMap<MemberDto, Member>();
        CreateMap<CoronaVaccine, CoronaVaccineDto>();
        CreateMap<CoronaVaccineDto, CoronaVaccine>();

    }
}
}
