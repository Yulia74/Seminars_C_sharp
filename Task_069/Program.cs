// Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

Console.Write("Enter a number - the base of the degree (A):  ");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter a number - exponent (B):  ");

int b = int.Parse(Console.ReadLine());

Console.WriteLine($"The number A to the power of B is equal to   {PowerAB(a, b)}");



double PowerAB(double a, double b)
{
    if (b < 0) return (1 / a) * PowerAB(a, b + 1); // a ^ (-2) = 1 / (a * a)
    if (b > 0) return a * PowerAB(a, b - 1);
    else return 1;
}



