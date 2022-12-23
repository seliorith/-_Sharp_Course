// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.


int NumPow(int A, int B)
{
    if (B == 0) return 1;
    return NumPow(A, B - 1) * A;    
}

Console.WriteLine(NumPow(3, 5));
Console.WriteLine(NumPow(2, 3));
