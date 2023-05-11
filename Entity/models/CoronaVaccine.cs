using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.models
{
    public class CoronaVaccine
    {
        public CoronaVaccine() { }
        public int Id { get; set; }
        [ForeignKey("Member")]
        public string IdCard { get; set; }
        public DateTime Date { get; set; }
        public string ManuFacturer { get; set; }

        public Member Member { get; set; }
    }
}
