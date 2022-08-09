Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число А
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число В

Console.WriteLine("A = " + a + " " + "B = " + b + " -> " + "max = " + Math.Max(a, b) + " min = " + Math.Min(a, b)); // Выводим в консоль MAX и MIN

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите число A1: ");
int a1 = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число A1
Console.Write("Введите число B1: ");
int b1 = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число B1
Console.Write("Введите число C1: ");
int c1 = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число C1

Console.WriteLine("A1 = " + a1 + " " + "B1 = " + b1 + " " + "C1 = " + c1 + " -> " + "max = " + Math.Max(a1, Math.Max(b1, c1))); // Выводим в консоль MAX

Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число
if (num1 % 2 == 0)
{
    Console.WriteLine(num1 + " -> " + "да, число чётное");
}
else
{
    Console.WriteLine(num1 + " -> " + "нет, число нечётное");
}

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); // Вводим с клавиатуры число
int i = 1;
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
	}
	if (i >= num2)
	{
		break;
	}
	i++;
}