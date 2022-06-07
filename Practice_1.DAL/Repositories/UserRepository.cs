using Practice_1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.DAL.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationContext _db;

        public UserRepository(ApplicationContext db)
        {
            _db = db;
        }
        public bool Create(Register Entity)
        {
            _db.Add(Entity);
            _db.SaveChanges();
            return true;
        }
        public bool Delete(Register Entity)
        {

            _db.Register.Remove(Entity);
            _db.SaveChanges();
            return true;
        }
        public List<Student> Select()
        {
            return _db.Student.ToList();
        }
        public Register GetByLogin(string Login)
        {
            return _db.Register.FirstOrDefault(x => x.login_user == Login);
        }
    }
}
