/*
4.11. Побудувати клас для роботи із комплексними числами. Задати методи введення та виведення, піднесення до степеня,
обчислення аргументу і модуля, множення числа на скаляр, перевизначити арифметичні операції (+, -, *, /)
Навести тестові розрахунки, продемонструвати роботу всіх методів класу.
*/

using System.Numerics;

namespace task_04;

using System;

public readonly struct MyComplex
{
    public double Real { get; init; }
    public double Imaginary { get; init; }

    private const double Epsilon = 2.2204460492503131e-016;
    
    
    public MyComplex(double real, double imaginary) => (Real, Imaginary) = (real, imaginary);
    

    public override string ToString() => $"{Real}{Imaginary:+0.################;-0.################}i";
    
    public static MyComplex Parse(string s) =>
        TryParse(s, out var result) ? result :
            throw new OverflowException("Impossible to parse the string into MyComplex");

    public static bool TryParse(string s, out MyComplex result)
    {
        if (!(s[1..].Contains('+') || s[1..].Contains('-')) || s[^1] != 'i')
        {
            result = default;
            return false;
        } 
        
        var sign = 1 + (s[1..].Contains('+') ? s[1..].IndexOf('+') : s[1..].IndexOf('-'));
        
        var parseReal = double.TryParse(s[..sign], null, out var real);
        var parseImag = double.TryParse(s[sign..^1], null, out var imag);
        result = new MyComplex(real, imag);
        
        return parseReal && parseImag;
    }
    
    
    public double Abs => Math.Sqrt(Real * Real + Imaginary * Imaginary);

    public double Arg => Math.Atan2(Imaginary, Real);
    
    public static MyComplex FromPolarCoordinates(double abs, double arg) =>
        new(abs * Math.Cos(arg), abs * Math.Sin(arg));
    
    
    public bool Equals(MyComplex other) => Real.Equals(other.Real) && Imaginary.Equals(other.Imaginary);

    public override bool Equals(object? obj) => obj is MyComplex other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Real, Imaginary);
    
    
    public static bool operator ==(MyComplex left, MyComplex right) =>
        Math.Abs(left.Real - right.Real) < Epsilon && Math.Abs(left.Imaginary - right.Imaginary) < Epsilon;

    public static bool operator !=(MyComplex left, MyComplex right) =>
        Math.Abs(left.Real - right.Real) > Epsilon || Math.Abs(left.Imaginary - right.Imaginary) > Epsilon;
    
    // the conjugate of a+bi is a-bi
    public static MyComplex Conjugate(MyComplex value) => new(value.Real, -value.Imaginary);
    
    // the reciprocal of a+bi is 1/(a+bi)
    public static MyComplex Reciprocal(MyComplex value) => 1 / value;

    public static MyComplex operator +(MyComplex value) => value;
    
    public static MyComplex operator ++(MyComplex value) => new(value.Real + 1, value.Imaginary);

    public static MyComplex operator +(MyComplex left, MyComplex right) =>
        new(left.Real + right.Real, left.Imaginary + right.Imaginary);
    
    public static MyComplex operator +(MyComplex left, double right) => new(left.Real + right, left.Imaginary);
    
    public static MyComplex operator +(double left, MyComplex right) => new(left + right.Real, right.Imaginary);
    
    
    public static MyComplex operator -(MyComplex value) => new(-value.Real, -value.Imaginary);
    
    public static MyComplex operator --(MyComplex value) => new(value.Real - 1, value.Imaginary);

    public static MyComplex operator -(MyComplex left, MyComplex right) =>
        new(left.Real - right.Real, left.Imaginary - right.Imaginary);
    
    public static MyComplex operator -(MyComplex left, double right) => new(left.Real - right, left.Imaginary);
    
    public static MyComplex operator -(double left, MyComplex right) => new(left - right.Real, -right.Imaginary);
    

    // (a + bi)(c + di) = (ac - bd) + (bc + ad)i
    public static MyComplex operator *(MyComplex left, MyComplex right) =>
        new(left.Real * right.Real - left.Imaginary * right.Imaginary, 
            left.Imaginary * right.Real + left.Real * right.Imaginary);
    
    public static MyComplex operator *(MyComplex left, double right) =>
        new(left.Real * right, left.Imaginary * right);

    public static MyComplex operator *(double left, MyComplex right) =>
        new(left * right.Real, left * right.Imaginary);
    
    // (a + bi)/(c + di) = (ac + bd)/(c^2 + d^2) + (bc - ad)/(c^2 + d^2)i
    public static MyComplex operator /(MyComplex left, MyComplex right) =>
        new(
            (left.Real * right.Real + left.Imaginary * right.Imaginary) /
                (right.Real * right.Real + right.Imaginary * right.Imaginary), 
            (left.Imaginary * right.Real - left.Real * right.Imaginary) /
                (right.Real * right.Real + right.Imaginary * right.Imaginary)
            );
    
    public static MyComplex operator /(MyComplex left, double right) =>
        new(left.Real / right, left.Imaginary / right);
    
    public static MyComplex operator /(double left, MyComplex right) =>
        new(left * right.Real / (right.Real * right.Real + right.Imaginary * right.Imaginary),
            -left * right.Imaginary / (right.Real * right.Real + right.Imaginary * right.Imaginary));
    

    /*
     v^p =
     abs(v)^p * e^{i * arg(v) * p} =
     e^{ln(abs(v)) * p + i * arg(v) * p} =
     e^{p * [ln(abs(v)) + i * arg(v)]} =
     e^{[Re(p) + i * Im(p)] * [ln(abs(v)) + i * arg(v)]} =
     e^{[Re(p) * ln(abs(v)) - Im(p) * arg(v)] + i * [Im(p) * ln(abs(v))]} = 
     e^{Re(p) * ln(abs(v)} * e^{-Im(p) * arg(v)} * e^{i * [Im(p) * ln(abs(v)) + Re(p) * arg(v)]} = 
     [abs(v)^Re(p) * e^{-Im(p) * arg(v)}] * [e^{i * [Re(p) * arg(v) + Im(p) * ln(abs(v))]}]
    */
    public static MyComplex Pow(MyComplex value, MyComplex power)
    {
        if (power == new MyComplex(0, 0))
            return new MyComplex(1, 0);
        
        if (value == new MyComplex(0, 0))
            return new MyComplex(0, 0);

        return FromPolarCoordinates(
            Math.Pow(value.Abs, power.Real) * Math.Exp(-power.Imaginary * value.Arg),
            power.Real * value.Arg + power.Imaginary * Math.Log(value.Abs)
            );
    }

    public static MyComplex Pow(MyComplex value, double power) => Pow(value, new MyComplex(power, 0));
}

internal static class Program
{
    public static void Main(string[] args)
    {
        // for tests
        Complex t1 = new(3, 4);
        Complex t2 = new(-5, -12);
        
        Console.WriteLine("Parsing & ToString:");
        var c1 = MyComplex.Parse("3+4i");
        Console.WriteLine(
            @$"{(MyComplex.TryParse("-5-12i", out var c2) ? "Successful" : "Not successful")} parsing"
            );
        Console.WriteLine($"c1 = {c1}\nc2 = {c2}");
        // var c3 = MyComplex.Parse(Console.ReadLine()!); // [optional +; -][Re][+; -][Im]i
        
        Console.WriteLine("\n== & !=:");
        Console.WriteLine(MyComplex.Parse("+3+4i") != c1);
        Console.WriteLine(MyComplex.FromPolarCoordinates(c2.Abs, c2.Arg) == c2);
        
        Console.WriteLine("\n_z & z^(-1)");
        Console.WriteLine(MyComplex.Conjugate(new MyComplex{Real = 1, Imaginary = 1}));
        Console.WriteLine(Complex.Conjugate(new Complex(1, 1)));  // test
        Console.WriteLine(MyComplex.Reciprocal(new MyComplex{Real = 0, Imaginary = 1}));
        Console.WriteLine(Complex.Reciprocal(new Complex(0, 1)));  // test
        
        Console.WriteLine("\n+ & -");
        Console.WriteLine(+c1);
        Console.WriteLine(+t1);  // test
        Console.WriteLine(-c2);
        Console.WriteLine(-t2);  // test
        
        Console.WriteLine("\n++ & --");
        Console.WriteLine(++c1);
        Console.WriteLine(++t1);  // test
        Console.WriteLine(--c2);
        Console.WriteLine(--t2);  // test
        c1--;
        t1--;
        c2++;
        t2++;

        Console.WriteLine("\nz1 + z2 & z2 + z1");
        Console.WriteLine(c1 + c2);
        Console.WriteLine(t1 + t2);  // test
        Console.WriteLine(c2 + c1);
        Console.WriteLine(t2 + t1);  // test
        
        Console.WriteLine("\nz + real number & real number + z");
        Console.WriteLine(c1 + 5);
        Console.WriteLine(t1 + 5);  // test
        Console.WriteLine(5 + c1);
        Console.WriteLine(5 + t1);  // test
        
        Console.WriteLine("\nz1 - z2 & z2 - z1");
        Console.WriteLine(c1 - c2);
        Console.WriteLine(t1 - t2);  // test
        Console.WriteLine(c2 - c1);
        Console.WriteLine(t2 - t1);  // test

        Console.WriteLine("\nz - real number & real number - z");
        Console.WriteLine(c2 - 13);
        Console.WriteLine(t2 - 13);  // test
        Console.WriteLine(13 - c2);
        Console.WriteLine(13 - t2);  // test

        Console.WriteLine("\nz1 * z2 & z2 * z1");
        Console.WriteLine(c1 * c2);
        Console.WriteLine(t1 * t2);  // test
        Console.WriteLine(c2 * c1);
        Console.WriteLine(t2 * t1);  // test
        
        Console.WriteLine("\nz * real number & real number * z");
        Console.WriteLine(c1 * 5);
        Console.WriteLine(t1 * 5);  // test
        Console.WriteLine(5 * c1);
        Console.WriteLine(5 * t1);  // test
        
        Console.WriteLine("\nz1 / z2 & z2 / z1");
        Console.WriteLine(c1 / c2);
        Console.WriteLine(t1 / t2);  // test
        Console.WriteLine(c2 / c1);
        Console.WriteLine(t2 / t1);  // test
        
        Console.WriteLine("\nz / real number & real number / z");
        Console.WriteLine(c2 / 13);
        Console.WriteLine(t2 / 13);  // test
        Console.WriteLine(13 / c2);
        Console.WriteLine(13 / t2);  // test
        
        Console.WriteLine("\nPow trivial");
        
        Console.WriteLine(MyComplex.Pow(new MyComplex(0, 0), 1));
        Console.WriteLine(Complex.Pow(new Complex(0, 0), 1));  // test
        Console.WriteLine(MyComplex.Pow(new MyComplex(1, 0), 0));
        Console.WriteLine(Complex.Pow(new Complex(1, 0), 0));  // test
        Console.WriteLine(MyComplex.Pow(new MyComplex(0, 0), 0));
        Console.WriteLine(Complex.Pow(new Complex(0, 0), 0));  // test
        Console.WriteLine(MyComplex.Pow(new MyComplex(0, 0), 0));
        Console.WriteLine(Complex.Pow(new Complex(0, 0), 0));  // test
        
        Console.WriteLine("\nPow real");
        Console.WriteLine(MyComplex.Pow(c1, 2));
        Console.WriteLine(Complex.Pow(t1, 2));  // test
        Console.WriteLine(MyComplex.Pow(c2, 2));
        Console.WriteLine(Complex.Pow(t2, 2));  // test
        Console.WriteLine(MyComplex.Pow(new MyComplex(-7, 24), 0.5));
        Console.WriteLine(Complex.Pow(new Complex(-7, 24), 0.5));  // test
        Console.WriteLine(MyComplex.Pow(new MyComplex(-119, 120), 0.5));
        Console.WriteLine(Complex.Pow(new Complex(-119, 120), 0.5));  // test
        
        Console.WriteLine("\nPow complex");
        Console.WriteLine(MyComplex.Pow(c1, c2));
        Console.WriteLine(Complex.Pow(t1, t2));  // test
        Console.WriteLine(MyComplex.Pow(c2, c1));
        Console.WriteLine(Complex.Pow(t2, t1));  // test
    }
}