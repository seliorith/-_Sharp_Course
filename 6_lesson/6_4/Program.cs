// 4. Напишите программу, которая будет создавать
//    копию заданного массива с помощью поэлементного копирования.

// -----------------------------------------------------1 вариант

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 20) - 10, 2);
    }
    return arr;
}

double[] CopyMass(double[] arr)
{
    int size = arr.Length;
    double[] new_arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        new_arr[i] = arr[i];
    }
    return new_arr;
}

double[] arr_1 = MassNums(5, 1, 11);
Print(arr_1);
double[] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);


// --------------------------------------------------2 вариант


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;
}

int[,] CopyMass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];
    
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            new_arr[i, j] = arr[i, j];
        }        
    }
    return new_arr;
}

int[,] arr_1 = MassNums(2, 5, 1, 11);
Print(arr_1);
int[,] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);

int[,] arr_2 = MassNums(3, 6, 10, 21);
Print(arr_2);
int[,] arr_2_new = CopyMass(arr_2);
Print(arr_2_new);
