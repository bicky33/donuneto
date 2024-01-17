using d5;
using d5.Class;
using d5.Contract;
using d5.Repository;

internal class Program
{
    private static void Main()
    {
        List<Employee> employees = new();
        IRepository<Employee> employeeRepository = new EmployeeRepository();
        Employee newEmployee = new () { 
            EmployeeID = 1, 
            Extension = "test",
            FirstName = "test",
            HireDate = DateTime.Now,
            LastName = "test",
            Location = new Location()
            {
                City = "test",
                Country = "test",
                PostalCode = "test",
                Region = "test"
            },
            Notes = "test",
            PhotoPath = "test",
            ReportsTo = 1,
            TitleOfCourtesy = "test"
        };
        employeeRepository.Save(employees, newEmployee);
        var emp = employeeRepository.FindAll(employees);
        foreach (var item in emp)
        {
            Console.WriteLine(item.ToString());
        }
        newEmployee.FirstName = "test2";
        employeeRepository.Update(employees, newEmployee);
        var getEmpt = employeeRepository.FindById(employees, 1);
        Console.WriteLine(getEmpt.ToString());
        employeeRepository.Delete(employees, getEmpt);
        Console.WriteLine(employees.Count);
        Console.WriteLine("-------------------------");
        List<Customer> customers = new();
        IRepository<Customer> customerRepository = new CustomerRepository();
        Customer newCustomer = new ()
        {
            CustomerID = 1, 
            ContactPerson = new ContactPerson()
            {
                CompanyName = "test",
                ContactName = "test",
                ContactTitle = "test",
                Fax = "test",
                Phone = "test"
            },
            Location = new Location()
            {
                City = "test",
                Country = "test",
                PostalCode = "test",
                Region = "test"
            },
        };
        customerRepository.Save(customers, newCustomer);
        var cust = customerRepository.FindAll(customers);
        foreach (var item in cust)
        {
            Console.WriteLine(item.ToString());
        }
        newCustomer.ContactPerson.CompanyName = "test2";
        customerRepository.Update(customers, newCustomer);
        var getCust = customerRepository.FindById(customers, 1);
        Console.WriteLine(getCust.ToString());
        customerRepository.Delete(customers, getCust);
        Console.WriteLine(customers.Count);
        Console.WriteLine("-------------------------");
        List<Supplier> suppliers = new List<Supplier>();
        IRepository<Supplier> supplierRepository = new SupplierRepository();
        Supplier newSupplier = new ()
        {
            SupplierID = 1, 
            ContactPerson = new ContactPerson()
            {
                CompanyName = "test",
                ContactName = "test",
                ContactTitle = "test",
                Fax = "test",
                Phone = "test"
            },
            Location = new Location()
            {
                City = "test",
                Country = "test",
                PostalCode = "test",
                Region = "test"
            },
            HomePage = "test"
        };
        supplierRepository.Save(suppliers, newSupplier);
        var supp = supplierRepository.FindAll(suppliers);
        foreach (var item in supp)
        {
            Console.WriteLine(item.ToString());
        }
        newSupplier.ContactPerson.CompanyName = "test2";
        supplierRepository.Update(suppliers, newSupplier);
        var getSupp = supplierRepository.FindById(suppliers, 1);
        Console.WriteLine(getSupp.ToString());
        supplierRepository.Delete(suppliers, getSupp);
        Console.WriteLine(suppliers.Count);
        Console.WriteLine("-------------------------");
    }
}