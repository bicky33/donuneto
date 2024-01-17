using d6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d6.DbContext;

namespace d6.Repository
{
    internal class SupplierDapperRepository: DapperBaseRepository<Supplier>
    {
        public SupplierDapperRepository(DapperDbContext _context) : base(_context)
        {
        }

        public override Supplier Create(ref Supplier entity)
        {
            SqlCommandModel model = new()
            {
                CommandText = "INSERT INTO Suppliers (ContactName, CompanyName, ContactTitle) VALUES (@ContactName, @CompanyName, @ContactTitle)",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel(){ ParameterName = "@ContactName", DataType = System.Data.DbType.String, Value = entity.ContactName },
                    new SqlCommandParameterModel(){ ParameterName = "@CompanyName", DataType = System.Data.DbType.String, Value = entity.CompanyName },
                    new SqlCommandParameterModel(){ ParameterName = "@ContactTitle", DataType = System.Data.DbType.String, Value = entity.ContactTitle},
                }
            };
            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
            return entity;
        }

        public override void Delete(dynamic id)
        {
            SqlCommandModel model = new()
            {
                CommandText = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@SupplierID", DataType = System.Data.DbType.String, Value= id },
                }
            };
            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
        }

        public override IEnumerable<Supplier> FindAll()
        {
            IEnumerator<Supplier> enumerator = _dbContext.ExecuteReader<Supplier>(
                               "SELECT SupplierID, CompanyName, ContactName, ContactTitle FROM Suppliers"
                                          );
            _dbContext.Dispose();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public override Supplier Update(Supplier t)
        {
            SqlCommandModel model = new()
            {
                CommandText = "UPDATE Suppliers SET ContactName = @ContactName, CompanyName = @CompanyName, ContactTitle = @ContactTitle WHERE SupplierID = @SupplierID",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@ContactName", DataType = System.Data.DbType.String, Value= t.ContactName },
                    new SqlCommandParameterModel(){ ParameterName = "@CompanyName", DataType = System.Data.DbType.String, Value = t.ContactName },
                    new SqlCommandParameterModel(){ ParameterName = "@ContactTitle", DataType = System.Data.DbType.String , Value = t.ContactName},
                    new SqlCommandParameterModel(){ ParameterName = "@SupplierID", DataType = System.Data.DbType.Int64, Value = t.SupplierID},
                }
            };
            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
            return t;
        }
    }
}
