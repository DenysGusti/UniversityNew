using task1.ListExtensions;
using task1.States;

namespace AdminMenu.AdminStates;

public class ShippingMenuAdminState : State
{
    public ShippingMenuAdminState() => ShowInfo();
    
    private static void ShowInfo() => Console.WriteLine("\nSelect an option:\n" +
                                                        "0. Back.\n" +
                                                        "1. Add new shipping from terminal.\n" +
                                                        "2. Print all shippings in direct order to terminal.\n" +
                                                        "3. Print all shippings in reverse order to terminal.\n" +
                                                        "4. Print all shippings in direct order to file.\n" +
                                                        "5. Print all shippings in reverse order to file.");

    public override void Handle0() => _menu!.TransitionTo(new BaseMenuAdminState());

    public override void Handle1()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.Add(_menu._list!.GetShippingFromTerminal());
        _menu._list!.UpdateToFile(_menu._file);
        ShowInfo();
    }

    public override void Handle2()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToTerminal(false);
        ShowInfo();
    }
    
    public override void Handle3()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToTerminal(true);
        ShowInfo();
    }
    
    public override void Handle4()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToFile(false,
            @"C:\Users\denys\RiderProjects\University\NP\task1\Logic\data\output.txt");
        ShowInfo();
    }
    
    public override void Handle5()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToFile(true,
            @"C:\Users\denys\RiderProjects\University\NP\task1\Logic\data\output.txt");
        ShowInfo();
    }
}

