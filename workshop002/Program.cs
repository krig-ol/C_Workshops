// Создаем консольную текстовую РПГ
class Program //Класс Program указывает на принодлежность к файлу Program.cs
{
    static void WriteSelect(string[] args) // Метод обработки приведенных значений
    {
        for (int i = 0; i < args.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + args[i] + ", ");
        }
        Console.WriteLine(args.Length + " - " + args[args.Length - 1] + ".");
    }
    static void SelectRace() // Выбор расы
    {
        Console.WriteLine("В игре есть персонажи разных рас:");
        string[] namesRace = { "Люди", "Эльфы", "Орки", "Гоблины", "Гномы" };
        WriteSelect(namesRace);
        Console.Write("Выберите вашу расу: ");
        int numberRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса: " + namesRace[numberRace - 1]);
    }
    static void SelectSex() // Выбор пола
    {
        Console.WriteLine("В игре есть персонажи двух полов:");
        string[] selectSex = { "Мужской", "Женский" };
        WriteSelect(selectSex);
        Console.Write("Укажите ваш пол: ");
        int numberSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол: " + selectSex[numberSex - 1]);
    }
    static void SelectClass() // Выбор класса
    {
        Console.WriteLine("В игре есть несолько классов персонажей:");
        string[] selectClass = { "Воин", "Маг", "Бард", "Взломщик", "Паладин", "Друид", "Защитник", "Лучник" };
        WriteSelect(selectClass);
        Console.Write("Укажите класс вашего персонажа: ");
        int numberClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс: " + selectClass[numberClass - 1]);
    }
     static void Main(string[] args)
    {
        SelectRace();
        SelectSex();
        SelectClass();
    }
}