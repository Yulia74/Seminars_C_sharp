// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// Например: 5, 25 -> да,    -4, 16 -> да,       25, 5 -> да,       8,9 -> нет

Console.Write("Enter first number ");

// int number1 = int.Parse(Console.ReadLine()); 

bool isParsed = int.TryParse(Console.ReadLine(),out int number1); // заменяет строку 7

if(!isParsed)
{
    Console.WriteLine("what you entered is not a number");
    return;
}
Console.Write("Enter second number ");

bool isParsed1= int.TryParse(Console.ReadLine(),out int number2);

if(!isParsed1)
{
    Console.WriteLine("what you entered is not a number");
    return;
}
if(number2 == number1 * number1 || number1 == number2 * number2)
{
     Console.WriteLine("One of the entered numbers is the square of the other");
}
else
{
     Console.WriteLine("One of the entered numbers is not the square of the other");  
}