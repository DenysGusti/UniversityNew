using System.Text;
using Logistics.Domain.Convertor;
using Logistics.Domain.Enums;
using Logistics.Domain.Factories.ShippingFactories.Concrete;
using Logistics.Domain.Repositories.Abstract;
using Logistics.Domain.ShippingMembers;
using Logistics.Domain.Transport.Abstract;

namespace Logistics.Domain.Models;

public class Shipping: EntityBase, IConvert<Shipping>
{
    public ulong Duration { get; set; }
    public Goods? Goods { get; set; }
    public Warehouse? WarehouseFrom { get; set; }
    public Warehouse? WarehouseTo { get; set; }
    public Driver? Driver { get; set; }
    public ITransport? Transport { get; set; }
    
    public Shipping() {}
    
    public Shipping(int id, ulong duration, Goods goods, Warehouse warehouseFrom, Warehouse warehouseTo, Driver driver,
        ITransport transport) =>
        (Id, Duration, Goods, WarehouseFrom, WarehouseTo, Driver, Transport) =
        (id, duration, goods, warehouseFrom, warehouseTo, driver, transport);
    
    public Shipping Convert(string[] args)
    {
        (Id, Duration, Goods, WarehouseFrom, WarehouseTo, Driver, Transport) =
            (int.Parse(args[0]), ulong.Parse(args[12]), new Goods().Convert(args[1..3]),
                new Warehouse().Convert(args[3..6]), new Warehouse().Convert(args[6..9]),
                new Driver().Convert(args[9..12]),
                new ShippingFactoryProvider(args[13]).ConfigureFactory().CreateTransport());
        return this;
    }
    
    public string GetRepresentation()
        => $"{Id} {Goods!.GetRepresentation()} {WarehouseFrom!.GetRepresentation()} " +
           $"{WarehouseTo!.GetRepresentation()} {Driver!.GetRepresentation()} {Duration} {Transport!.Type}";
    
    public override string ToString() => $"id: {Id}; goods: {Goods}; from: {WarehouseFrom}; to: {WarehouseTo}; " +
                                         $"driver: {Driver}; duration: {Duration} days; transport: {Transport}";
    
    public Shipping GetShippingFromTerminal()
    {
        Console.WriteLine("Enter id:");
        StringBuilder s = new(Console.ReadLine());
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
        Console.WriteLine($"Enter shipping type ({string.Join(", ", Enum.GetValues<ShippingFactoryType>())}): ");
        s.Append(' ' + Console.ReadLine());
        return Convert(s.ToString().Split());
    }
}