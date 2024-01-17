using d6.DbContext;
using d6.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Repository
{
    internal class RepositoryDb : BaseRepository<Employee>
    {
        public RepositoryDb(AdoDbContext _context) : base(_context)
        {
        }

        public override IEnumerable<Employee> FindAll()
        {
            IEnumerator<Employee> employees = _dbContext.ExecuteReader<Employee>(
                "SELECT EmployeeID, LastName, FirstName, BirthDate FROM Employees"
                );
            _dbContext.Dispose();
            while (employees.MoveNext())
            {
                yield return employees.Current;
            }
        }

        public override Employee? FindById(dynamic id)
        {
            SqlCommandParameterModel[] parameters = new SqlCommandParameterModel[]
            {
                new SqlCommandParameterModel()
                {
                    ParameterName = "@EmployeeID",
                    Value = id,
                    DataType = DbType.Int64,
                },
            };
            SqlCommandModel command = new()
            {
                CommandText = "SELECT EmployeeID, LastName, FirstName, BirthDate FROM Employees WHERE EmployeeID = @EmployeeID",
                CommandType = CommandType.Text,
                CommandParameters = parameters
                
            };
            var employee = _dbContext.ExecuteReader<Employee>(command);
            return employee.MoveNext() ? employee.Current : null;
        }

        public override Employee Create(ref Employee employee)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "insert into employees (LastName,FirstName,BirthDate) values (@lastName,@firstName,@birthDate);",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int32,
                        Value = employee.EmployeeID
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@lastName",
                        DataType = DbType.String,
                        Value = employee.LastName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = employee.FirstName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@birthDate",
                        DataType = DbType.DateTime,
                        Value = employee.BirthDate
                    }
                }
            };

            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();

            return employee;
        }

        public override Employee Update(Employee employee)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "UPDATE employees SET firstName=@firstName WHERE employeeId= @empId",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = employee.FirstName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value = employee.EmployeeID
                    }
                }
            };

            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
            return employee;
        }

        public override void Delete(dynamic id)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "DELETE FROM employees WHERE employeeId=@empId",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value =id
                    }
                }
            };

            _dbContext.ExecuteNonQuery(model);
            _dbContext.Dispose();
        }

        public override async Task<IEnumerable<Employee>> FindAllAsync()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "SELECT EmployeeID, LastName, FirstName, BirthDate FROM Employees",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };
            var data = _dbContext.ExecuteReaderAsync<Employee>(model);
            List<Employee> employees = new List<Employee>();
            _dbContext.Dispose();
            while (await data.MoveNextAsync())
            {
                employees.Add(data.Current);
            }
            return employees;
        }

        public override async IAsyncEnumerable<Employee> FindAllAsyncEnumerable()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "SELECT EmployeeID, LastName, FirstName, BirthDate FROM Employees",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };
            var data = _dbContext.ExecuteReaderAsync<Employee>(model);
            while (await data.MoveNextAsync())
            {
                yield return data.Current;
            }
            _dbContext.Dispose();

        }
    }
}
