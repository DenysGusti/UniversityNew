using Logistics.Domain.States.Abstract;

namespace Logistics.Domain.States.Concrete;

public class ExitState : State
{
    public override bool IsExitState() => true;
}