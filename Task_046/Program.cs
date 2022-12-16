// Задайте двумерный массив размером m × n, заполненный случайными
// целыми числами. 
//   m = 3, n = 4
//   1   4   8   19
//   5  -2  33   -2 
//  77   3   8    1


int[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();                        // переводит курсор на новую строку
    }
}


int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}
