using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Models
{
    public class Compensation
    {
        [Key]
        public String EmployeeId { get; set; }
        public String Salary { get; set; }
        public String EffectiveDate { get; set; }


    }
}
