﻿﻿// Задача 4*(не обязательная): Задайте строку, состоящую из слов,
// разделенных пробелами. Сформировать строку, в которой слова
// расположены в обратном порядке. В полученной строке слова должны
// быть также разделены пробелами.


string ReverseWords(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
string result = ReverseWords(str);
Console.WriteLine(result);