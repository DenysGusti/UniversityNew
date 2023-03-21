﻿using Logistics.Domain;
using Logistics.Domain.Models;
using Logistics.Domain.States.Abstract;
using Logistics.Domain.States.Concrete;

namespace Logistics.Admin.UI;

public class ShippingMenuAdminState : State
{
    public ShippingMenuAdminState() => ShowInfo();

    private static void ShowInfo() => Console.WriteLine("\nSelect an option:\n" +
                                                        "0. Exit.\n" +
                                                        "1. Print all shippings to terminal.\n" +
                                                        "2. Add new shipping from terminal.");

    public override void Handle0() => Menu!.TransitionTo(new ExitState());
    public override void Handle1()
    {
        Menu!.Repository.GetAll().Print();
        ShowInfo();
    }
    public override void Handle2()
    {
        Menu!.Repository.Create(new Shipping().GetShippingFromTerminal());
        ShowInfo();
    }
}

