// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// Например [1,0,1,1,0,1,0,0]

/*int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    Random random = new Random();          // сгенерировать случайное число
    arr[i] = new Random().Next(0, 2);      // заполняем созданный массив (0, 2) значениями
}                                          // от 0 до 1 (2 не входит в интервал)

 for (int i = 0; i < arr.Length; i++)         
 {                                          // выводим на печать созданный массив в строку
     Console.Write(arr[i] + " ");
 }*/




/*
bool isInt = int.TryParse(Console.ReadLine(), out int num);
if (!isInt)
{
    Console.WriteLine("incorrect number entered");
}
else
{
    int userLength = num;

int [] userArray = ArrayFilling(userLength);
PrintArr(userArray);

int[] ArrayFilling(int userLength)
{
    Random random = new Random();
    int[] arr = new int[userLength];
    for(int i=0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0,2);
    }
    return arr;
}

void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
}*/

int[] CreateArray(int l, int min, int max)
{
    int[] arr = new int[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int[] result = CreateArray(8, 0, 2);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

PrintArray(result);

