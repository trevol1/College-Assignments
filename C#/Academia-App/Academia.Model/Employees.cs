using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Registracio.Model
{

    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EmpID { get; set; }
        [Required]
        public string EmpName { get; set; }
       
    }
}