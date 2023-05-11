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
        public HMODB HMODB;
        public MemberDal(HMODB HMODB)
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

        public Member? GetMemberById(int memberId)
        {
            return HMODB.Members.FirstOrDefault(m => m.Id == memberId);
        }
        public Member? GetMemberByIdCard(string memberIdCard)
        {
            if (IsMemberByIdCard(memberIdCard)) {
                return HMODB.Members.ToList().FirstOrDefault(m=>m.IdCard.Equals(memberIdCard));
            }
            return null;
        }

        public int GetMemberVaccineCount(string memberIdCard)
        {
            return 0;   
        }

        public bool IsMemberByIdCard(string MemberIdCard)
        {
            return this.HMODB.Members.FirstOrDefault(m=>m.IdCard.Equals(MemberIdCard))!=null;
        }
    }
}