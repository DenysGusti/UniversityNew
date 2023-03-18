using CarRental.Domain.Models;
using CarRental.Domain.Repositories.Abstract;

namespace CarRental.Domain.Repositories.Concreate
{
    internal class MemoryBusRepository : IBusRepository
    {
        public void Add(Bus car)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public Bus[] GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}