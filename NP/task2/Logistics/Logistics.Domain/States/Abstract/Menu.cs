using Logistics.Domain.Enums;
using Logistics.Domain.Factories.RepositoryFactories.Concrete;
using Logistics.Domain.Models;
using Logistics.Domain.Repositories.Abstract;

namespace Logistics.Domain.States.Abstract;

public class Menu
{
    private State? _state;
    public readonly IRepository<Shipping> Repository;

    public Menu(State state, RepositoryFactoryType repositoryType)
    {
        TransitionTo(state);
        Repository = new RepositoryFactoryProvider<Shipping>(repositoryType).ConfigureFactory().CreateRepository();
        HandleInput();
    }

    public void TransitionTo(State state)
    {
        _state = state;
        _state.SetMenu(this);
    }
    
    public void Request0() => _state!.Handle0();
    
    public void Request1() => _state!.Handle1();
    
    public void Request2() => _state!.Handle2();
    
    public void Request3() => _state!.Handle3();
    
    public void Request4() => _state!.Handle4();
    
    public void Request5() => _state!.Handle5();
    
    public void Request6() => _state!.Handle6();
    
    public void Request7() => _state!.Handle7();
    
    public void Request8() => _state!.Handle8();
    
    public void Request9() => _state!.Handle9();
    
    public void Request10() => _state!.Handle10();
    
    public void Request11() => _state!.Handle11();
    
    public void Request12() => _state!.Handle12();
    
    public void Request13() => _state!.Handle13();

    public void HandleInput()
    {
        while (true)
        {
            try
            {
                switch (int.Parse(Console.ReadLine()!))
                {
                    case 0:
                        Request0();
                        if (_state!.IsExitState()) return;
                        break;
                    case 1:
                        Request1();
                        break;
                    case 2:
                        Request2();
                        break;
                    case 3:
                        Request3();
                        break;
                    case 4:
                        Request4();
                        break;
                    case 5:
                        Request5();
                        break;
                    case 6:
                        Request6();
                        break;
                    case 7:
                        Request7();
                        break;
                    case 8:
                        Request8();
                        break;
                    case 9:
                        Request9();
                        break;
                    case 10:
                        Request10();
                        break;
                    case 11:
                        Request11();
                        break;
                    case 12:
                        Request12();
                        break;
                    case 13:
                        Request13();
                        break;
                    default:
                        Console.WriteLine("wrong option!");
                        break;
                }
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}