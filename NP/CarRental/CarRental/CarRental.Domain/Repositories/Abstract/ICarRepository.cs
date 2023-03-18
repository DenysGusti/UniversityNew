using CarRental.Domain.Models;

namespace CarRental.Domain.Repositories.Abstract
{
    public interface ICarRepository
    {
        void Add(Car car);
        Car[] GetAll();
        int Count();
    }
}