using CarRental.Domain.Enums;
using CarRental.Domain.Factories.Abstract;
using CarRental.Domain.Factories.Concreate;
using System;

namespace CarRental.Domain.Factories
{
    public class FactoryProvider
    {
        private FactoryType type;

        public FactoryProvider(FactoryType type)
        {
            this.type = type;
        }

        public IRepositoryFactory GetRepositoryFactory()
        {
            if (type == FactoryType.Memory)
                return new MemoryRepositoryFactory();
            else
                throw new Exception("Wrong factory type");
        }
    }
}
