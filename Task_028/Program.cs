//Задача 28. Напишите программу, которая принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//Например: 4->24   5->120

Console.Write("Enter a natural number: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

if(!isParsed || number < 0)
{
    Console.WriteLine("Incorrect number");
    return;
}

double res = GetFactirialOfNumber(number);

Console.WriteLine($"Factorial of the entered number {res}");

double GetFactirialOfNumber(double number)
{
    int i = 1; 
    double res = 1;                     // тип переменных double, т.к. после 18 при int
                                        // программа считает факториал равен 0
    while (i <= number)
    {
        res = res * i;
        i++;
        
    }
    return res;
}
