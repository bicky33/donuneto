using System.Data;
using d6.DbContext;
using d6.Entity;

namespace d6.Repository
{
    internal class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(AdoDbContext _context) : base(_context)
        {
        }

        public override Customer Create(ref Customer entity)
        {
            return base.Create(ref entity);
        }

        public override void Delete(dynamic id)
        {
           string commandText = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
            SqlCommandParameterModel[] parameters = new SqlCommandParameterModel[]
            {
                new SqlCommandParameterModel()
                {
                    ParameterName= "@CustomerID",
                    Value = id,
                    DataType = DbType.String,
                },
            };
            SqlCommandModel command = new()
            {
                CommandText = commandText,
                CommandType = CommandType.Text,
                CommandParameters = parameters
            };
            _dbContext.ExecuteNonQuery(command);
        }

        public override IEnumerable<Customer> FindAll()
        {
            IEnumerator<Customer> customers = _dbContext.ExecuteReader<Customer>(
                "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers"
                );
            _dbContext.Dispose();
            while (customers.MoveNext())
            {
                yield return customers.Current;
            }
        }

        public override async Task<IEnumerable<Customer>> FindAllAsync()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {}
            };
            var data = _dbContext.ExecuteReaderAsync<Customer>(model);
            List<Customer> customer = new();
            while(await data.MoveNextAsync())
            {
                customer.Add(data.Current);
            }
            return customer;
        }

        public override async IAsyncEnumerable<Customer> FindAllAsyncEnumerable()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };
            var data = _dbContext.ExecuteReaderAsync<Customer>(model);
            while (await data.MoveNextAsync())
            {
                yield return data.Current;
            }
        }

        public override Customer? FindById(dynamic id)
        {
            SqlCommandParameterModel[] parameters = new SqlCommandParameterModel[]
            {
                new SqlCommandParameterModel()
                {
                    ParameterName = "@CustomerID",
                    Value = id,
                    DataType = DbType.String,
                },
            };
            SqlCommandModel command = new()
            {
                CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, " +
                "Region, PostalCode, Country, Phone, Fax FROM Customers WHERE CustomerID = @CustomerID",
                CommandType = CommandType.Text,
                CommandParameters = parameters

            };
            var customer = _dbContext.ExecuteReader<Customer>(command);
            return customer.MoveNext() ? customer.Current : null;        
        }

        public override Customer Update(Customer t)
        {
            return base.Update(t);
        }
    }
}
