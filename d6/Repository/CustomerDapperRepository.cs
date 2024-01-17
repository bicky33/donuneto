using d6.DbContext;
using d6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Repository
{
    internal class CustomerDapperRepository : DapperBaseRepository<Customer>
    {
        public CustomerDapperRepository(DapperDbContext _context) : base(_context)
        {
        }

        public override Customer Create(ref Customer entity)
        {
            SqlCommandModel sqlCommandModel = new SqlCommandModel()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "INSERT INTO Customers (CustomerID, ContactName, CompanyName, ContactTitle) VALUES (@CustomerID, @ContactName, @CompanyName, @ContactTitle)",
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@CustomerID", DataType = System.Data.DbType.String },
                    new SqlCommandParameterModel(){ ParameterName = "@ContactName", DataType = System.Data.DbType.String },
                    new SqlCommandParameterModel(){ ParameterName = "@CompanyName", DataType = System.Data.DbType.String },
                    new SqlCommandParameterModel(){ ParameterName = "@ContactTitle", DataType = System.Data.DbType.String },
                }
            };
            _dbContext.ExecuteNonQuery(sqlCommandModel);
            _dbContext.Dispose();
            return entity;
        }

        public override void Delete(dynamic id)
        {
            SqlCommandModel model = new()
            {
                CommandText = "DELETE FROM Customers WHERE CustomerID = @CustomerID",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@CustomerID", DataType = System.Data.DbType.String },
                }
            };
            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
        }

        public override IEnumerable<Customer> FindAll()
        {
            IEnumerator<Customer> enumerator = _dbContext.ExecuteReader<Customer>(
                                              "SELECT CustomerID, CompanyName, ContactName, ContactTitle FROM Customers"
                                                                                       );
            _dbContext.Dispose();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public override Customer Update(Customer t)
        {
            SqlCommandModel model = new()
            {
                CommandText = "UPDATE Customers SET ContactName = @ContactName, CompanyName = @CompanyName, ContactTitle = @ContactTitle WHERE CustomerID = @CustomerID",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@CustomerID", DataType = System.Data.DbType.String },
                    new SqlCommandParameterModel(){ ParameterName = "@ContactName", DataType = System.Data.DbType.String },
                    new SqlCommandParameterModel(){ ParameterName = "@CompanyName", DataType = System.Data.DbType.String },
                    new SqlCommandParameterModel(){ ParameterName = "@ContactTitle", DataType = System.Data.DbType.String },
                }
            };
            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
            return t;
        }
    }
}
