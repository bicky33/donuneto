using d4.Quiz;
using System.CommandLine;
namespace d4;
internal class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new()
        {
            new SUV("D 1001 UM", 2010, 350_000_000, 3_500_000, 4, new DateTime(2023, 01, 10), 500_000, 150_000),
            new SUV("D 1002 UM", 2010, 350_000_000, 3_500_000, 4, new DateTime(2023, 01, 10), 500_000, 150_000),
            new SUV("D 1003 UM", 2015, 350_000_000, 3_500_000, 5, new DateTime(2023, 01, 12), 500_000, 150_000),
            new SUV("D 1004 UM", 2015, 350_000_000, 3_500_000, 5, new DateTime(2023, 01, 13), 500_000, 150_000),
            new Taxi("D 11 UK", 2002, 175_000_000, 1_750_000,  4, new DateTime(2023, 01, 12), 45, 4_500),
            new Taxi("D 12 UK", 2015, 225_000_000, 2_250_000, 4,  new DateTime(2023, 01, 13), 75, 4_500),
            new Taxi("D 13 UK", 2020, 275_000_000, 2_750_000, 4,  new DateTime(2023, 01, 13), 90, 4_500),
            new Jet("ID8089", 2015, 150_000_000_000, 150_000_000, 12, new DateTime(2022, 12, 23), 35_000_000, 15_000_000, 25_000_000),
            new Jet("ID8099", 2015, 175_000_000_000, 175_000_000, 12, new DateTime(2022, 12, 25), 55_000_000, 25_000_000, 25_000_000),
        };

        IVehicleImpl vehicleImpl = new(vehicles);
        //Console.WriteLine("Info Summary");
        //Console.WriteLine($"Total Vehicles: {vehicleImpl.GetTotalVehicle(),-10}");
        //Console.WriteLine($"Total SUVs: {vehicleImpl.GetTotalVehicle(VehicleType.SUV),-10}");
        //Console.WriteLine($"Total Income from SUVs: {vehicleImpl.GetTotalIncomeVechicle(VehicleType.SUV),-10}");
        //Console.WriteLine($"Total Income from Taxis: {vehicleImpl.GetTotalIncomeVechicle(VehicleType.TAXI),-10}");
        //Console.WriteLine($"Total Income from Private Jets: {vehicleImpl.GetTotalIncomeVechicle(VehicleType.PrivateJet),-10}");
        //Console.WriteLine($"Total Income from all Vehicles: {vehicleImpl.GetTotalIncomeVechicle(),-10}");

        var all = new Option<bool>(
            name: "--all",
            description: "All Type"
        );

        var suv = new Option<bool>(
            name: "--suv",
            description: "SUVs Type"
        );

        var jet = new Option<bool>(
            name: "--jet",
            description: "Private Jet Type"
        );

        var taxi = new Option<bool>(
            name: "--taxi",
            description: "Taxi Type"
        );

        var total = new Command("total", "Total Vehicles")
        {
            suv,
            jet,
            taxi,
            all
        };

        total.SetHandler((suv, jet, taxi, all) =>
        {
            if (all)
            {
                Console.WriteLine($"Total all juragan's vehicle is {vehicleImpl.GetTotalVehicle()}");
            }

            if (suv)
            {
                Console.WriteLine($"Total all juragan's SUV is {vehicleImpl.GetTotalVehicle(VehicleType.SUV)}");
            }

            if (jet)
            {
                Console.WriteLine($"Total all juragan's jet {vehicleImpl.GetTotalVehicle(VehicleType.PrivateJet)}");
            }

            if (taxi)
            {
                Console.WriteLine($"Total juragan's taxi is {vehicleImpl.GetTotalVehicle(VehicleType.TAXI)}");
            }

        }, suv, jet, taxi, all );
        var income = new Command("income", "Total Income")
        {
            suv,
            jet,
            taxi,
            all,
        };

        income.SetHandler((suv, jet, taxi, all) =>
        {
            if (all)
            {
                Console.WriteLine($"Total income is {vehicleImpl.GetTotalIncomeVechicle()}");
            }

            if (suv)
            {
                Console.WriteLine($"Total income juragan's SUV is {vehicleImpl.GetTotalIncomeVechicle(VehicleType.SUV)}");
            }

            if (jet)
            {
                Console.WriteLine($"Total income juragan's jet {vehicleImpl.GetTotalIncomeVechicle(VehicleType.PrivateJet)}");
            }

            if (taxi)
            {
                Console.WriteLine($"Total income juragan's taxi is {vehicleImpl.GetTotalIncomeVechicle(VehicleType.TAXI)}");
            }

        }, suv, jet, taxi, all);

        var rootCommand = new RootCommand("Hallo Juragan Let's Cook");
        rootCommand.AddCommand(total);
        rootCommand.AddCommand(income);
        rootCommand.InvokeAsync(args);
    }
}