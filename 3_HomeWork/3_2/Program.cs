// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"Таблица кубов чисел от 1 до введенного числа -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

Console.WriteLine("Введите число");
Squares(int.Parse(Console.ReadLine()));
