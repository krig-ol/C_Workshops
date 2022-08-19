using System;

Console.Clear(); // Очищаем консоль
Console.WriteLine("Урок 4. Функции продолжение (Домашнее задание)\n");

Console.WriteLine("Задача 25:\nНапишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\n");

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degree = numberA;

for (int i = 1; i < numberB; i++)
{
    degree = degree * numberA;
}
Console.WriteLine($"{numberA} в степени {numberB} равно: {degree}\n");


Console.WriteLine("Задача 27:\nНапишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\n");

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (numb > 0)
{
    int num = numb % 10;
    numb = numb / 10;
    sum = sum + num;
}
Console.WriteLine($"Сумма цифр в числе равна: {sum}\n");


Console.WriteLine("Задача 29:\nНапишите программу, которая задаёт массив из N элементов и выводит их на экран.\n");

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("С помощью ввода с клавиатуры:\n");

Console.Write("Введите число, задающее количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
Random myRandom = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 100);
}
Console.WriteLine("Mассивом из " + number + " случайных чисел будет: [{0}]\n", string.Join(", ", array));

Console.WriteLine("С помощью класса Random:\n");

int number1 = new Random().Next(0, 10);
Console.WriteLine($"Случайное число, задающее количество элементов массива: {number1}");

int[] array1 = new int[number1];
Random myRandom1 = new Random();
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = myRandom1.Next(0, 100);
}
Console.WriteLine("Mассивом из " + number1 + " случайных чисел будет: [{0}]\n", string.Join(", ", array1));

Console.WriteLine("С помощью цикла foreach и ввода с клавиатуры чисел через запятую:\n");

Console.Write("Введите через запятую числа для создания массива: ");

string? number2 = Console.ReadLine(); // 1, 2, 5, 7, 19
string[] array2 = new string[number2!.Length];
int index = 0;
foreach (var item in number2) // 1 , 2 , 5 , 7 , 1 9
{
    if (item != ',' || item != ' ')
    {
        array2[index] += item.ToString(); // складывает числа строки
    }
    else
    {
        index++;
    }
}
Console.Write($"Mассивом введенных чисел '{number2}' будет: [");
for (int i = 0; i <= index - 1; i++)
{
    Console.Write(array2[i] + ", ");
}
Console.Write(array2[index] + "]");
