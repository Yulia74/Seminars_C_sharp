// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// Например: 34, 5 -> не кратно, остаток 4 
//           16, 4 -> кратно

Console.WriteLine("Enter number1");

int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number2");

int number2 = int.Parse(Console.ReadLine());

int remains = number1 % number2; 

if(remains == 0)
{
    Console.WriteLine("number1 is a multiple of the number2");
}
else
{
    Console.WriteLine($"non-multiple, remainder after division {remains}");
}