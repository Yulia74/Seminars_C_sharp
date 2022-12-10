﻿// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = GenerateArray(-100,100,123);          //7  вызываем метод с параметрами (какие хотим)
                                                    //   получаем здесь массив
PrintArray(array);                                  //10  вызываем метод по печатанию заданного массива

int count = FindNumberOfElements(array, 10, 99);            //12 вызываем метод, нахождения условия задачи

Console.WriteLine($"The number of array elements in the in the specified interval = {count}"); //13 выводим на экран 
                                                                                      //    результат


int[] GenerateArray(int min, int max, int length)   //1  метод, созадющий массив, принимает на вход
{                                                   //   минимальное, максимальное значение и размер массива
    Random random = new Random();                   //4  создаем объект Рандом
    int[] array = new int [length];                 //2  создаем массив с целыми числами, с заданным  
                                                    //   пользователем размером
    for (var i = 0; i < array.Length; i++)          //3  проходимся циклом по массиву
    {
        array[i] = random.Next(min, max + 1);       //5  обращаемся к массиву по индексу и вызываем в нем метод
    }
    return array;                                   //6 возвращаем массив
} 

void PrintArray(int[] array)                        //8 объявляем метод, который выводит массив на экран (принимает на вход массив)
{
     Console.WriteLine(@"[{0}]", string.Join(",", array)); //9 задаем конструкцию, как это будет выглядеть на экране
}    

int FindNumberOfElements(int[] array, int min, int max)               //11 объявляем метод, нахождение условия задачи
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
        {
            count++ ;
        }
    }
    return count;
}




