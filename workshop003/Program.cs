// && - команда И
// || - команда ИЛИ
// bool flag = a > b; // если a > b, то флаг = true, иначе false
// int input = a > b ? 1 : 2; // переменная input принмает значения: "1" - если "a > b"; и "2" - если "a <= b"; 
// "?" = "if", замена "{}" - то, что мы будем получать; 
// ":" = "else";

internal class Program
{
    // static int DO(int index)
    // {
    //     return index *= index;
    // }
    private static void Main(string[] args)
    {
        //     int a = 10;
        //     int b = 15;
        //     int c = 20;
        //     int x = 0;
        //     bool flag = a > b;
        //     int index = a > b ? DO(a) : DO(b);
        //     Console.WriteLine(index);
        //     if (a > b && a > c || a == x)
        //     {

        //     }
        while (true) // применяем Math Класс https://docs.microsoft.com/ru-ru/dotnet/api/system.math?view=netcore-1.1
        {
            Console.Clear(); // Очищаем консоль
            Console.WriteLine("Введите любое целое число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(number) + " - Выводим модуль числа " + number + "\n"); // Модуль числа
            Console.WriteLine(Math.Sqrt(number) + " - Выводим корень квадратный числа " + number + "\n"); // Корень квадратный числа
            Console.WriteLine(Math.Round(Math.Sqrt(number), 1) + " - Округляем корень квадратный числа " + number + "\n"); // Округление квадратного корня числа, "1" - до одного символа после запятой
            Console.WriteLine("Введите число, обозначающее степень, в которую мы будем возводить число " + number);
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(number, pow) + " - Возводим в степень " + pow + " число " + number + "\n"); // Возведение в степень числа, "pow" - в какую
            Console.WriteLine("Продолжаем?\nНажми 'y' если ДА или 'n' если НЕТ");
            if (Console.ReadLine() == "n") break;
        }
    }
}