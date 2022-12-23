// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.


void ValuesSet(int num)
{
    if (num == 0) return;
    ValuesSet(num - 1);
    Console.Write($"{num}, ");
}

ValuesSet(5);
