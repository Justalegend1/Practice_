using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Hospital
    {
        [Key]
        public int Hospital_ID { get; set; }
        public string Hospital_Name { get; set; }
        public int City_code { get; set; }
        public string Street { get; set; }
        public int House_number { get; set; }
        public string? Corpus { get; set; }
        public string Phone_Fax_number { get; set; }
        public string E_Mail { get; set; }
        public string? Website_address { get; set; }
    }
}
