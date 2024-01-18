using d6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.NewRepository
{
    internal interface IEmployeeNewDapperRepository
    {
        Employee FindById(int id);

        IEnumerable<Employee> FindAll();
    }
}
