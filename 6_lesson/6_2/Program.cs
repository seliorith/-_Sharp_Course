// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.


string Binary(int num)
{
    string res = "";

    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

// 12 - 1100, 4 - 100, 45 - 101101
Console.WriteLine(Binary(int.Parse(Console.ReadLine())));
