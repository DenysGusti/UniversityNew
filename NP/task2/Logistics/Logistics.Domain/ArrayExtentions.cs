using Logistics.Domain.Models;

namespace Logistics.Domain;

public static class ArrayExtensions
{
    public static void Print(this IEnumerable<Shipping> array)
    {
        foreach (var shipping in array)
        {
            Console.WriteLine(shipping);
        }
    }
}