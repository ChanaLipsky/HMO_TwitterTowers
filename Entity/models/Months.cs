using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.models
{
    internal class Months
    {
        public Months() { }
        public int Id { get; set; }

        [ForeignKey("CoronaVaccine")]
        public DateTime Date { get; set; }

    }
}
