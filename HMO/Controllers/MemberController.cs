using Bll;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectHmo.Controllers
{
    [Route("api/[controller]")]
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
            return this.MemberBll.GetAllMembers();
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public MemberDto Get(int id)
        {
            return this.MemberBll.GetById(id);
        }

        // POST api/<MemberController>
        [HttpPost]
        public void Post([FromBody] MemberDto value)
        {
            this.MemberBll.Add(value);
        }

    }
}