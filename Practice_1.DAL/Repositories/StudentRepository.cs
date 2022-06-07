using Practice_1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_1.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Practice_1.DAL.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationContext _db;

        public StudentRepository(ApplicationContext db)
        {
            _db = db;
        }

        public bool Create(Student Entity)
        {
            _db.Add(Entity);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(Student Entity)
        {

            _db.Student.Remove(Entity);
            _db.SaveChanges();
            return true;
        }

        public Student GetByName(string Name)
        {
            return _db.Student.FirstOrDefault(x => x.Name == Name);
        }

        public Student GetObject(int id)
        {
            return _db.Student.FirstOrDefault(x => x.Student_ID == id);
        }

        public List<Student> Select()
        {
            return _db.Student.ToList();
        } 
    }
}
