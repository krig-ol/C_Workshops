internal class Program
{
    private static void Main(string[] args)
    {
        // Урок 2. Массивы и функции в программировании (Домашнее задание)
        Console.Clear(); // Очищаем консоль

        Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\n");

        // 456 -> 5
        // 782 -> 8
        // 918 -> 1

        Console.Write("Введте трёхзначное число: ");
        int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
        // string threeDigitNumber = Console.ReadLine();

        while (threeDigitNumber >= 100)
            threeDigitNumber /= 10;
        int secondDigit = threeDigitNumber % 10;

        Console.WriteLine("Вторая цифра этого числа -> " + secondDigit + "\n");
        // Console.WriteLine("Вторая цифра этого числа -> " + threeDigitNumber[1]);

        Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.\n");

        // // 645 -> 5
        // // 78 -> третьей цифры нет
        // // 32679 -> 6

        Console.Write("Введите число: ");

        string? number = Console.ReadLine();

        if (number!.Length > 2)
            Console.WriteLine("третья цифра -> " + number[2] + "\n");
        else
            Console.WriteLine("-> третьей цифры нет\n");

        Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.\n");

        // // 6 -> да
        // // 7 -> да
        // // 1 -> нет

        Console.Write("Введите цифру, от 1 до 7, обозначающую день недели: ");

        int dayNumber = Convert.ToInt32(Console.ReadLine());

        void CheckingTheDayOfTheWeek(int dayNumber)
        {
            if (dayNumber == 1)
                Console.WriteLine(dayNumber + "й день недели это понедельник, " + "это будний день -> нет, это не выходной день\n");
            else if (dayNumber == 2)
                Console.WriteLine(dayNumber + "й день недели это вторник, " + "это будний день -> нет, это не выходной день\n");
            else if (dayNumber == 3)
                Console.WriteLine(dayNumber + "й день недели это среда, " + "это будний день -> нет, это не выходной день\n");
            else if (dayNumber == 4)
                Console.WriteLine(dayNumber + "й день недели это четверг, " + "это будний день -> нет, это не выходной день\n");
            else if (dayNumber == 5)
                Console.WriteLine(dayNumber + "й день недели это пятница, " + "это будний день -> нет, это не выходной день\n");
            else if (dayNumber == 6)
                Console.WriteLine(dayNumber + "й день недели это суббота, " + "этот день выходной -> Ура!\n");
            else if (dayNumber == 7)
                Console.WriteLine(dayNumber + "й день недели это воскресенье, " + "этот день выходной -> Ура!\n");
            else if (dayNumber < 1 || dayNumber > 7)
                Console.WriteLine("Вы ввели " + dayNumber + " - эта цифра не день недели\n");
        }
        CheckingTheDayOfTheWeek(dayNumber);
    }
}