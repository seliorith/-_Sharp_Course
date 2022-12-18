// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

string FindElement(int[,] arr, int x, int y)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (x > row || x <= 0 || y > column || y <= 0)
        return $"{x} {y} -> нет в массиве";
    return $"Элемент [{x}, {y}] = {arr[x - 1, y - 1]} -> находится в массиве";
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Введите номер строки: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int b = int.Parse(Console.ReadLine());

Console.Write(FindElement(arr_1, a, b));
