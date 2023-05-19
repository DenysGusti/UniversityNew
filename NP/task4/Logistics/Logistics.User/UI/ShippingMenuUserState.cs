using Logistics.Domain.Exceptions;
using Logistics.Domain.Models;
using Logistics.Domain.States;

namespace Logistics.User.UI;

public class ShippingMenuUserState : State
{
    public ShippingMenuUserState() => ShowInfo();
    
    private static void ShowInfo() => Console.WriteLine("\nSelect an option:\n" +
                                                        "0. Exit.\n" +
                                                        "1. Print all shippings to terminal.");
    
    public override void Handle0() => throw new ExitException("Exit from program.");
    
    public override void Handle1()
    {
        Menu!.Repository.GetAll().Print();
        ShowInfo();
    }
}

