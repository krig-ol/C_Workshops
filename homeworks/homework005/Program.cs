
using System;

// Console.Clear(); // Очищаем консоль
Console.WriteLine("Урок 5. Функции продолжение (Домашнее задание)\n");


Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\n");

// [345, 897, 568, 234] -> 2

Console.WriteLine("С помощью ввода с клавиатуры:\n");

Console.Write("Введите число, задающее количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
Random myRandom = new Random();
int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(100, 999);
    if (array[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}
Console.WriteLine("В массиве [{0}] из " + number + $" случайных чисел - {even} чётные и {odd} нечётные\n", string.Join(", ", array));

Console.WriteLine("С помощью класса Random:\n");

int number1 = new Random().Next(0, 10);
Console.WriteLine($"Случайное число, задающее количество элементов массива: {number1}");

int[] array1 = new int[number1];
Random myRandom1 = new Random();
int even1 = 0;
int odd1 = 0;
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = myRandom1.Next(100, 999);
    if (array1[i] % 2 == 0)
    {
        even1++;
    }
    else
    {
        odd1++;
    }
}
Console.WriteLine("В массиве [{0}] из " + number1 + $" случайных чисел - {even1} чётные и {odd1} нечётные\n", string.Join(", ", array1));


Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\n");

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Найти индексы нечётных позиций

Console.WriteLine("С помощью ввода с клавиатуры:\n");

Console.Write("Введите число, задающее количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[num];
Random rand = new Random();
int oddIndexSum = 0;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(-100, 100); // Заполняем массив
}
for (int i = 1; i < mass.Length; i += 2) // Суммируем элементы нечётных индексов
{
    oddIndexSum += mass[i];
}
Console.WriteLine("В массиве [{0}] из " + num + $" случайных чисел - сумма элементов, стоящих на нечётных позициях = {oddIndexSum}\n", string.Join(", ", mass));

Console.WriteLine("С помощью класса Random:\n");

int num1 = new Random().Next(0, 10);
Console.WriteLine($"Случайное число, задающее количество элементов массива: {num1}");
int[] mass1 = new int[num1];
Random rand1 = new Random();
int oddIndexSum1 = 0;
for (int i = 0; i < mass1.Length; i++)
{
    mass1[i] = rand1.Next(-100, 100); // Заполняем массив
}
for (int i = 1; i < mass1.Length; i += 2) // Суммируем элементы нечётных индексов
{
    oddIndexSum1 += mass1[i];
}
Console.WriteLine("В массиве [{0}] из " + num1 + $" случайных чисел - сумма элементов, стоящих на нечётных позициях = {oddIndexSum1}\n", string.Join(", ", mass1));


Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\n");

// [3 7 22 2 78] -> 76

Console.Write("Введите число, задающее количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[numb];
Random myRand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToDouble(myRand.Next(0, 100)); // Заполняем массив
}
double minNumber = arr[0];
// Console.WriteLine(minNumber);
double maxNumber = arr[0];
// Console.WriteLine(maxNumber);
for (int i = 0; i < arr.Length; i++) // Ищем Min/Max
{
    if (minNumber > arr[i])
    {
        minNumber = arr[i];
    }
    if (maxNumber < arr[i])
    {
        maxNumber = arr[i];
    }
}
double difference = maxNumber - minNumber;
Console.WriteLine("В массиве [{0}] из " + numb + $" случайных вещественных чисел - разница между между максимальным числом '{maxNumber}' и минимальным числом '{minNumber}' равна '{difference}'\n", string.Join(" ", arr));
