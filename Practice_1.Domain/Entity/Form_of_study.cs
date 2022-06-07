using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Form_of_study
    {
        [Key]
        public int ID_form_study { get; set; }
        public string Study_form { get; set; }
    }
}
