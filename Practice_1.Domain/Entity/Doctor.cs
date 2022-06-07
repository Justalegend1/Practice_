using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Doctor
    {
        [Key]
        public int Doctor_ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Middle_name { get; set; }
        public int Hospital_ID { get; set; }
    }
}
