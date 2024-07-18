﻿// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string CharsArrToString(char[,] chars)
{
    string result = "";

    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            result = result + chars[i, j];
        }
    }
    return result;
}

char[,] chars = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

string result = CharsArrToString(chars);
System.Console.WriteLine(result);