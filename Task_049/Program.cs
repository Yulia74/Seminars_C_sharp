// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:
// 1 47 2
// 5 92 3
// 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 5 81 9
// 8 42 4

int[,] array = Create2DArray(5, 5, 1, 9);

Print2DArray(array);

Console.WriteLine();

SquareEvenIndexElem(array);

Print2DArray(array);




int[,] Create2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SquareEvenIndexElem(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                array[i, j] = array[i, j] * array[i, j];
        }
    }
}

