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
        public List<MemberDto> GetAllMembers();
        public void Add(MemberDto member);
        public MemberDto GetById(int Id);

    }
}
