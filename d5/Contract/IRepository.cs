using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Contract
{
    public interface IRepository<T>
    {
        public void Save(List<T> data, T entity);
        public void Delete(List<T> data, T entity);
        public void Update(List<T> data, T entity);
        public List<T> FindAll(List<T> data);
        public T? FindById(List<T> data, int id);
    }
}
