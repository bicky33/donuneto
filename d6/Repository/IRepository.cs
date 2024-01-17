using d6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Repository
{
    internal interface IRepository<T> where T : class
    {
        IEnumerable<T> FindAll();
        T? FindById(dynamic id);

        T Create(ref T entity);

        T Update(T t);

        Task<IEnumerable<T>> FindAllAsync();

        IAsyncEnumerable<T> FindAllAsyncEnumerable();

        void Delete(dynamic id);
    }
}
