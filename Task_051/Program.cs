// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной
// диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив: 1 47 2
//                         5 92 3
//                         8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] array = Create2DArray(5, 5, 1, 9);

Print2DArray(array);

GetSumElementsOnMainDiagonal(array);



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

void GetSumElementsOnMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i,j];
        }
    }
    Console.WriteLine($"Cумма элементов, находящихся на главной диагонали равна {sum}");
}

