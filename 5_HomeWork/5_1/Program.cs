// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-100, 100);
    return arr;
}

void SumOddNum(int[] arr)
{
    int OddNum = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        OddNum += arr[i];
    }
    Console.WriteLine($"Сумма нечетных чисел: {OddNum}");
}

int[] arr = Mass(int.Parse(Console.ReadLine()));
Print(arr);
SumOddNum(arr);
