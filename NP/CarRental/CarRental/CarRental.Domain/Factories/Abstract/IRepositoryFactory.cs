using CarRental.Domain.Repositories.Abstract;

namespace CarRental.Domain.Factories.Abstract
{
    public interface IRepositoryFactory
    {
        ICarRepository GetCarRepository();
        IBusRepository GetBusRepository();
    }
}
