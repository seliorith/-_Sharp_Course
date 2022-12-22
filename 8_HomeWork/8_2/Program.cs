// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (row_size != arr_second.GetLength(0) || column_size != arr_second.GetLength(1)) return pr_matrix;
    
    for (int i = 0; i < row_size; i++)       
        for (int j = 0; j < column_size; j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];            
    return pr_matrix;
}

Console.Write("Введите количество строк 1 матрицы: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 матрицы: ");
int column_1 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

Console.Write("Введите количество строк 2 матрицы: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 матрицы: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_2 = MassNums(row_2, column_2,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.WriteLine();
Print(arr_1);
Print(arr_2);

Console.WriteLine("Произведение двух матриц: ");
Console.WriteLine();
int[,] res_matrix = MultiplyMatrix(arr_1, arr_2);
Print(res_matrix);
