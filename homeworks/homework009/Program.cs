// Урок 9. Как не нужно писать код. Часть 3

Console.Clear();
Console.WriteLine("Задача 64:\nЗадайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.\n");

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int M64 = InputInt("Введите число M: ");
int N64 = InputInt("Введте число N: ");
if (M64 < N64)
{
    Console.WriteLine($"Натуральные числа в интервале от {M64} до {N64}");
    for (int i = M64; i <= N64; i++)
        Console.Write($" {i}");
}
if (M64 > N64)
{
    Console.WriteLine($"Натуральные числа в интервале от {M64} до {N64}");
    for (int i = M64; i >= N64; i--)
        Console.Write($" {i}");
}
else if (M64 == N64)
    Console.WriteLine("M и N равны");

void Enter()
{
Console.Write("\nНажмите <Enter> для продолжения...\n");
while (Console.ReadKey().Key != ConsoleKey.Enter)
    Console.Clear();
    return;
}
Enter();

Console.WriteLine("\nЗадача 66:\nЗадайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n");

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M66 = InputInt("Введите число M: ");
int N66 = InputInt("Введте число N: ");
int total = (N66 + M66) * (N66 - M66 + 1) / 2;
Console.WriteLine($"Сумма натуральных чисел в интервале от {M66} до {N66} = {total}");

Enter();

Console.WriteLine("\nЗадача 68:\nНапишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\n");

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите два положительных числа: M и N.");
int M68 = InputInt("Введите число M: ");
int N68 = InputInt("Введте число N: ");
int AkkermanFunction(int M68, int N68)
{
    if (M68 == 0)
        return N68 + 1;
    if (M68 > 0 && N68 == 0)
        return AkkermanFunction(M68 - 1, 1);
    else
        return AkkermanFunction(M68 - 1, AkkermanFunction(M68, N68 - 1));
}
Console.WriteLine($"A({M68}, {N68}) = {AkkermanFunction(M68, N68)}");
