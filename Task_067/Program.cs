// Напишите программу, которая будет принимать на вход число и возвращать
// сумму его цифр.
// 453 -> 12
//  45 -> 9


Console.Write("Enter the first number n:  ");

int n = int.Parse(Console.ReadLine());


int SumDigits(int n)
{
    if (n > 0) return 
    SumDigits(n / 10) + n % 10;
    else return 0;
}

 Console.WriteLine($"Сумма цифр в числе: {SumDigits(n)}");
 Console.WriteLine();