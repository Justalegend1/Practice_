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
        public int Student_ID { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Middle_name { get; set; }
        public DateTime Birth_date { get; set; }
        public int Sex_ID { get; set; }
        public int City_ID { get; set; }
        public int Direction_ID { get; set; }
        public int Group_ID { get; set; }
        public int ID_basis_study { get; set; }
        public int ID_form_study { get; set; }
        public int Passport_data { get; set; }
        [Required]
        public string Contract_number { get; set; }
        public int? Certificate_number { get; set; }
        [Required]
        public string E_mail { get; set; }
        [Required]
        public string Phone_number { get; set; }
        [Required]
        public int Course { get; set; }
    }
}
