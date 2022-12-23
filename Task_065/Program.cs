﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
//  M = 4; N = 8 -> "4, 6, 7, 8"

PrintDigitsInterval(4, 8);

Console.WriteLine();


void PrintDigitsInterval(int a, int m)
{
    Console.Write(a + ", ");
    if (a < m)
        PrintDigitsInterval(a + 1, m);
}