﻿// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


string Reverse(string a)
{
    char[] arr = a.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}
string Palindromer(string x)
{
    string y = Reverse(x);
    Console.WriteLine(y);
    if (Equals(x, y))
        return "Палиндром";
    else
        return "Не палиндром";
}


Console.WriteLine("Введите тестируемую строку");
string input = Console.ReadLine();
string str = input.ToLower();
Console.WriteLine(input + " - " + Palindromer(str));
Console.WriteLine();