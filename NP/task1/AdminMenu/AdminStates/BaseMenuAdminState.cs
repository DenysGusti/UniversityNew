using task1.States;

namespace AdminMenu.AdminStates;

public class BaseMenuAdminState : BaseMenuState
{
    public override void Handle1() => _menu!.TransitionTo(new ShippingMenuAdminState());
}