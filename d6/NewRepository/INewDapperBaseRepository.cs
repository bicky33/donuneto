using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.NewRepository
{
    internal interface INewDapperBaseRepository<T> where T : class
    {
        T FindById(dynamic id);

        IEnumerable<T> FindAll();
    }
}
