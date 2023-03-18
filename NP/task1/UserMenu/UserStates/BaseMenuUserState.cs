using task1.States;

namespace UserMenu.UserStates;

public class BaseMenuUserState : BaseMenuState
{
    public override void Handle1() => _menu!.TransitionTo(new ShippingMenuUserState());
}