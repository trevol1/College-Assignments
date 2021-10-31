using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Registracio.Model
{
    public class Items
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
    }
}
