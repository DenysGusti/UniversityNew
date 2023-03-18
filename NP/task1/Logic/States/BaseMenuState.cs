namespace task1.States;

public abstract class BaseMenuState : State
{
    protected BaseMenuState() => ShowInfo();
    
    private static void ShowInfo() => Console.WriteLine("\nSelect an option:\n" +
                                                       "0. Exit.\n" +
                                                       "1. Interact with shippings.");

    public override void Handle0() => _menu!.TransitionTo(new ExitState());
}