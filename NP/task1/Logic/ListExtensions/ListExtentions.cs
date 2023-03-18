using System.Text;
using task1.Factory;
using task1.Shipping;

namespace task1.ListExtensions;

public static class ListExtensions
{
    public static void PrintAllToTerminal(this List<Shipping.Shipping> list, bool reversed)
    {
        if (!reversed)
        {
            foreach (var shipping in list)
            {
                Console.WriteLine(shipping);
            }
        }
        else
        {
            foreach (var shipping in Enumerable.Reverse(list))
            {
                Console.WriteLine(shipping);
            }
        }
    }

    public static void PrintAllToFile(this List<Shipping.Shipping> list, bool reversed, string file)
    {
        using var sw = File.AppendText(file);
        sw.WriteLine();
        if (!reversed)
        {
            foreach (var shipping in list)
            {
                sw.WriteLine(shipping);
            }
        }
        else
        {
            foreach (var shipping in Enumerable.Reverse(list))
            {
                sw.WriteLine(shipping);
            }
        }
    }
    
    private static IShippingFactory ConfigureFactory(string type) =>
        type switch
        {
            "sea" or "Ship" => new SeaShippingFactory(),
            "road" or "Truck" => new RoadShippingFactory(),
            "rail" or "Train" => new RailShippingFactory(),
            "air" or "Plane" => new AirShippingFactory(),
            _ => throw new ArgumentException($"unexpected type: {type}", nameof(type))
        };

    private static Shipping.Shipping CreateShipping(string[] input) =>
        new(int.Parse(input[0]), ulong.Parse(input[12]), new Goods(input[1..3]),
            new Warehouse(input[3..6]), new Warehouse(input[6..9]),
            new Driver(input[9..12]), ConfigureFactory(input[13]));

    public static Shipping.Shipping GetShippingFromTerminal(this List<Shipping.Shipping> list)
    {
        StringBuilder s = new((list.Count + 1).ToString());
        Console.WriteLine("Enter goods name and quantity, t:");
        s.Append(' ' + Console.ReadLine());
        Console.WriteLine("Departure warehouse:\nEnter warehouse name, city and capacity, t:");
        s.Append(' ' + Console.ReadLine());
        Console.WriteLine("Departure warehouse:\nEnter warehouse name, city and capacity, t:");
        s.Append(' ' + Console.ReadLine());
        Console.WriteLine("Enter driver's name, surname, age:");
        s.Append(' ' + Console.ReadLine());
        Console.WriteLine("Enter duration, days:");
        s.Append(' ' + Console.ReadLine());
        Console.WriteLine("Enter shipping type:");
        s.Append(' ' + Console.ReadLine());
        return CreateShipping(s.ToString().Split());
    }

    public static void UpdateFromFile(this List<Shipping.Shipping> list, string file)
    {
        list.Clear();
        using StreamReader sr = new(file);
        while (!sr.EndOfStream)
        {
            list.Add(CreateShipping(sr.ReadLine()!.Split()));
        }
    }
    
    public static void UpdateToFile(this List<Shipping.Shipping> list, string file)
    {
        using StreamWriter sw = new(file);
        foreach (var shipping in list)
        {
            Console.WriteLine(shipping.GetRepresentation());
            sw.WriteLine(shipping.GetRepresentation());
        }
    }
}