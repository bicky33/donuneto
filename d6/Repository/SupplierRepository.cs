using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d6.DbContext;
using d6.Entity;

namespace d6.Repository
{
    internal class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(AdoDbContext _context) : base(_context)
        {
        }

        public override Supplier Create(ref Supplier entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(dynamic id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Supplier> FindAll()
        {
            IEnumerator<Supplier> enumerator = _dbContext.ExecuteReader<Supplier>(
                "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers"
            );
            _dbContext.Dispose();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public override Task<IEnumerable<Supplier>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public override IAsyncEnumerable<Supplier> FindAllAsyncEnumerable()
        {
            throw new NotImplementedException();
        }

        public override Supplier? FindById(dynamic id)
        {
            SqlCommandParameterModel[] parameters = new SqlCommandParameterModel[]
            {
                new SqlCommandParameterModel()
                {
                    ParameterName = "@SupplierID",
                    Value = id,
                    DataType = System.Data.DbType.Int32,
                },
            };
            SqlCommandModel command = new()
            {
                CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, " +
                "Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE SupplierID = @SupplierID",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = parameters

            };
            var supplier = _dbContext.ExecuteReader<Supplier>(command);
            return supplier.MoveNext() ? supplier.Current : null;
        }

        public override Supplier Update(Supplier t)
        {
            throw new NotImplementedException();
        }
    }
}
