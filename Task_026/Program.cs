// Задача 26: Напишите программу, которая принимает на вход число и выдаёт
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Enter the integer number: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}

int res = GetNumberOfDigitsInNumber(number);

Console.WriteLine($"Number of digit in the input number {res}");

int GetNumberOfDigitsInNumber(int number)
{
    int count = 1;             // сount = 1, т.к. любое число имеет хотя бы 1 цифру
    if (number < 0)
    {
        number = number * (-1);// если отрицательное число
    }
    while (number >= 10)
    {
        number = number / 10;
        count++;
        
    }
    return count;
}

