using task1.ListExtensions;
using task1.States;

namespace UserMenu.UserStates;

public class ShippingMenuUserState : State
{
    public ShippingMenuUserState() => ShowInfo();
    
    private static void ShowInfo() => Console.WriteLine("\nSelect an option:\n" +
                                                        "0. Back.\n" +
                                                        "1. Print all shippings in direct order to terminal.\n" +
                                                        "2. Print all shippings in reverse order to terminal.\n" +
                                                        "3. Print all shippings in direct order to file.\n" +
                                                        "4. Print all shippings in reverse order to file.");

    public override void Handle0() => _menu!.TransitionTo(new BaseMenuUserState());

    public override void Handle1()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToTerminal(false);
        ShowInfo();
    }
    
    public override void Handle2()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToTerminal(true);
        ShowInfo();
    }
    
    public override void Handle3()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToFile(false,
            @"C:\Users\denys\RiderProjects\University\NP\task1\Logic\data\output.txt");
        ShowInfo();
    }
    
    public override void Handle4()
    {
        _menu!._list!.UpdateFromFile(_menu._file);
        _menu._list!.PrintAllToFile(true,
            @"C:\Users\denys\RiderProjects\University\NP\task1\Logic\data\output.txt");
        ShowInfo();
    }
}