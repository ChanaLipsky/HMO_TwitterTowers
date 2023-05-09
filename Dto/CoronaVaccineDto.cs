using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CoronaVaccineDto
    {
        public CoronaVaccineDto() { }
        public string IdCard { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string ManuFacturer { get; set; }
    }
}
