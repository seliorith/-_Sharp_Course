// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 645 -> 65
// 782 -> 72
// 918 -> 98

string Num(int num)
{   
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num} -> {num / 100 * 10 + num % 10}";
    return "Число не трехзначное!";       
}

Console.WriteLine("Введите трехзначное число");
Console.WriteLine(Num(int.Parse(Console.ReadLine())));
