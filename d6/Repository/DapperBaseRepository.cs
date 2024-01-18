using d6.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Repository
{
    internal abstract class DapperBaseRepository<T>: IDapperRepository<T> where T : class
    {
        protected readonly DapperDbContext _dbContext;
        public DapperBaseRepository(DapperDbContext _context)
        {
            this._dbContext = _context;
        }
        public virtual T Create(ref T entity)
        {
            throw new NotImplementedException();
        }
        public virtual T Update(T t)
        {
            throw new NotImplementedException();
        }
        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }
        public virtual void Delete(dynamic id)
        {
            throw new NotImplementedException();
        }

        public virtual T FindById(dynamic id)
        {
            throw new NotImplementedException();
        }
    }
}
