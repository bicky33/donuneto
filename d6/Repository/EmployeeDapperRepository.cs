using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d6.DbContext;
using d6.Entity;

namespace d6.Repository
{
    internal class EmployeeDapperRepository: DapperBaseRepository<Employee> 
    {
        public EmployeeDapperRepository(DapperDbContext _context) : base(_context)
        {
        }

        public override Employee Create(ref Employee entity)
        {
            SqlCommandModel sqlCommandModel = new SqlCommandModel()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "INSERT INTO Employees (LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate) VALUES (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate)",
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@LastName", DataType = System.Data.DbType.String, Value = entity.BirthDate},
                    new SqlCommandParameterModel(){ ParameterName = "@FirstName", DataType = System.Data.DbType.String, Value = entity.FirstName },
                    new SqlCommandParameterModel(){ ParameterName = "@Title", DataType = System.Data.DbType.String, Value = entity.Title },
                    new SqlCommandParameterModel(){ ParameterName = "@TitleOfCourtesy", DataType = System.Data.DbType.String, Value = entity.TitleOfCourtesy },
                    new SqlCommandParameterModel(){ ParameterName = "@BirthDate", DataType = System.Data.DbType.DateTime, Value = entity.BirthDate },
                    new SqlCommandParameterModel(){ ParameterName = "@HireDate", DataType = System.Data.DbType.DateTime, Value = entity.HireDate },
                }
            };
            _dbContext.ExecuteNonQuery(sqlCommandModel);
            _dbContext.Dispose();
            return entity;
        }

        public override void Delete(dynamic id)
        {
            SqlCommandModel sqlCommandModel = new SqlCommandModel()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID",
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@EmployeeID", DataType = System.Data.DbType.Int64, Value = id },
                }
            };
            _dbContext.ExecuteNonQuery(sqlCommandModel);
            _dbContext.Dispose();
        }

        public override IEnumerable<Employee> FindAll()
        {
            IEnumerator<Employee> enumerator = _dbContext.ExecuteReader<Employee>(
                                              "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate FROM Employees"
                                                                                       );
            _dbContext.Dispose();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        public override Employee Update(Employee t)
        {
            SqlCommandModel sqlCommandModel = new SqlCommandModel()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "UPDATE Employees SET LastName = @LastName, FirstName = @FirstName, Title = @Title, TitleOfCourtesy = @TitleOfCourtesy, BirthDate = @BirthDate, HireDate = @HireDate WHERE EmployeeID = @EmployeeID",
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@LastName", DataType = System.Data.DbType.String, Value = t.LastName },
                    new SqlCommandParameterModel(){ ParameterName = "@FirstName", DataType = System.Data.DbType.String, Value = t.FirstName},
                    new SqlCommandParameterModel(){ ParameterName = "@Title", DataType = System.Data.DbType.String, Value = t.Title },
                    new SqlCommandParameterModel(){ ParameterName = "@TitleOfCourtesy", DataType = System.Data.DbType.String, Value = t.TitleOfCourtesy },
                    new SqlCommandParameterModel(){ ParameterName = "@BirthDate", DataType = System.Data.DbType.DateTime, Value = t.BirthDate },
                    new SqlCommandParameterModel(){ ParameterName = "@HireDate", DataType = System.Data.DbType.DateTime, Value = t.HireDate },
                    new SqlCommandParameterModel(){ ParameterName = "@EmployeeID", DataType = System.Data.DbType.Int64, Value = t.EmployeeID },
                }
            };
            _dbContext.ExecuteNonQuery(sqlCommandModel);
            _dbContext.Dispose();
            return t;
        }
    }
}
