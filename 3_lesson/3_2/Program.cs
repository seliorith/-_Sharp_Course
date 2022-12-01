// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

double Distance(float x1, float y1, float x2, float y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    
}

Console.WriteLine(Distance(3, 6, 2, 1));
Console.WriteLine(Distance(7, -5, 1, -1));
