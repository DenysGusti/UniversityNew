using CarRental.Domain.Models;

namespace CarRental.Domain.Repositories.Abstract
{
    public interface IBusRepository
    {
        void Add(Bus car);
        Bus[] GetAll();
        int Count();
    }
}