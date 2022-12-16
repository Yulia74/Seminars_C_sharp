// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] array = CreateArrayRndInt(0, 10, 8);

PrintArray(array);

int[] newArray = CopyArray(array);

PrintArray(newArray);




int[] CreateArrayRndInt(int min, int max, int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(@"[{0}]", string.Join("; ", array));
}


int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}


