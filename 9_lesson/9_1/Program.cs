// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.


void Spacing(int M, int N)
{
    if (N < M) return;
    Spacing(M, N - 1);
    Console.Write($"{N}, ");
}

Spacing(1, 5);
