using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Register
    {
        [Key]
        public string login_user { get; set; }
        public string password_user { get; set; }
        public bool admin { get; set; } 
    }
}
