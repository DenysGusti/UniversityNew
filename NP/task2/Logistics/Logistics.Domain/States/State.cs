using Logistics.Domain.Exceptions;

namespace Logistics.Domain.States;

public abstract class State
{
    protected Menu? Menu;
    
    public void SetMenu(Menu menu) => Menu = menu;
    
    public virtual void Handle0() => throw new NotHandledException(nameof(Handle0) + " - Invalid menu option!");
    
    public virtual void Handle1() => throw new NotHandledException(nameof(Handle1) + " - Invalid menu option!");
    
    public virtual void Handle2() => throw new NotHandledException(nameof(Handle2) + " - Invalid menu option!");
    
}