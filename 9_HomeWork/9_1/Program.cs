// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalElements(int M, int N)
{
    if (M > N) return 0;
    return SumNaturalElements(M + 1, N) + M;
}

Console.WriteLine(SumNaturalElements(1, 15));
Console.WriteLine(SumNaturalElements(4, 8));
