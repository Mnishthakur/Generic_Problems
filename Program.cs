using System;
namespace ProblemsInGenerics;

class Program
{
    static T FindMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
    {
        return (value1.CompareTo(value2) <= 0 && value1.CompareTo(value3) <= 0) ? value1 :
               (value2.CompareTo(value1) <= 0 && value2.CompareTo(value3) <= 0) ? value2 :
               value3;
    }

    static void Main()
    {
        float f1 = 2.6f;
        float f2 = 5.8f;
        float f3 = 9.7f;

        float minimum = FindMinimum(f1, f2, f3);

        Console.WriteLine("The minimum value is: " + minimum);
    }
}
