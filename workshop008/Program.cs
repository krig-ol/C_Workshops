using System;

// Урок 8. Как не нужно писать код. Часть 2

string[,] zero = {{"-","-","-"},
                  {"|"," ","|"},
                  {"|"," ","|"},
                  {"|"," ","|"},
                  {"-","-","-"}};

string[,] one = {{" ","/"," "},
                 {"/","|"," "},
                 {" ","|"," "},
                 {" ","|"," "},
                 {" ","|"," "}};

string[,] two = {{" ","-","-"},
                 {"/"," ","/"},
                 {" ","/"," "},
                 {"/"," "," "},
                 {"-","-","-"}};

string[,] three = {{"-","-","-"},
                   {"|","|","|"},
                   {"|","|","|"},
                   {"|","|","|"},
                   {"-","-","-"}};

string[,] four = {{"|"," ","|"},
                  {"|"," ","|"},
                  {"|","-","|"},
                  {" "," ","|"},
                  {" "," ","|"}};

string[,] DoubleNumber = {{" "," "," "," "," "," "},
                          {" "," "," "," "," "," "},
                          {" "," "," "," "," "," "},
                          {" "," "," "," "," "," "},
                          {" "," "," "," "," "," "}};
string[,] DoubleArray(string[,] array1, string[,] array2)
{
    int indexSize = DoubleNumber.GetLength(1) / 2;
    for (int i = 0; i < DoubleNumber.GetLength(0); i++)
    {
        for (int j = 0; j < indexSize; j++)
        {
            DoubleNumber[i, j] = array1[i, j];
            DoubleNumber[i, indexSize + j] = array2[i, j];
        }
    }
    return DoubleNumber;
}
void Timer(int index)
{
    switch (index)
    {
        case 0:
            WriteArray(zero); break;
        case 1:
            WriteArray(one); break;
        case 2:
            WriteArray(two); break;
        case 3:
            WriteArray(three); break;
        case 4:
            WriteArray(four); break;
        case 11:
            WriteArray(DoubleArray(one, one)); break;
        default:
            index = 0; break;
    }
    if (index != 0)
    {
        index--;
        System.Threading.Thread.Sleep(1000); // ожидание 1000 милисекунд = 1 секунда
        Timer(index);
    }
}
void WriteArray(string[,] array) // Вывод двумерного массива
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Timer(4);