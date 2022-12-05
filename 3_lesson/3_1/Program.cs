// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

void Coordinates(string num)
{
    if (num == "I")
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (num == "II")
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (num == "III")
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (num == "IV")
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("The data is not correct!");
    }
}

Coordinates("I");
Coordinates("IV");
Coordinates("II");
Coordinates("III");
Coordinates("X");
