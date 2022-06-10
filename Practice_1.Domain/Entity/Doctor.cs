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
        
        [Required(ErrorMessage = "Введите фамилию")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Введите отчество")]
        public string? Middle_name { get; set; }
        [Required(ErrorMessage = "Введите код больницы")]
        public int Hospital_ID { get; set; }
    }
}
