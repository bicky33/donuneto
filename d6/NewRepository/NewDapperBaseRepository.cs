using d6.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d6.DbContext;

namespace d6.NewRepository
{
    internal class NewDapperBaseRepository<T> : INewDapperBaseRepository<T> where T : class
    {
        protected readonly NewDapperDbContext _contextDB; 
        public NewDapperBaseRepository(NewDapperDbContext _contextDb)
        {
            this._contextDB = _contextDb;
        }

        public virtual T FindById(dynamic id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
