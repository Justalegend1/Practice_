using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Certificate
    {
        [Key]

        public int Certificate_number { get; set; }
        [Required(ErrorMessage = "Введите код студента")]
        public int Student_ID { get; set; }
        [Required(ErrorMessage = "Введите код врача")]
        public int Doctor_ID { get; set; }
        [Required(ErrorMessage = "Введите дату начала")]
        public DateTime The_beginning_of_the_action { get; set; }
        [Required(ErrorMessage = "Введите дату окончания")]
        public DateTime End_of_action { get; set; }
        [Required(ErrorMessage = "Введите тип")]
        public string Type { get; set; }
    }
}
