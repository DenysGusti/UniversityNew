using CarRental.Domain.Factories.Abstract;
using CarRental.Domain.Repositories.Abstract;
using CarRental.Domain.Repositories.Concreate;

namespace CarRental.Domain.Factories.Concreate
{
    internal class MemoryRepositoryFactory : IRepositoryFactory
    {
        public ICarRepository GetCarRepository()
        {
            return new MemoryCarRepository();
        }

        public IBusRepository GetBusRepository()
        {
            return new MemoryBusRepository();
        }
    }
}