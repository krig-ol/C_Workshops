// Урок 8. Как не нужно писать код. Часть 2

Console.Clear();

// // Функция ввода
// int InputInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

Console.WriteLine("Задача 54:\nЗадайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива (m): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array54 = new int[row, column];

RandomNumbersArray(array54);
Console.WriteLine("Задаем двумерный массив случайных чисел:");
WriteArray(array54);

Console.Write("Нажмите <Enter> для продолжения...\n");
while (Console.ReadKey().Key != ConsoleKey.Enter)
    Console.Clear();

for (int i = 0; i < array54.GetLength(0); i++) // Сортировка массива
{
    for (int j = 0; j < array54.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array54.GetLength(1) - 1; z++)
        {
            if (array54[i, z] < array54[i, z + 1]) // От > к <
            {
                int temp = 0;
                temp = array54[i, z];
                array54[i, z] = array54[i, z + 1];
                array54[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine("\nИ упорядочиваем по убыванию элементы каждой строки массива:");
WriteArray(array54);

void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); // Задаем размеры массива
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4:F0}", array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Нажмите <Enter> для продолжения...\n");
while (Console.ReadKey().Key != ConsoleKey.Enter)
    Console.Clear();


Console.WriteLine("\nЗадача 56:\nЗадайте прямоугольный двумерный массив." +
" Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n");

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите число, задающее прямоугольный двумерный массив: ");
int rectangle = Convert.ToInt32(Console.ReadLine());
int[,] array56 = new int[rectangle, rectangle];
RandomNumbersArray(array56);
WriteArray(array56);
SumStringMatrix(array56);
int minSumLine = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < array56.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array56.GetLength(1); j++)
    {
        sum = sum + array56[i, j];
    }
    if (sum < minSumLine)
    {
        minSumLine = sum;
        indexLine++;
    }
}
void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + " ";
    }
    Console.WriteLine($"{index + 1}я строка [ {line}] имеет наименьшую сумму элементов, равную {minsum}.\n");
}
Console.Write("Нажмите <Enter> для продолжения...\n");
while (Console.ReadKey().Key != ConsoleKey.Enter)
    Console.Clear();

Console.WriteLine("\nЗадача 58:\nЗадайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n");

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Матрицы A и B могут быть перемножены, если они совместимы, в том смысле," + 
" что число столбцов матрицы A равно числу строк матрицы B.\n");
Console.Write("Введите число, задающее размеры двух матриц (колличество строк и столбцов): ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] matrixC = new int[size, size];

RandomNumbersArray(matrixA);
RandomNumbersArray(matrixB);

for (int i = 0; i < size; i++) // Цикл для нахождения произведения матриц
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}
Console.Write("\nМатрица - А:\n");
WriteArray(matrixA);
Console.Write("\nМатрица - В:\n");
WriteArray(matrixB);
Console.Write("\nПроизведение матриц А и В:\n");
WriteArray(matrixC);