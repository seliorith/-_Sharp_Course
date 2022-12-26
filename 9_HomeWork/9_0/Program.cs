// Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "2, 4"
// N = 8 -> "2, 4, 6, 8"

int SetEvenNaturalNumbers(int num)
{
    if (num <= 1) return num;
    if (num % 2 == 0)
    {
        Console.Write($"{num}, ");
        return SetEvenNaturalNumbers(num - 2);
    }
    return SetEvenNaturalNumbers(num - 1);
}

SetEvenNaturalNumbers(5);
Console.WriteLine();
SetEvenNaturalNumbers(8);
