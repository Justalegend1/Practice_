using Practice_1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.DAL.Interfaces
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        Student GetByName(string Name); 
    }
}
