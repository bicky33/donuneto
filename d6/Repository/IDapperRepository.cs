using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Repository
{
    internal interface IDapperRepository<T> where T : class
    {
        T Create(ref T entity);
        T Update(T t);
        IEnumerable<T> FindAll();
        void Delete(dynamic id);

        T FindById(dynamic id);
    }
}
