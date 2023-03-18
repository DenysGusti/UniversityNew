using CarRental.Domain.Models;
using CarRental.Domain.Repositories.Abstract;

namespace CarRental.Domain.Repositories.Concreate
{
    internal class MemoryCarRepository : ICarRepository
    {
        private readonly Car[] cars;
        int count;

        public MemoryCarRepository()
        {
            cars = new Car[100];
            count = 0;
        }

        public void Add(Car car)
        {
            cars[count++] = car;
        }

        public int Count() => count;

        public Car[] GetAll() => cars;
    }
}