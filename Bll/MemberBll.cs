using AutoMapper;
using Dal;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class MemberBll:IMemberBll
    {
        IMapper mapper;
        IMemberDal memberDal;
        public MemberBll(IMapper mapper, IMemberDal memberDal)
        {
            this.mapper = mapper;
            this.memberDal = memberDal;
        } 
        public List<MemberDto> GetMembers()
        {
            return mapper.Map<List<MemberDto>>(this.memberDal.GetAllMembers().ToList());
        }

        public MemberDto GetMember(int id)
        {
            return mapper.Map<MemberDto>(this.memberDal.GetMemberById(id));
        }

        public void AddMember(MemberDto member)
        {
            this.memberDal.AddMember(mapper.Map<Member>(member));
        }

        public MemberDto GetMemberByIdCard(string cardId)
        {
            return this.mapper.Map<MemberDto>(this.memberDal.GetMemberByIdCard(cardId));
        }

    }
}
