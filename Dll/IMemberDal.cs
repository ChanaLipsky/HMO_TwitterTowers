using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IMemberDal
    {
        public List<Member> GetAllMembers();
        public void AddMember (Member member);
        public Member GetMemberById(int Id);
    }
}