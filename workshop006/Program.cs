// Урок 6. Двумерные массивы и рекурсия

Console.Clear();
Console.WriteLine("Контрольная работа");

Console.WriteLine("Задача 35:\nЗадайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].\n");

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
Random random = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 300);
    if (array[i] > 10 && array[i] < 100)
        count++;
}
static void BubbleSort(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        for (int j = 0; j < Array.Length - 1; j++)
        {
            if (Array[j] > Array[j + 1])
            {
                int temp = Array[j];
                Array[j] = Array[j + 1];
                Array[j + 1] = temp;
            }
        }
    }
}
BubbleSort(array);
Console.WriteLine("В массиве из 123 случайных чисел:\n[{0}]\n" + $"количество элементов массива, значения которых лежат в отрезке от 10 до 99 равно '{count}'\n", string.Join(", ", array));


Console.WriteLine("Задача 37:\nНайдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.\n");

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите чётное число, задающее количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NewArray(int number, int min, int max)
{
    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    return array;
}
string PrintArray(int[] array)
{
    string result = string.Empty;
    result += string.Join(", ", array);
    return result;
}
int[] mass = NewArray(number, 1, 10);

string Multiplicator(int[] array)
{
    string result = string.Empty;
    int multiplication = 0;
    int j = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length / 2)
        {
            multiplication = array[i] * array[j];
            result += $"{array[i]} x {array[j]} = {multiplication}; ";
            j--;
        }
    }
    return result;
}
Console.WriteLine("В одномерном массиве:\n[" + PrintArray(mass) + $"]\nпроизведением пар чисел будет\n{Multiplicator(mass)}\n");
