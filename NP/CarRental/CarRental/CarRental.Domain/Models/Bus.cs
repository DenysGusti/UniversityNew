namespace CarRental.Domain.Models
{
    public class Bus
    {
        public string Make { get; set; }
        public override string ToString() => $"{Make}";
    }
}