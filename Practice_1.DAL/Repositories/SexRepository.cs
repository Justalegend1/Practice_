using Practice_1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.DAL.Repositories
{
    public class SexRepository
    {
        ApplicationContext _db;
        public Sex GetByName(string name)
        {
            return _db.Sex.FirstOrDefault(x => x.sex == name);
        }
    }
}
