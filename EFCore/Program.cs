using EFLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static IConfiguration Configuration;
    private static DbContextOptionsBuilder<DBContext> _optionsBuilder;
    private static void Main(string[] args)
    {
        BuildConfiguration();
        Console.WriteLine(Configuration.GetConnectionString("AdventureWorks2019"));
        ListPerson();
    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        Configuration = builder.Build();
        BuildOptions();
    }

    private static void BuildOptions()
    {
        _optionsBuilder = new DbContextOptionsBuilder<DBContext>();
        _optionsBuilder.UseSqlServer(Configuration.GetConnectionString("AdventureWorks2019"));
    }

    static void ListPerson()
    {
        using (var db = new DBContext(_optionsBuilder.Options))
        {
            var people = db.People.Take(5).ToList();
            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName}-{item.LastName}");
            }
        }
    }

    static void CrudPerson()
    {
        using var db = new DBContext(_optionsBuilder.Options);
        BusinessEntity business = new();
        db.Add(business);
        db.SaveChanges();

        Person person = new()
        {
            FirstName = "A",
            LastName = "B",
            PersonType = "EM",
            BusinessEntity = business
        };
        db.Add(person);
        db.SaveChanges();

        var data = db.People.Find(business);
        db.SaveChanges();
        Console.WriteLine($"New Person: {person.BusinessEntityId} {person.FirstName} {person.LastName}");

        //Find Person
        var foundPerson = db.People.Find(business.BusinessEntityId);
        if (foundPerson != null)
            Console.WriteLine($"New Person: {foundPerson.BusinessEntityId} {foundPerson.FirstName} {foundPerson.LastName}");

        //Update person
        person.FirstName = "aph";
        person.LastName = "fou";
        db.Update(person);
        Console.WriteLine($"Updated Person: {person.BusinessEntityId} {person.FirstName} {person.LastName}");

        //delete person
        db.People.Remove(foundPerson);
        db.SaveChanges();
        Console.WriteLine($"Removed Person: {foundPerson.BusinessEntityId} {foundPerson.FirstName} {foundPerson.LastName}");


    }
}