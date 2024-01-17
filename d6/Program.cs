using d6.DbContext;
using d6.Entity;
using d6.Repository;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static IConfiguration Configuration;
     static async Task Main(string[] args)
    {
        BuildConfiguration();
        Console.WriteLine(Configuration.GetConnectionString("NorthWindDS"));
        var connection = Configuration.GetConnectionString("NorthWindDS");
        var dapperContext = new DapperDbContext(connection);
        IDapperRepository<Supplier> supplierDapperRepository = new SupplierDapperRepository(dapperContext);
        IDapperRepository<Customer> customerDapperRepository = new CustomerDapperRepository(dapperContext);
        IDapperRepository<Employee> employeeDapperRepository = new EmployeeDapperRepository(dapperContext);
        //var customers = supplierDapperRepository.FindAll();
        //foreach (var item in customers)
        //{
        //    Console.WriteLine(item.ToString());
        //}
        //Supplier supplier = new()
        //{
        //    SupplierID= 1,
        //    ContactName = "Nguyễn Văn A",
        //    CompanyName = "Công ty TNHH A",
        //    ContactTitle = "Giám đốc"
        //};
        //supplierDapperRepository.Update(supplier);
        //supplierDapperRepository.Delete(1);
        //Supplier supplier = new()
        //{
        //    SupplierID = 1,
        //    ContactName = "Nguyễn Văn A",
        //    CompanyName = "Công ty TNHH A",
        //    ContactTitle = "Giám đốc"
        //};
        //supplierDapperRepository.Create(ref supplier);

        var employees = employeeDapperRepository.FindAll();
        foreach (var item in employees)
        {
            Console.WriteLine(item.ToString());
        }







        //var adoContext = new AdoDbContext(connection);
        //IRepository<Employee> repositoryDb = new RepositoryDb(adoContext);
        //IRepository<Customer> customerRepository = new CustomerRepository(adoContext);
        //IRepository<Supplier> supplierRepository = new SupplierRepository(adoContext);
        //var employees = repositoryDb.FindAll();
        //while (employees.MoveNext())
        //{
        //    var emp = employees.Current;
        //    Console.WriteLine(emp.ToString());
        //}
        //var emp = repositoryDb.FindById(1);
        //Console.WriteLine(emp.ToString());
        //var customers = customerRepository.FindAll();
        //foreach (var item in customers)
        //{
        //    Console.WriteLine(item.ToString());
        //}
        //var customer = customerRepository.FindById("ANATR");
        //Console.WriteLine(customer.ToString());
        //var suppliers = supplierRepository.FindAll();
        //foreach (var item in suppliers)
        //{
        //    Console.WriteLine(item.ToString());
        //}
        //var supplier = supplierRepository.FindById(1);
        //Console.WriteLine(supplier.ToString());
        //var employeeAsync = repositoryDb.FindAllAsyncEnumerable();
        //await foreach (var item in employeeAsync)
        //{
        //    Console.WriteLine(item.ToString());
        //}

    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        Configuration = builder.Build();
    }
}