using Logistics.Domain;
using Logistics.Domain.Models;
using Logistics.Domain.States.Abstract;
using Logistics.Domain.States.Concrete;

namespace Logistics.User.UI;

public class ShippingMenuUserState : State
{
    public ShippingMenuUserState() => ShowInfo();

    private static void ShowInfo() => Console.WriteLine("\nSelect an option:\n" +
                                                        "0. Exit.\n" +
                                                        "1. Print all shippings to terminal.");

    public override void Handle0() => Menu!.TransitionTo(new ExitState());
    public override void Handle1()
    {
        Menu!.Repository.GetAll().Print();
        ShowInfo();
    }
}

