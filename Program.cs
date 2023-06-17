using System;
namespace ProblemsInGenerics;

class DeleteArray<T>
{
    public void DeleteMethod(ref T[] array, T element)
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

        DeleteArray<int> intDeleteArray = new DeleteArray<int>();
        intDeleteArray.DeleteMethod(ref intArray, 3);

        DeleteArray<double> doubleDeleteArray = new DeleteArray<double>();
        doubleDeleteArray.DeleteMethod(ref doubleArray, 2.2);

        DeleteArray<char> charDeleteArray = new DeleteArray<char>();
        charDeleteArray.DeleteMethod(ref charArray, 'd');

        Console.WriteLine("\nArrays after deletion:");
        Console.WriteLine("Integers: " + string.Join(", ", intArray));
        Console.WriteLine("Doubles: " + string.Join(", ", doubleArray));
        Console.WriteLine("Characters: " + string.Join(", ", charArray));
    }
}
