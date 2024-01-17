using d6.DbContext;

namespace d6.Repository
{
    internal abstract class BaseRepository<T>: IRepository<T> where T : class
    {
        protected readonly AdoDbContext _dbContext;
        public BaseRepository(AdoDbContext _context)
        {
            this._dbContext = _context;
        }

        public virtual T Create(ref T entity)
        {
            throw new NotImplementedException();
        }
        public virtual void Delete(dynamic id)
        {
            throw new NotImplementedException();
        }
        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }
        public virtual Task<IEnumerable<T>> FindAllAsync()
        {
            throw new NotImplementedException();
        }
        public virtual IAsyncEnumerable<T> FindAllAsyncEnumerable()
        {
            throw new NotImplementedException();
        }
        public virtual T? FindById(dynamic id)
        {
            throw new NotImplementedException();
        }
        public virtual T Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
