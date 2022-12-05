//Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

if(!isParsed || number < 1 )
{
    Console.WriteLine("Incorrect number");
    return;
}
// метод, считывающий число и проверяющий его на корректность


int sum = GetSumOfNumbersInInterval(number);

Console.WriteLine(sum);

int GetSumOfNumbersInInterval(int number)
{
    int sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i; //добавить к уже имеющемуся значению (эквивалентно sum=sum+i)
    }
    return sum;
}
// Метод, находящий сумму


