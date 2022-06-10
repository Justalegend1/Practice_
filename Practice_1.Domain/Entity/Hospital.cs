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
        [Display(Name ="Название больницы")]
        [Required(ErrorMessage = "Введите название больницы")]
        public string Hospital_Name { get; set; }
        [Display(Name = "Город")]
        [Required(ErrorMessage = "Введите город")]
        public int City_code { get; set; }
        [Required(ErrorMessage = "Введите улицу")]
        [Display(Name = "Улица")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Введите номер дома")]
        [Display(Name = "Номер дома")]
        public int House_number { get; set; }
        [Display(Name = "Строение")]
        public string? Corpus { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        [Display(Name = "Телефон")]
        public string Phone_Fax_number { get; set; }
        [Required(ErrorMessage = "Введите почту")]
        [Display(Name = "Почта")]
        public string E_Mail { get; set; }
        [Display(Name = "Сайт")]
        public string? Website_address { get; set; }
    }
}
