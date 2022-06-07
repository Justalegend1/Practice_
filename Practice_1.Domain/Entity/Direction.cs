using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Direction
    {
        [Key]
        public int ID_Direction { get; set; }
        public string Name_Direction { get; set; }
    }
}
