using Logistics.Domain.Enums;
using Logistics.Domain.Exceptions;
using Logistics.Domain.Factories.RepositoryFactories.Concrete;
using Logistics.Domain.Loggers;
using Logistics.Domain.Models;
using Logistics.Domain.Repositories.Abstract;
using static Logistics.Domain.GlobalSettings.GlobalSettings;

namespace Logistics.Domain.States;

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

    public void HandleInput()
    {
        while (true)
        {
            try
            {
                var option = int.Parse(Console.ReadLine()!);
                switch (option)
                {
                    case 0:
                        Request0();
                        break;
                    case 1:
                        Request1();
                        break;
                    case 2:
                        Request2();
                        break;
                    default:
                        throw new ArgumentException($"Wrong number option ({option})!");
                }
            }
            catch (ExitException e)
            {
                Console.WriteLine(e.Message);
                TxtLogger.GetInstance(LogErrorsFile).LogError(e);
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                TxtLogger.GetInstance(LogErrorsFile).LogError(e);
            }
        }
    }
}