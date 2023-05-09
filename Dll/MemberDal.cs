using Entities;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public class MemberDal : IMemberDal
    {
        public DB HMODB;
        public MemberDal(DB HMODB)
        {
            this.HMODB = HMODB;
        }

        public void AddMember(Member member)
        {
            HMODB.Members.Add(member);
            HMODB.SaveChanges();
        }

        public List<Member> GetAllMembers()
        {
            return HMODB.Members.ToList();
        }

        public Member GetMemberById(int memberId)
        {
            return HMODB.Members.FirstOrDefault(m => m.Id == memberId);
        }

    }
}