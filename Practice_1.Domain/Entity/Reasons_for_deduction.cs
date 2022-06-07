using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Reasons_for_deduction
    {
        [Key]
        public int ID_reason_deduction { get; set; }
        public string Reason_deduction { get; set; }
    }
}
