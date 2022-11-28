// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Число 1 = {num1} большее");
    Console.WriteLine($"Число 2 = {num2} меньшее");

}
else 
    Console.WriteLine($"Число 2 = {num2} большее");
    Console.WriteLine($"Число 1 = {num1} меньшее");
