using System;

class Program
{
    static int[] CreateArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    static void WriteArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
    static int[] Shuffle(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int j = new Random().Next(0, i + 1);
            int number = array[i];
            array[i] = array[j];
            array[j] = number;
        }
        return array;
    }
    static void Main(string[] agrs)
    {
        int[] array = CreateArray(10); // == WriteArray(CreateArray(10));
        WriteArray(array);
        Console.WriteLine();
        array = Shuffle(array);
        WriteArray(array);
    }
}