// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

string Num(int num)
{   
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "Число не трехзначное!";
}

Console.WriteLine("Введите трехзначное число");
Console.WriteLine(Num(int.Parse(Console.ReadLine())));
