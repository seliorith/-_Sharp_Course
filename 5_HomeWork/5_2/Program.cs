// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)    
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    
    return arr;
}

void DiffMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])        
            n_max = arr[i];
        
        else if (n_min > arr[i])        
            n_min = arr[i];        
    }

    Console.Write($"Максимальный элемент массива: {n_max}, минимальный элемент массива: {n_min}. ");
    Console.WriteLine($"Разница: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));
Print(arr_1);
DiffMaxMin(arr_1);
