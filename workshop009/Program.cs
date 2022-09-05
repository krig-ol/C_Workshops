using System;
// Урок 9. Как не нужно писать код. Часть 3

// using System.IO; // Библиотека для работы с файлами
// using System.Text; // Библиотека для работы с текстом

// string root = @"C:\Users\krylov\Documents\Projects\C#\Workshops\workshop009\";
// DirectoryInfo directory = new DirectoryInfo(root);
// FileInfo fileInfo = new FileInfo(root + "file.txt");
// FileStream fs = fileInfo.Create();
// FileInfo[] files = directory.GetFiles();
// foreach (FileInfo file in files)
// {
//     fs.Write(Encoding.UTF8.GetBytes(file.FullName.ToString() + " - Полный путь к файлу\n"));
//     fs.Write(Encoding.UTF8.GetBytes(file.CreationTime.ToString() + " - Время создания файла\n"));
//     fs.Write(Encoding.UTF8.GetBytes(file.LastAccessTime.ToString() + " - Время последнего обращения к файлу\n"));
//     fs.Write(Encoding.UTF8.GetBytes(file.LastWriteTime.ToString() + " - Время вызова файла\n"));
//     fs.Write(Encoding.UTF8.GetBytes(file.Length.ToString() + " байт - Размер файла\n"));
//     fs.Write(Encoding.UTF8.GetBytes(file.Name.ToString() + " - Имя файла\n"));
//     fs.Write(Encoding.UTF8.GetBytes(file.DirectoryName.ToString() + " - Название директории, в которой лежит файл\n"));
//     fs.Write(Encoding.UTF8.GetBytes("===================================================" + "\n"));
// }
// // fs.Write(Encoding.UTF8.GetBytes("Hello, World!"));
// fs.Close();


Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= n * n)
{
    array[i, j] = temp;
    if (i <= j + 1 && i + j < n - 1) j++;
    else if (i < j && i + j >= n - 1) i++;
    else if (i >= j && i + j > n - 1) j--;
    else i--;
    temp++;
}
for (int c = 0; c < array.GetLength(0); c++)
{
    for (int d = 0; d < array.GetLength(1); d++)
    {
        Console.Write($"{array[c, d]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();