using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class City
    {
        [Key]
        public int City_ID { get; set; }
        public string City_Name { get; set; }
    }
}
