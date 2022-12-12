// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Enter the number a:  ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter the number b:  ");
int b = int.Parse(Console.ReadLine());

Console.Write("Enter the number c:  ");
int c = int.Parse(Console.ReadLine());

bool result = TriangleSidesCheck(a, b, c);

Console.WriteLine(result);




bool TriangleSidesCheck(int a, int b, int c)
{
    if(a + b <= c || a + c <= b || b + c <= a)
    {
        return false;
    }
    else
    {
        return true;
    }
}

