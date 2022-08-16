Console.Clear(); // Очищаем консоль
Console.WriteLine("Урок 3. Массивы и функции в программировании (Домашнее задание)\n");

Console.WriteLine("Задача 19\nНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.\n");

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
M:
string? number = Console.ReadLine();
Console.WriteLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.\n");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.\n");
}

if (number!.Length == 5)
    {
        CheckingNumber(number);
    }
while (number!.Length < 5 || number!.Length > 5)
    {
        Console.Write($"Введите пятизначное число: ");
        goto M;
    }



Console.WriteLine("Задача 21:\nНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.\n");

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Coordinate("X", "A");
int y1 = Coordinate("Y", "A");
int z1 = Coordinate("Z", "A");
int x2 = Coordinate("X", "B");
int y2 = Coordinate("Y", "B");
int z2 = Coordinate("Z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"\nДлина отрезка = {segmentLength}\n");



Console.WriteLine("Задача 23:\nНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("\nВведите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

void Cube(int[] numb)
{
    int cube = 1;
    int length = numb.Length;
    while (cube < length)
    {
        numb[cube] = Convert.ToInt32(Math.Pow(cube, 3));
        cube++;
    }
}

void PrintArray(int[] mass)
{
    int count = mass.Length;
    int index = 1;
    while (index < count)
    {
        Console.WriteLine($"Куб числа {index} = {mass[index]}");
        index++;
    }
}

int[] array = new int[numb + 1];
Cube(array);
PrintArray(array);