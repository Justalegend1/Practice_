using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Sex
    {
        [Key]
        public int ID_sex { get; set; }
        public string sex { get; set; }
    }
}
