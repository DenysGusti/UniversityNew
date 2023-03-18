using CarRental.Domain.Exceptions;
using System;

namespace CarRental.Domain.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        private int _year;
        public int Year
        {
            get 
            { 
                return _year;
            }
            set
            {
                if (value < 0)
                    throw new ModelStateException("Year is negative");
                _year = value;
            }
        }
        public float? MaxSpeed { get; set; } //Nullable<float> // null
        public override string ToString() => $"{Make} - {Model} - {Year}{(MaxSpeed.HasValue ? " - " + MaxSpeed : "")}";
    }
}