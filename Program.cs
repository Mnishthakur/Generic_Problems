using System;
namespace ProblemsInGenerics;

class DeleteArray
{
    public static void DeleteMethod<T>(ref T[] array, T element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            T[] newArray = new T[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            array = newArray;
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
