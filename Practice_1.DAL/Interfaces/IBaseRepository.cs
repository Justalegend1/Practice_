using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T Entity);
        T GetObject(int id);
        List<T> Select();
        bool Delete(T Entity);
    }
}
