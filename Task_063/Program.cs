// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.
// N = 5    ->   "1, 2, 3, 4, 5"
// N = 6    ->   "1, 2, 3, 4, 5, 6"

PrintDigits(1, 5);

Console.WriteLine();


void PrintDigits(int a, int m)
{
    Console.Write(a + ", ");
    if (a < m)
        PrintDigits(a + 1, m);
}