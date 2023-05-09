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
    public class MemberBll : IMemberBll
    {
        IMapper mapper;
        IMemberDal MemberDal;
        public MemberBll(IMapper mapper, IMemberDal memberDal)
        {
            this.mapper = mapper;
            this.MemberDal = memberDal;
        }

        public void Add(MemberDto member)
        {
            throw new NotImplementedException();
        }


        public MemberDto GetById(int Id)
        {
            return this.mapper.Map<MemberDto>(this.MemberDal.GetMemberById(Id));

        }

        void IMemberBll.Add(MemberDto member)
        {
            throw new NotImplementedException();
        }

        List<MemberDto> IMemberBll.GetAllMembers()
        {
            throw new NotImplementedException();
        }

        MemberDto IMemberBll.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }




}