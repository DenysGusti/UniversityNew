using AdminMenu.AdminStates;
using task1.Shipping;
using task1.States;

Menu menu = new(new BaseMenuAdminState(), new List<Shipping>(), 
    @"C:\Users\denys\RiderProjects\University\NP\task1\Logic\data\shippings.txt");