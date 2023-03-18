using CarRental.Domain.Factories;
using CarRental.Domain.Models;
using CarRental.Domain.Repositories.Abstract;
using System;
using CarRental.Domain.Enums;
using static System.Console;

namespace CarRental.Admin.UI
{
    internal class Menu
    {
        private readonly ICarRepository carRepository;

        public Menu()
        {
            var factoryProvider = new FactoryProvider(FactoryType.Memory);
            var factory = factoryProvider.GetRepositoryFactory();

            carRepository = factory.GetCarRepository();
        }

        public void ShowMenu()
        {
            WriteLine("Welcome to CarRental Admin");

            while (ShowMenuOnce())
            { }

            WriteLine("End");
        }

        private bool ShowMenuOnce()
        {
            WriteLine("Select option:\n1. - Add new car.\n2. - Print all cars.\n0. - Exit.");
            string userInput = ReadLine();

            try
            {
                switch (userInput)
                {
                    case "1":
                        AddNewCar();
                        return true;
                    case "2":
                        PrintAllCars();
                        return true;
                    case "0":
                        return false;
                    default:
                        return true;
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Error occurred: {ex.Message}");
                return true;
            }
        }

        private void PrintAllCars()
        {
            var cars = carRepository.GetAll(); // Car[100]

            for (int i = 0; i < carRepository.Count(); i++)
                WriteLine(cars[i]); // Car //WriteLine(cars[i].ToString());
        }

        private void AddNewCar()
        {
            WriteLine("Enter car info:");
            
            WriteLine("Enter make");
            var make = ReadLine();
            
            WriteLine("Enter model");
            var model = ReadLine();
            
            WriteLine("Enter year");
            var year = Convert.ToInt32(ReadLine());

            carRepository.Add(new Car 
            {
                Make = make,
                Year = year,
                Model = model
            });
        }
    }
}
