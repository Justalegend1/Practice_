using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Student
    {
        [Key]
        [Display(Name="Код студента")]
        public int Student_ID { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage ="Введите фамилию")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Введите отчество")]
        [Display(Name = "Отчество")]
        public string Middle_name { get; set; }
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Введите дату рождения")]
        public DateTime Birth_date { get; set; }
        [Required(ErrorMessage = "Введите пол")]
        [Display(Name = "Пол")]
        public int Sex_ID { get; set; }
        [Display(Name = "Город")]
        [Required(ErrorMessage = "Введите город")]
        public int City_ID { get; set; }
        [Required(ErrorMessage = "Введите направление")]
        [Display(Name = "Направление")]
        public int Direction_ID { get; set; }
        [Required(ErrorMessage = "Введите группу")]
        [Display(Name = "Группа")]
        public int Group_ID { get; set; }
        [Required(ErrorMessage = "Введите отчество основу обучения")]
        [Display(Name = "Основа обучения")]
        public int ID_basis_study { get; set; }
        [Required(ErrorMessage = "Введите форму обучения")]
        [Display(Name = "Форма обучения")]
        public int ID_form_study { get; set; }
        [Required(ErrorMessage = "Введите паспортные данные")]
        [Display(Name = "Паспортные данные")]
        public int Passport_data { get; set; }
        [Required(ErrorMessage = "Введите номер договора")]
        [Display(Name = "Номер договора")]
        public string Contract_number { get; set; }
        [Display(Name = "Номер справки")]
        public int? Certificate_number { get; set; }
        [Required(ErrorMessage = "Введите почту")]
        [Display(Name = "Почта")]
        public string E_mail { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        [Display(Name = "Телефон")]
        public string Phone_number { get; set; }
        [Required(ErrorMessage = "Введите курс")]
        [Display(Name = "Курс")]
        public int Course { get; set; }
    }
}
