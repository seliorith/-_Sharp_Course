// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

void Print(double[,] arr)
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

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);

    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

void ChangeUp(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i,j],arr[j,i]) = (arr[j,i],arr[i,j]);
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Замена невозможна");
    }

}
 

ChangeUp(arr_1);
Print(arr_1);
