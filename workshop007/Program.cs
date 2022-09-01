// using System;
// // Разбор задач из контрольной работы

// Console.WriteLine("Задача 35:\nЗадайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].\n");

// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// int[] startArray = GetArray(123, 0, 1000);
// Console.WriteLine($"Количество элементов в отрезке [10;99] = {GetCountElements(startArray, 10, 99)}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int GetCountElements(int[] array, int leftRange, int rigthRange)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item >= leftRange && item <= rigthRange) count++;
//     }
//     return count;
// }

// Console.WriteLine("\nЗадача 37:\nНайдите произведение пар чисел в одномерном массиве." + "\nПарой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.\n");

// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// Console.Write("Введите элементы массива через пробел: ");
// string? elements = Console.ReadLine();
// int[] baseArray = GetArrayFromString(elements!);

// Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

// int[] GetArrayFromString(string stringArray)
// {
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }

// int[] ResultArray(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size++;
//     int[] result = new int[size];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
        
//         result[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
//     return result;
// }


// Урок 7. Как не нужно писать код. Часть 1
// Двумерные массивы...


string[,] matrix = { {"|","-","-","-","-","-","|"},
                     {"|"," "," "," "," "," ","|"},
                     {"|"," "," "," "," "," ","|"},
                     {"|"," "," ","@"," "," ","|"},
                     {"|"," "," "," "," "," ","|"},
                     {"|"," "," "," "," "," ","|"},
                     {"|","_","_","_","_","_","|"}};

int row = 3;
int column = 3;
int oldRow = 0;
int oldColumn = 0;

while (true)
{
    ConsoleKeyInfo key = Console.ReadKey(); 
    matrix[row,column] = " ";
    oldRow = row;
    oldColumn = column;
    if(key.Key == ConsoleKey.W) row--;
    if(key.Key == ConsoleKey.S) row++;
    if(key.Key == ConsoleKey.A) column--;
    if(key.Key == ConsoleKey.D) column++;
    
    if(row > matrix.GetLength(0)-2) row = matrix.GetLength(0)-2;
    if(row < 1) row = 1;

    if(column > matrix.GetLength(1)-2) column = matrix.GetLength(1)-2;
    if(column < 1) column = 1;
    matrix[row,column] = "@";
    WriteMatrix(matrix);
}
static void WriteMatrix(string[,] matrix)
{
    Console.Clear();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == "@") Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(matrix[i,j] + " ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine();
    }
}
