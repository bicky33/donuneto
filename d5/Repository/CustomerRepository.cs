using d5.Class;
using d5.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Repository
{
    internal class CustomerRepository : IRepository<Customer>
    {
        public void Delete(List<Customer> data, Customer entity)
        {
            data.Remove(entity);
        }

        public List<Customer> FindAll(List<Customer> data)
        {
            return data;
        }

        public Customer? FindById(List<Customer> data, int id)
        {
            return data.FirstOrDefault(x => x.CustomerID == id);
        }

        public void Save(List<Customer> data, Customer entity)
        {
            data.Add(entity);
        }

        public void Update(List<Customer> data, Customer entity)
        {
            data[data.FindIndex(x => x.CustomerID == entity.CustomerID)] = entity;
        }
    }
}
