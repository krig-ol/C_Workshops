Console.Clear();

Console.WriteLine("Задача 47.\nЗадайте двумерный массив размером m x n, заполненный случайными вещественными числами.\n");

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива (m): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array47 = new double[row, column];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array47[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write("{0,5:F1}", array47[i, j]);
    }
    Console.WriteLine();
}

Console.Write("Нажмите <Enter> для продолжения... ");
while (Console.ReadKey().Key != ConsoleKey.Enter)
Console.Clear();


Console.WriteLine("\nЗадача 50. Напишите программу, которая на вход принимает число" +
" и возвращает значение этого элемента в двумерном массиве или же указание, что такого элемента нет.\n");

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Задаём массив с параметрами из прошлой задачи:\nКоличество строк массива (m):" +
$" {row}\nКоличество столбцов массива (n): {column}\n");

int[,] array50 = new int[row, column];
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int? digit = null;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array50[i, j] = (new Random().Next(0, 10));
        Console.Write("{0,3:F0}", array50[i, j]);
    }
    Console.WriteLine();
}
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (array50[i, j] == number)
        {
            digit = array50[i, j];
            break;
        }
    }
}
if (digit != null)
{
    Console.WriteLine($"Число {number} есть в массиве\n");
}
else
{
    Console.WriteLine($"Числа {number} нет в массиве\n");
}

Console.Write("Нажмите <Enter> для продолжения... ");
while (Console.ReadKey().Key != ConsoleKey.Enter)
Console.Clear();


Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n");

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array52 = new int[row, column];
Console.Write("Берём массив с параметрами из задачи №47:\nКоличество строк массива (m):" +
$" {row}\nКоличество столбцов массива (n): {column}\n");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array52[i, j] = (new Random().Next(0, 10));
        Console.Write("{0,3:F0}", array52[i, j]);
    }
    Console.WriteLine();
}
Console.Write($"\nCреднее арифметическое элементов:\n");
for (int i = 0; i < column; i++)
{
    double meanNumber = 0;
    for (int j = 0; j < row; j++)
    {
        meanNumber += array52[j, i];
    }
    meanNumber = Math.Round(meanNumber / row, 1);
    Console.WriteLine($"столбца № {i + 1} = {meanNumber}");
}
