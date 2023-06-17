using System;
namespace ProblemsInGenerics;

class DeleteArray
{
    public static void DeleteMethod(ref int[] array, int element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }
    }

    public static void DeleteMethod(ref double[] array, double element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }
    }

    public static void DeleteMethod(ref char[] array, char element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

        Console.WriteLine("Original arrays:");
        Console.WriteLine("Integers: " + string.Join(", ", intArray));
        Console.WriteLine("Doubles: " + string.Join(", ", doubleArray));
        Console.WriteLine("Characters: " + string.Join(", ", charArray));

        DeleteArray.DeleteMethod(ref intArray, 3);
        DeleteArray.DeleteMethod(ref doubleArray, 2.2);
        DeleteArray.DeleteMethod(ref charArray, 'd');

        Console.WriteLine("\nArrays after deletion:");
        Console.WriteLine("Integers: " + string.Join(", ", intArray));
        Console.WriteLine("Doubles: " + string.Join(", ", doubleArray));
        Console.WriteLine("Characters: " + string.Join(", ", charArray));
    }
}
