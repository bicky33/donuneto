using d5.Class;
using d5.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Repository
{
    internal class EmployeeRepository : IRepository<Employee>
    {
        public void Delete(List<Employee> data, Employee entity)
        {
            data.Remove(entity);
        }

        public List<Employee> FindAll(List<Employee> data)
        {
            return data;
        }

        public Employee? FindById(List<Employee> data, int id)
        {
            return data.FirstOrDefault(x => x.EmployeeID == id);
        }

        public void Save(List<Employee> data, Employee entity)
        {
            data.Add(entity);
        }

        public void Update(List<Employee> data, Employee entity)
        {
            data[data.FindIndex(x => x.EmployeeID == entity.EmployeeID)] = entity;
        }
    }
}
