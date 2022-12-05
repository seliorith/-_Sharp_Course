// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Line3D(float x1, float y1, float z1, float x2, float y2, float z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.WriteLine(Line3D(3, 6, 8, 2, 1, -7));
Console.WriteLine(Line3D(7, -5, 0, 1, -1, 9));
