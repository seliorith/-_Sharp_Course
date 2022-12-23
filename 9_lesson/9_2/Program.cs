// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


int SumNum(int num)
{
    if (num == 0) return 0;
    return SumNum(num / 10) + num % 10;    
}

Console.WriteLine(SumNum(453));
Console.WriteLine(SumNum(45));
