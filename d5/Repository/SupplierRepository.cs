using d5.Class;
using d5.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Repository
{
    internal class SupplierRepository : IRepository<Supplier>
    {
        public void Delete(List<Supplier> data, Supplier entity)
        {
            data.Remove(entity);
        }

        public List<Supplier> FindAll(List<Supplier> data)
        {
            return data;
        }

        public Supplier? FindById(List<Supplier> data, int id)
        {
            return data.FirstOrDefault(x => x.SupplierID == id);
        }

        public void Save(List<Supplier> data, Supplier entity)
        {
            data.Add(entity);
        }

        public void Update(List<Supplier> data, Supplier entity)
        {
            data[data.FindIndex(v => v.SupplierID == entity.SupplierID)] = entity;
        }
    }
}
