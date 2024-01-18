using d6.DbContext;
using d6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.NewRepository
{
    internal class EmployeeNewDapperRepository : NewDapperBaseRepository<Employee>
    {
        public EmployeeNewDapperRepository(NewDapperDbContext _contextDb) : base(_contextDb)
        {
        }

        public override IEnumerable<Employee> FindAll()
        {
            SqlCommandModel model = new()
            {
                CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate FROM Employees"
            };
            IEnumerable<Employee> employees = _contextDB.QueryAll<Employee>(model);
            return employees;
        }

        public override Employee FindById(dynamic id)
        {
            SqlCommandModel model = new()
            {
                CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate FROM Employees WHERE EmployeeID = @EmployeeID",
                CommandType = System.Data.CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel(){ ParameterName = "@EmployeeID", DataType = System.Data.DbType.Int32, Value = id }
                }
            };
            var employee = _contextDB.QuerySingle<Employee>(model);
            return employee;
        }
    }
}
