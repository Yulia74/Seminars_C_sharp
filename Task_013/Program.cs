// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// Например: 14 -> нет,   46 -> нет,   161 -> да

Console.WriteLine("Enter number");

int number = int.Parse(Console.ReadLine());


if(number % 7 == 0 && number % 23 == 0)
{
  Console.WriteLine("the entered number is a multiple of 7 & 23");
}
else
{
  Console.WriteLine("the entered number is not a multiple of 7 & 23");
}

