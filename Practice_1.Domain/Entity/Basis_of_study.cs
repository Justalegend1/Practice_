using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Domain.Entity
{
    public class Basis_of_study
    {
        [Key]
        public int ID_basis_study { get; set; }
        public string Basis_study { get; set; }
    }
}
