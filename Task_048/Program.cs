// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₙₙ = m+n. Выведите полученный массив на экран: m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


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



int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
