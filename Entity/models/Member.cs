using Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Member
    {
        public Member() { }
        public int Id { get; set; }
        public string IdCard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Email { get; set; }   
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Picture { get; set; }
        public DateTime? PositiveResultDate { get; set; }
        public DateTime? RecoveryDate { get;set; }
        public List<CoronaVaccine> CoronaVaccinesList { get; set; }
    }
}