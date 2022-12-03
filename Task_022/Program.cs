/* Задача 22: Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
int[] array =
5 -> 1, 4, 9, 16, 25. 2 -> 1,4 */


int N = InputInt();

int[] squaresTable = GetTableOfSqures(N);

PrintArray(squaresTable);






int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool isN = int.TryParse(Console.ReadLine(), out int N);
    if (isN)
    {
        return N;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}


int [] GetTableOfSqures(int N)
{
    int[] arr = new int[N];
    int i = 0;
    while (i < N)
    {
        arr[i] = (int)(Math.Pow(i+1, 2)); //(int) - преобразует double в int
        i++;                        // Math.Pow(a,b) - возводит число a в степень b 
    }
    return arr;
}


void PrintArray (int[] arr)
{
       int i = 0;
    while (i < N)
    {
        Console.Write($"{arr[i]} ");
        i++;
    }
}
