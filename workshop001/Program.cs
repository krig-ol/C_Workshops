// Console.ReadLine() - команда ввода с клавиатуры
// Convert.ToInt32 - преобразование строки в число
// Console.WriteLine() - команда вывода в терминал
// Типы данных: int(цельночисленный), float(число с плавающей запятой - реализует числа одинарной точности),
// string(строка), bool(true/false), double(число с плавающей запятой - реализует числа двойной точности);


// Варианты переноса строки:
// // Первый вариант.
// Console.Write("Здесь находиться длинная строка, ");
// Console.WriteLine("которая не помещается в ширину экрана");
 
// // Второрй вариант.
// Console.WriteLine(@"Здесь находиться длинная строка,
// которая не помещается в ширину экрана");
 
// // Третий вариант.
// Console.WriteLine("Здесь находиться длинная строка, " + 
// "которая не помещается в ширину экрана");


// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(number1 + number2);

// Программа "Угадай число"

int secretNumber = new Random().Next(1, 11);
int attempt = 3;
bool flagWin = false;

while(attempt > 0)
{
    Console.Write("Введите число от одного (1) до десяти (10): ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    attempt -= 1; // attempt--; attempt = attempt - 1
    if (userNumber > secretNumber)
    {
        Console.WriteLine("Секретное число меньше");
        Console.WriteLine("Попыток осталось " + attempt);
    }
    else if (userNumber < secretNumber)
    {
        Console.WriteLine("Секретное число больше");
        Console.WriteLine("Попыток осталось " + attempt);
    }
    else
    {
        Console.WriteLine("Вы угадали секретное число");
        flagWin = true;
        break;
    }
}
if (!flagWin) // !flagWin = flagWin == false
{
    Console.WriteLine("Вы проиграли. Секретное число было: " + secretNumber);
}