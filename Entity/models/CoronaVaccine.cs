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

        [ForeignKey("Member")]
        public string IdCard { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string ManuFacturer { get; set; }
    }
}
