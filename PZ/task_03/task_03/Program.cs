using System.Diagnostics;
using System.Numerics;
using HDF5CSharp;

namespace task_03;
// Варіант 1
// Для порівняння швидкодії скористатись класом Stopwatch.
// Реалізувати збереження Вашого багатовимірного масиву у HDF5 форматі, використовуючи сторонню бібліотеку.
// Пересвідчитися, що все добре, використовуючити сторонній переглядач HDF файлів, наприклад HDF View.
// Зчитати з файлу двовимірний прямокутний масив у власному форматі, реалізувати функцію перетворення
// в зубчастий (jagged) формат. Порівняти швидкодію множення матриць в прямокутному форматі та в зубчастому форматі.

internal static class Constants
{
    public const int NumberOfTests = 1_000_000;
}
internal static class ArrayExtensions
{
    public static void Print<T>(this T[,] array)
    {
        for (var i = 0; i < array.GetLength(0); ++i)
        {
            for (var j = 0; j < array.GetLength(1); ++j)
                Console.Write($"{array[i, j]}\t");
            Console.WriteLine();
        }
    }
    
    public static void Print<T>(this IEnumerable<T[]> array)
    {
        foreach (var row in array)
        {
            foreach (var value in row)
                Console.Write($"{value}\t");
            Console.WriteLine();
        }
    }
    
    public static T[,] ReadTwoDimensionalArrayFromFile<T>(string filePath) where T: IParsable<T>
    {
        var lines = File.ReadAllLines(filePath);
        var (numRows, numCols) = (lines.Length, lines[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
        var array = new T[numRows, numCols];
        for (var i = 0; i < numRows; ++i)
        {
            var values = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (var j = 0; j < numCols; ++j)
                array[i, j] = T.Parse(values[j], null);
        }
        return array;
    }
    
    public static T[][] ConvertToJaggedArray<T>(this T[,] twoDimensionalArray)
    {
        var (numRows, numCols) = (twoDimensionalArray.GetLength(0), twoDimensionalArray.GetLength(1));
        var jaggedArray = new T[numRows][];
        for (var i = 0; i < numRows; ++i)
        {
            jaggedArray[i] = new T[numCols];
            for (var j = 0; j < numCols; ++j)
                jaggedArray[i][j] = twoDimensionalArray[i, j];
        }
        return jaggedArray;
    }
}

internal static class MatricesMultiplication
{
    public static T[,] MultiplyMatrices<T>(T[,] matrix1, T[,] matrix2) where T: INumber<T>
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            throw new ArgumentException("Invalid matrix dimensions.");

        var (numRows, numCols) = (matrix1.GetLength(0), matrix2.GetLength(1));
        var result = new T[numRows, numCols];

        for (var i = 0; i < numRows; ++i)
            for (var j = 0; j < numCols; ++j)
                for (var k = 0; k < matrix1.GetLength(1); ++k)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
        
        return result;
    }
    
    public static T[][] MultiplyMatrices<T>(T[][] matrix1, T[][] matrix2) where T: INumber<T>
    {
        if (matrix1[0].Length != matrix2.Length)
            throw new ArgumentException("Invalid matrix dimensions.");
        
        var (numRows, numCols) = (matrix1.Length, matrix2[0].Length);
        var result = new T[numRows][];
        for (var i = 0; i < numRows; ++i)
            result[i] = new T[numCols];
        
        for (var i = 0; i < numRows; ++i)
            for (var j = 0; j < numCols; ++j)
                for (var k = 0; k < matrix1[0].Length; ++k)
                    result[i][j] += matrix1[i][k] * matrix2[k][j];
        
        return result;
    }
}

internal static class Program
{
    private static void TestMultiplication<T>(T[,] matrix1, T[,] matrix2) where T: INumber<T>
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        
        Stopwatch stopWatch = new();
        var ans = MatricesMultiplication.MultiplyMatrices(matrix1, matrix2);

        stopWatch.Start();
        for (var i = 0; i < Constants.NumberOfTests; ++i)
            MatricesMultiplication.MultiplyMatrices(matrix1, matrix2);
        stopWatch.Stop();
        
        Console.WriteLine();
        ans.Print();
        Console.WriteLine($"general runtime of T[, ]; {Constants.NumberOfTests} tests: {stopWatch.Elapsed.TotalSeconds}s\n");
        Console.WriteLine();
    }
    
    private static void TestMultiplication<T>(T[][] matrix1, T[][] matrix2) where T: INumber<T>
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        
        Stopwatch stopWatch = new();
        var ans = MatricesMultiplication.MultiplyMatrices(matrix1, matrix2);

        stopWatch.Start();
        for (var i = 0; i < Constants.NumberOfTests; ++i)
            MatricesMultiplication.MultiplyMatrices(matrix1, matrix2);
        stopWatch.Stop();
        
        Console.WriteLine();
        ans.Print();
        Console.WriteLine($"general runtime of T[][]; {Constants.NumberOfTests} tests: {stopWatch.Elapsed.TotalSeconds}s\n");
    }
    
    private static void CompareMatricesMultiplicationSpeed()
    {
        var array1 = new [,]
        {
            {01, 02, 03, 04, 05, 06, 07, 08, 09, 10},
            {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
            {31, 32, 33, 34, 35, 36, 37, 38, 39, 40},
            {41, 42, 43, 44, 45, 46, 47, 48, 49, 50},
            {51, 52, 53, 54, 55, 56, 57, 58, 59, 60},
            {61, 62, 63, 64, 65, 66, 67, 68, 69, 70},
            {71, 72, 73, 74, 75, 76, 77, 78, 79, 80},
            {81, 82, 83, 84, 85, 86, 87, 88, 89, 90},
            {91, 92, 93, 94, 95, 96, 97, 98, 99, 100},
        };
        var array2 = new [,]
        {
            {01, 02, 03, 04, 05, 06, 07, 08, 09, 10},
            {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
            {31, 32, 33, 34, 35, 36, 37, 38, 39, 40},
            {41, 42, 43, 44, 45, 46, 47, 48, 49, 50},
            {51, 52, 53, 54, 55, 56, 57, 58, 59, 60},
            {61, 62, 63, 64, 65, 66, 67, 68, 69, 70},
            {71, 72, 73, 74, 75, 76, 77, 78, 79, 80},
            {81, 82, 83, 84, 85, 86, 87, 88, 89, 90},
            {91, 92, 93, 94, 95, 96, 97, 98, 99, 100},
        };
        
        TestMultiplication(array1, array2);
        TestMultiplication(array1.ConvertToJaggedArray(), array2.ConvertToJaggedArray());
    }
    
    public static void Main(string[] args)
    {
        var array = ArrayExtensions.ReadTwoDimensionalArrayFromFile<int>(@"array.txt");
        Console.WriteLine("\nMultidimensional array:");
        array.Print();

        var newArray = array.ConvertToJaggedArray();
        Console.WriteLine("\nJagged array:");
        newArray.Print();

        var fileId = Hdf5.CreateFile("jaggedArray.hdf5");
        Hdf5.WriteObject(fileId, newArray, "jaggedArray");
        Hdf5.CloseFile(fileId);

        CompareMatricesMultiplicationSpeed();
    }
}