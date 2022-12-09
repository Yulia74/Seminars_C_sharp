// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумма отрицательных и положительных
// элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

 
int[] array = GenerateArray(-9,9,12);               //7  вызываем метод с параметрами -9, 9, 12
                                                    //   получаем здесь массив
PrintArray(array);                                  //20 вызываем метод, который выводит на экран массив

int sumPositiveNumber = GetSumPositiveNumbersInArray(array);  //16 вызываем метод нахождения суммы положит.элем
int sumNegativeNumber = GetSumNegativeNumbersInArray(array);  //17 вызываем метод нахождения суммы отриц.элем

void PrintArray(int[] array)                        //19 объявляем метод, который выводит массив на экран (принимает на вход массив)
{
     Console.WriteLine(@"[{0}]", string.Join(",", array)); //(@"[{0}]", string.Join(",", array)) конструкция,
}                                                          // которая позволяет красиво выводить на экран массив                
                                                           // метод Сепаратор
// а можно эту строка написать так string message = string.Join(" ,", array);
//                                 Console.writeLine($[{string.Join(" ,", array)}]);                                        

Console.WriteLine($"Сумма положительных элементов массива = {sumPositiveNumber}, сумма отрицательных элементов массива = {sumNegativeNumber}");
                                                              //18 выводим на экран полученные значения

int GetSumPositiveNumbersInArray(int[] array)       //8  метод, находящий сумму положительных элементов массива,
{                                                   //   который на вход принимает массив, а на выход число
     int sumPositiveNumber = 0;                     //10 создаем переменную, которая первоначально равна 0
     for (var i = 0; i < array.Length; i++)         //9  проходим циклом по массиву
     {
        if(array[i] >= 0)                           //11 делаем проверку: если значение, которое лежит в массиве
        {                                           //   положительное
           sumPositiveNumber += array[i];           //12 то его прибавлем к переменной sum
        }                                           
                                                    //13 если нет, то нет                                       
     }
     return sumPositiveNumber;                      //14 возвращаем из метода результат (сумму)
}

int GetSumNegativeNumbersInArray(int[] array)       //15 тоже самое делаем для отрицательных чисел
{                                                   
     int sumNegativeNumber = 0;                     
     for (var i = 0; i < array.Length; i++)         
     {
        if(array[i] < 0)                            
        {                                           
           sumNegativeNumber += array[i];           
        }                                           
                                                                                       
     }
     return sumNegativeNumber;                      
}


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

