using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registracio.WebApplication.Models
{
    [Table("Employees")]
    public class Employees
    { 
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int DOB { get; set; }
        public DateTime Birthday { get; set; }
    }
}
