using System;
namespace ProblemsInGenerics;

class MinimumFinder<T> where T : IComparable<T>
{
    private T variable1;
    private T variable2;
    private T variable3;

    public MinimumFinder(T variable1, T variable2, T variable3)
    {
        this.variable1 = variable1;
        this.variable2 = variable2;
        this.variable3 = variable3;
    }

    public T TestMinimum()
    {
        return FindMinimum(variable1, variable2, variable3);
    }

    private static T FindMinimum(T value1, T value2, T value3)
    {
        return (value1.CompareTo(value2) <= 0 && value1.CompareTo(value3) <= 0) ? value1 :
               (value2.CompareTo(value1) <= 0 && value2.CompareTo(value3) <= 0) ? value2 :
               value3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;
        int num3 = 8;

        MinimumFinder<int> intMinimumFinder = new MinimumFinder<int>(num1, num2, num3);
        int minimumInt = intMinimumFinder.TestMinimum();
        Console.WriteLine("The minimum integer value is: " + minimumInt);


        string a = "Heyaaaa";
        string b = "Hello";
        string c = "Namaste";

        MinimumFinder<string> stringMinimumFinder = new MinimumFinder<string>(a, b, c);
        string minimumString = stringMinimumFinder.TestMinimum();
        Console.WriteLine("The minimum string value is: " + minimumString);

        float f1 = 2.6f;
        float f2 = 5.8f;
        float f3 = 9.7f;

        MinimumFinder<float> floatMinimumFinder = new MinimumFinder<float>(f1, f2, f3);
        float minimumfloat = floatMinimumFinder.TestMinimum();
        Console.WriteLine{ "The minimum float value is :" + minimumfloat);


        }
    }

}
