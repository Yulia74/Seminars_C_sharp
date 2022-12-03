/* See Напишите программу, которая принимает на вход координаты двух точек
   и находит расстояние между ними в 2D пространстве.
   A (3,6); B (2,1) -> 5,09
   A (7,-5); B (1,-1) -> 7,21        d = √ (х А – х В) 2 + (у А – у В) 2   */

Console.WriteLine("Enter coordinates for point A (xA, yA)");

Console.Write("xA ");
int xA = int.Parse(Console.ReadLine());

Console.Write("yA ");
int yA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinates for point B(xB, yB)");

Console.Write("xB ");
int xB = int.Parse(Console.ReadLine());

Console.Write("yB ");
int yB = int.Parse(Console.ReadLine());

double GetDistanceBetweenTwoPoints(int xA, int yA, int xB, int yB)   // объявила метод
{
    double result = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
    return result;
}
double result =  GetDistanceBetweenTwoPoints(xA, yA, xB, yB);     // использовала метод

Console.WriteLine($"Distance between point A ({xA}, {yA}) and point B ({xB}, {yB}) = {Math.Round(result, 2)}"); 
// вывела результат, округлила до сотых


