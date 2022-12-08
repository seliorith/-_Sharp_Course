// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumPow(int a, int b)
{
    int num_pow = 1;
    int degree = b;

    for (int i = 1; i <= degree; i++)
    {
        num_pow *= a;
    }
    return num_pow;
}

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(NumPow(a, b));
