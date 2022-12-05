// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindrome(int n)
{  
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "Число не пятизначное!";
    else        
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "Число, не является палиндромом";
            n /= 10;
            num /= 100;
        }    
        return "Число, является палиндромом";
}

Console.WriteLine("Введите пятизначное число");
Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));
