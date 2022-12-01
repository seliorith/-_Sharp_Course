// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend(int num)
{
    string text = "нет";

    if (num == 7 || num == 6) text = "да";
    Console.WriteLine($"{text}");
}

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
Weekend(int.Parse(Console.ReadLine()));
