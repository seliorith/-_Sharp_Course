// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum(int num)
{
    int n_sum = 0;
    
    for (int i = num; num != 0; num /= 10)
        n_sum += num % 10;

    return n_sum;
}

Console.WriteLine("Введите число: ");
Console.WriteLine(SumNum(int.Parse(Console.ReadLine())));
