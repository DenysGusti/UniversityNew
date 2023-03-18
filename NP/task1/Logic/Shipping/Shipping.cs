using task1.Factory;
using task1.Transport;

namespace task1.Shipping;

public class Shipping
{
    private readonly int _order;
    private readonly ulong _duration;
    private readonly Goods _goods;
    private readonly Warehouse _warehouseFrom;
    private readonly Warehouse _warehouseTo;
    private readonly Driver _driver;

    private readonly IShippingFactory _factory;
    private readonly ITransport _transport;

    public Shipping(int order, ulong duration, Goods goods, Warehouse warehouseFrom, Warehouse warehouseTo,
        Driver driver, IShippingFactory factory) 
        => (_order, _duration, _goods, _warehouseFrom, _warehouseTo, _driver, _factory, _transport) 
            = (order,duration, goods, warehouseFrom, warehouseTo, driver, factory, factory!.CreateTransport());

    public override string ToString() => $"N{_order} goods: {_goods}; from: {_warehouseFrom}; to: {_warehouseTo}; " +
                                         $"driver: {_driver}; duration: {_duration} days; transport: {_transport.Type}";
    
    public string GetRepresentation()
        => $"{_order} {_goods.GetRepresentation()} {_warehouseFrom.GetRepresentation()} " +
           $"{_warehouseTo.GetRepresentation()} {_driver.GetRepresentation()} {_duration} {_transport.Type}";
}