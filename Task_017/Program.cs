// Напишите программу, которая принимает на вход координаты точки(X и Y),
// причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой  
// находится эта точка.

bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX || !isParsedY)   // || x == 0 || y == 0 
{
    Console.WriteLine("Координаты введены не корректно");
    return;
}
int quarterNumber = GetQuarterNumberByCoordinates(x,y);

if(quarterNumber == -1)
{
    Console.WriteLine("Координаты равны нулю");
    return;
}

Console.WriteLine(quarterNumber);

// возвращаемый_тип_данных Название Метода()
// {
//    return 1; // оператор return возращает из метода значение
//                 и останавливает его
// }

int GetQuarterNumberByCoordinates(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }

    if(x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }

    return -1;
}

