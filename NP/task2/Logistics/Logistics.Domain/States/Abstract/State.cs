namespace Logistics.Domain.States.Abstract;

public abstract class State
{
    protected Menu? Menu;

    public void SetMenu(Menu menu) => Menu = menu;

    public virtual bool IsExitState() => false;

    public virtual void Handle0() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle1() => throw new NotImplementedException("Invalid menu option!");
    
    public virtual void Handle2() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle3() => throw new NotImplementedException("Invalid menu option!");
    
    public virtual void Handle4() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle5() => throw new NotImplementedException("Invalid menu option!");
    
    public virtual void Handle6() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle7() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle8() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle9() => throw new NotImplementedException("Invalid menu option!");
    
    public virtual void Handle10() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle11() => throw new NotImplementedException("Invalid menu option!");
    
    public virtual void Handle12() => throw new NotImplementedException("Invalid menu option!");

    public virtual void Handle13() => throw new NotImplementedException("Invalid menu option!");
}