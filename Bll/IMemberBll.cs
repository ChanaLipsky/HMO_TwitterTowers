using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IMemberBll
    {
        public List<MemberDto> GetMembers();
        public MemberDto GetMember(int id);
        public void AddMember(MemberDto member);
        public MemberDto GetMemberByIdCard(string cardId);
    }
}
