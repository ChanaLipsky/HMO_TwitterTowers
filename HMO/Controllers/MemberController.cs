using Bll;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectHmo.Controllers
{
    [Route("api/memberController")]
    [ApiController]
    public class MemberController : ControllerBase

    {
        IMemberBll MemberBll;

        // GET: api/<MemberController>
        public MemberController(IMemberBll memberBll)
        {
            MemberBll = memberBll;
        }
        [HttpGet]
        public List<MemberDto> GetAllMembers()
        {
            return this.MemberBll.GetMembers();
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public MemberDto Get(int id)
        {
            return this.MemberBll.GetMember(id);
        }
        [HttpGet("IdCard/{IdCard}")]
        public MemberDto GetMemberByIdCard(string IdCard)
        {
            return this.MemberBll.GetMemberByIdCard(IdCard);
        }

        // POST api/<MemberController>
        [HttpPost]
        public void Post([FromBody] MemberDto value)
        {
            this.MemberBll.AddMember(value);
        }

    }
}