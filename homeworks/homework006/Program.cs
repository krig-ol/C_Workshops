Console.Clear();

Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n");

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите число, задающее количество чисел, вводимых с клавиатуры: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[numberM];

void InputNumbers(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i + 1}е число: ");
        arrayM[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int GreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(numberM);

Console.WriteLine($"Чисел больше нуля было введено: {GreaterThanZero(arrayM)} \n");


Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,"
+ " заданных уравнениями: \ny = k1 * x + b1, \ny = k2 * x + b2; \nзначения b1, k1, b2 и k2 задаются пользователем.\n");

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine($"\nДве прямые параллельны.\n");
}
else
{
    double x = Math.Round(((-b2 + b1) / (-k1 + k2)), 1);
    Console.WriteLine($"x = (-b2 + b1) / (-k1 + k2) = {x}");
    double y = Math.Round((k2 * x + b2), 1);
    Console.WriteLine($"y = k2 * x + b2 = {y}");

    Console.WriteLine($"\nДве прямые пересекаются в точке с координатами (X: {x}; Y: {y})\n");
}